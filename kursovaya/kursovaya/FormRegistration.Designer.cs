namespace kursovaya
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelPasSer = new System.Windows.Forms.Label();
            this.labelPasNum = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.maskedTextBoxPasSer = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPusNum = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewSeat = new System.Windows.Forms.DataGridView();
            this.labelSeat = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(47, 399);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(201, 39);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Зарегистрировать";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(47, 90);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(127, 22);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(313, 90);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(133, 22);
            this.textBoxPatronymic.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(180, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(127, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(44, 71);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(66, 16);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(180, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 16);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(310, 74);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(70, 16);
            this.labelPatronymic.TabIndex = 10;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelPasSer
            // 
            this.labelPasSer.AutoSize = true;
            this.labelPasSer.Location = new System.Drawing.Point(180, 137);
            this.labelPasSer.Name = "labelPasSer";
            this.labelPasSer.Size = new System.Drawing.Size(112, 16);
            this.labelPasSer.TabIndex = 11;
            this.labelPasSer.Text = "Серия паспорта";
            // 
            // labelPasNum
            // 
            this.labelPasNum.AutoSize = true;
            this.labelPasNum.Location = new System.Drawing.Point(44, 137);
            this.labelPasNum.Name = "labelPasNum";
            this.labelPasNum.Size = new System.Drawing.Size(115, 16);
            this.labelPasNum.TabIndex = 12;
            this.labelPasNum.Text = "Номер паспорта";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(313, 156);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(133, 24);
            this.comboBoxGender.TabIndex = 14;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(310, 137);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(99, 16);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "Выберите пол";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(501, 74);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(106, 16);
            this.labelBirth.TabIndex = 17;
            this.labelBirth.Text = "Дата рождения";
            // 
            // maskedTextBoxPasSer
            // 
            this.maskedTextBoxPasSer.Location = new System.Drawing.Point(183, 156);
            this.maskedTextBoxPasSer.Mask = "0000";
            this.maskedTextBoxPasSer.Name = "maskedTextBoxPasSer";
            this.maskedTextBoxPasSer.Size = new System.Drawing.Size(124, 22);
            this.maskedTextBoxPasSer.TabIndex = 18;
            this.maskedTextBoxPasSer.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPusNum
            // 
            this.maskedTextBoxPusNum.Location = new System.Drawing.Point(47, 156);
            this.maskedTextBoxPusNum.Mask = "000000";
            this.maskedTextBoxPusNum.Name = "maskedTextBoxPusNum";
            this.maskedTextBoxPusNum.Size = new System.Drawing.Size(127, 22);
            this.maskedTextBoxPusNum.TabIndex = 19;
            this.maskedTextBoxPusNum.ValidatingType = typeof(int);
            // 
            // dataGridViewSeat
            // 
            this.dataGridViewSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeat.ColumnHeadersVisible = false;
            this.dataGridViewSeat.Location = new System.Drawing.Point(504, 156);
            this.dataGridViewSeat.Name = "dataGridViewSeat";
            this.dataGridViewSeat.RowHeadersVisible = false;
            this.dataGridViewSeat.RowHeadersWidth = 51;
            this.dataGridViewSeat.RowTemplate.Height = 24;
            this.dataGridViewSeat.Size = new System.Drawing.Size(268, 282);
            this.dataGridViewSeat.TabIndex = 20;
            this.dataGridViewSeat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Location = new System.Drawing.Point(501, 137);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(114, 16);
            this.labelSeat.TabIndex = 21;
            this.labelSeat.Text = "Выберите место";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.dataGridViewSeat);
            this.Controls.Add(this.maskedTextBoxPusNum);
            this.Controls.Add(this.maskedTextBoxPasSer);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelPasNum);
            this.Controls.Add(this.labelPasSer);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelPasSer;
        private System.Windows.Forms.Label labelPasNum;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelSeat;
        public System.Windows.Forms.TextBox textBoxSurname;
        public System.Windows.Forms.TextBox textBoxPatronymic;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPasSer;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPusNum;
        public System.Windows.Forms.DataGridView dataGridViewSeat;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}