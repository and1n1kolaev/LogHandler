
namespace LogHandler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkbox_type_E = new System.Windows.Forms.CheckBox();
            this.checkbox_type_W = new System.Windows.Forms.CheckBox();
            this.checkbox_type_D = new System.Windows.Forms.CheckBox();
            this.checkbox_type_I = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.subsystems_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.import_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.file_label = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.summary_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.type_e_label = new System.Windows.Forms.Label();
            this.type_w_label = new System.Windows.Forms.Label();
            this.type_d_label = new System.Windows.Forms.Label();
            this.type_i_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.computed_count_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkbox_type_E);
            this.groupBox3.Controls.Add(this.checkbox_type_W);
            this.groupBox3.Controls.Add(this.checkbox_type_D);
            this.groupBox3.Controls.Add(this.checkbox_type_I);
            this.groupBox3.Location = new System.Drawing.Point(1027, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип сообщения";
            // 
            // checkbox_type_E
            // 
            this.checkbox_type_E.AutoSize = true;
            this.checkbox_type_E.Location = new System.Drawing.Point(136, 25);
            this.checkbox_type_E.Name = "checkbox_type_E";
            this.checkbox_type_E.Size = new System.Drawing.Size(32, 19);
            this.checkbox_type_E.TabIndex = 3;
            this.checkbox_type_E.Text = "E";
            this.checkbox_type_E.UseVisualStyleBackColor = true;
            // 
            // checkbox_type_W
            // 
            this.checkbox_type_W.AutoSize = true;
            this.checkbox_type_W.Location = new System.Drawing.Point(93, 25);
            this.checkbox_type_W.Name = "checkbox_type_W";
            this.checkbox_type_W.Size = new System.Drawing.Size(37, 19);
            this.checkbox_type_W.TabIndex = 2;
            this.checkbox_type_W.Text = "W";
            this.checkbox_type_W.UseVisualStyleBackColor = true;
            // 
            // checkbox_type_D
            // 
            this.checkbox_type_D.AutoSize = true;
            this.checkbox_type_D.Location = new System.Drawing.Point(53, 25);
            this.checkbox_type_D.Name = "checkbox_type_D";
            this.checkbox_type_D.Size = new System.Drawing.Size(34, 19);
            this.checkbox_type_D.TabIndex = 1;
            this.checkbox_type_D.Text = "D";
            this.checkbox_type_D.UseVisualStyleBackColor = true;
            // 
            // checkbox_type_I
            // 
            this.checkbox_type_I.AutoSize = true;
            this.checkbox_type_I.Location = new System.Drawing.Point(18, 25);
            this.checkbox_type_I.Name = "checkbox_type_I";
            this.checkbox_type_I.Size = new System.Drawing.Size(29, 19);
            this.checkbox_type_I.TabIndex = 0;
            this.checkbox_type_I.Text = "I";
            this.checkbox_type_I.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.subsystems_combobox);
            this.groupBox4.Location = new System.Drawing.Point(445, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 59);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Подсистема";
            // 
            // subsystems_combobox
            // 
            this.subsystems_combobox.FormattingEnabled = true;
            this.subsystems_combobox.Location = new System.Drawing.Point(7, 24);
            this.subsystems_combobox.Name = "subsystems_combobox";
            this.subsystems_combobox.Size = new System.Drawing.Size(557, 23);
            this.subsystems_combobox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Период";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(224, 22);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(6, 22);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // import_button
            // 
            this.import_button.AllowDrop = true;
            this.import_button.Location = new System.Drawing.Point(12, 169);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(263, 23);
            this.import_button.TabIndex = 1;
            this.import_button.Text = "Начать импорт";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FileOpen_button);
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(205, 23);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(16, 15);
            this.file_label.TabIndex = 4;
            this.file_label.Text = "...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.file_label);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1216, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Файл";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.summary_label);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(12, 198);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 149);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Статистика импорта";
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.Location = new System.Drawing.Point(128, 125);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(16, 15);
            this.summary_label.TabIndex = 8;
            this.summary_label.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Общее количество:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.type_e_label);
            this.groupBox7.Controls.Add(this.type_w_label);
            this.groupBox7.Controls.Add(this.type_d_label);
            this.groupBox7.Controls.Add(this.type_i_label);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(6, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(252, 106);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Количество сообщений по типам";
            // 
            // type_e_label
            // 
            this.type_e_label.AutoSize = true;
            this.type_e_label.Location = new System.Drawing.Point(54, 74);
            this.type_e_label.Name = "type_e_label";
            this.type_e_label.Size = new System.Drawing.Size(16, 15);
            this.type_e_label.TabIndex = 7;
            this.type_e_label.Text = "...";
            // 
            // type_w_label
            // 
            this.type_w_label.AutoSize = true;
            this.type_w_label.Location = new System.Drawing.Point(54, 56);
            this.type_w_label.Name = "type_w_label";
            this.type_w_label.Size = new System.Drawing.Size(16, 15);
            this.type_w_label.TabIndex = 6;
            this.type_w_label.Text = "...";
            // 
            // type_d_label
            // 
            this.type_d_label.AutoSize = true;
            this.type_d_label.Location = new System.Drawing.Point(54, 37);
            this.type_d_label.Name = "type_d_label";
            this.type_d_label.Size = new System.Drawing.Size(16, 15);
            this.type_d_label.TabIndex = 5;
            this.type_d_label.Text = "...";
            // 
            // type_i_label
            // 
            this.type_i_label.AutoSize = true;
            this.type_i_label.Location = new System.Drawing.Point(54, 19);
            this.type_i_label.Name = "type_i_label";
            this.type_i_label.Size = new System.Drawing.Size(16, 15);
            this.type_i_label.TabIndex = 4;
            this.type_i_label.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тип E:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип I:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип W:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип D:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(940, 164);
            this.dataGridView1.TabIndex = 7;
            // 
            // search_button
            // 
            this.search_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.search_button.AllowDrop = true;
            this.search_button.Location = new System.Drawing.Point(959, 169);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(263, 23);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Поиск в БД";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Всего обработанных сообщений:";
            // 
            // computed_count_label
            // 
            this.computed_count_label.AutoSize = true;
            this.computed_count_label.Location = new System.Drawing.Point(208, 354);
            this.computed_count_label.Name = "computed_count_label";
            this.computed_count_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.computed_count_label.Size = new System.Drawing.Size(16, 15);
            this.computed_count_label.TabIndex = 10;
            this.computed_count_label.Text = "...";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 377);
            this.Controls.Add(this.computed_count_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LogHandler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox subsystems_combobox;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkbox_type_E;
        private System.Windows.Forms.CheckBox checkbox_type_W;
        private System.Windows.Forms.CheckBox checkbox_type_D;
        private System.Windows.Forms.CheckBox checkbox_type_I;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label summary_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label type_e_label;
        private System.Windows.Forms.Label type_w_label;
        private System.Windows.Forms.Label type_d_label;
        private System.Windows.Forms.Label type_i_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computed_count_label;
    }
}

