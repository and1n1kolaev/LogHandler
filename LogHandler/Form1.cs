
using LogHandler.DAL;
using LogHandler.DAL.Entities;
using LogHandler.DAL.Interfaces;
using LogHandler.DAL.Repositories;
using LogHandler.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogHandler
{
    public partial class Form1 : Form
    {
        private bool _isImport;
        private string _fileName;

        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileManager _fileManager;
        private readonly IParseCollectionManager _parseCollectionManager;
        private readonly IImportManager _importManager;

        public Form1()
        {
            InitializeComponent();

            _fileManager = new FileManager();
            _parseCollectionManager = new ParseCollectionManager();

            ApplicationDbContext dbContext = new ApplicationDbContext();
            _unitOfWork = new EFUnitOfWork(dbContext);
            _importManager = new LogImportManager(_unitOfWork);

            UInit();
        }

        private void FileOpen_button(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDialog1.FileName;
                file_label.Text = _fileName;
            }
        }


        private void import_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_fileName))
            {
                _isImport = !_isImport;

                if (_isImport)
                {
                    dataGridView1.Rows.Clear();
                    import_button.Text = "Остановить импорт";
                    ImportAsync();
                }
                else
                {
                    import_button.Text = "Начать импорт";
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DbSearchAsync();
        }


        private async void DbSearchAsync()
        {

            await Task.Run(() =>
            {
                try
                {
                    var importParametrs = BuildFilterParametrs();
                    var logs = _unitOfWork.LogRepository.FindAll(p =>
                                        p.DateTime >= importParametrs.DateTimeFrom
                                        && p.DateTime <= importParametrs.DateTimeTo
                                        && (string.IsNullOrEmpty(importParametrs.Sybsystem) || p.Subsystem.Name == importParametrs.Sybsystem)
                                        && (!importParametrs.Types.Any() || importParametrs.Types.Contains(p.Type.Name)));


                    Invoke((MethodInvoker)delegate ()
                    {
                        dataGridView1.Rows.Clear();
                    });

                    foreach (var log in logs)
                    {
                        Invoke((MethodInvoker)delegate ()
                        {

                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                            row.Cells[0].Value = log.DateTime;
                            row.Cells[1].Value = log.Type.Name;
                            row.Cells[2].Value = log.Subsystem.Name;
                            row.Cells[3].Value = log.Text;


                            dataGridView1.Rows.Add(row);
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка поиска: {ex.Message}");
                }
            });

        }



        private async void ImportAsync()
        {
            try
            {
                var importStatistic = new ImportStatistic();
                var importParametrs = BuildFilterParametrs();
                await Task.Run(() =>
                   {
                       try
                       {
                           UpdateImportStatistic(importStatistic);

                           var stringsCollection = _fileManager.ReadFile(_fileName);
                           var logCollection = _parseCollectionManager.StringsToObjects<LogItem>(stringsCollection);

                           var filteredLogCollection = logCollection
                                    .Where(p =>
                                                p.DateTime >= importParametrs.DateTimeFrom
                                                && p.DateTime <= importParametrs.DateTimeTo
                                                && (string.IsNullOrEmpty(importParametrs.Sybsystem) || p.Subsystem == importParametrs.Sybsystem)
                                                && (!importParametrs.Types.Any() || importParametrs.Types.Contains(p.Type)));

                           foreach (var logItem in filteredLogCollection)
                           {
                               if (!_isImport)
                                   break;

                               var status = _importManager.ImportAsync(logItem);

                               importStatistic.UpdateStatistic(logItem, status);
                               UpdateImportStatistic(importStatistic);

                           }
                       }
                       catch (Exception ex)
                       {
                           throw new Exception($"Ошибка обработки лога: {ex.Message}");
                       }
                   });
            }
            catch (OperationCanceledException)
            { }
            finally
            {
                import_button.Text = "Начать импорт";
                _isImport = false;
            }
        }

        private void UpdateImportStatistic(ImportStatistic importStatistic)
        {
            try
            {
                Invoke((MethodInvoker)delegate ()
                    {
                        type_i_label.Text = importStatistic.CountTypeI.ToString();
                        type_d_label.Text = importStatistic.CountTypeD.ToString();
                        type_w_label.Text = importStatistic.CountTypeW.ToString();
                        type_e_label.Text = importStatistic.CountTypeE.ToString();
                        summary_label.Text = importStatistic.AmountImported.ToString();
                        computed_count_label.Text = importStatistic.AmountComputed.ToString();
                    });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обновления статистики: {ex.Message}");
            }
        }

        private FilterParametrs BuildFilterParametrs()
        {
            try
            {
                FilterParametrs filterParametrs = new FilterParametrs();
                Invoke((MethodInvoker)delegate ()
                {
                    filterParametrs.DateTimeFrom = dateTimePickerFrom.Value;
                    filterParametrs.DateTimeTo = dateTimePickerTo.Value;
                    filterParametrs.Sybsystem = subsystems_combobox.Text;

                    if (checkbox_type_I.Checked) filterParametrs.Types.Add('I');
                    if (checkbox_type_E.Checked) filterParametrs.Types.Add('E');
                    if (checkbox_type_D.Checked) filterParametrs.Types.Add('D');
                    if (checkbox_type_W.Checked) filterParametrs.Types.Add('W');
                });

                return filterParametrs;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка получения параметров фильтра: {ex.Message}");
            }
        }


        private void UInit()
        {
            try
            {
                var subsystems = _fileManager.ReadFile(Properties.Settings.Default.Subsystems).ToArray();
                subsystems_combobox.Items.AddRange(subsystems);

                var dateTimePickerFormat = "dd.MM.yyyy HH:mm";
                dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
                dateTimePickerFrom.CustomFormat = dateTimePickerFormat;

                dateTimePickerTo.Format = DateTimePickerFormat.Custom;
                dateTimePickerTo.CustomFormat = dateTimePickerFormat;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns.Add("DateTime", "Дата/Время");
                dataGridView1.Columns.Add("Subsystem", "Подсистема");
                dataGridView1.Columns.Add("Type", "Тип сообщения");
                dataGridView1.Columns.Add("Text", "Текст");

                openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка инициализации интерфейса: {ex.Message}");
            }
        }


    }
}
