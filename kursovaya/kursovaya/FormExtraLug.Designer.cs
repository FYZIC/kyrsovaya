namespace kursovaya
{
    partial class FormExtraLug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtraLug));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxExtraLug = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вес багажа (кг, максимально 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxExtraLug
            // 
            this.textBoxExtraLug.Location = new System.Drawing.Point(94, 94);
            this.textBoxExtraLug.Mask = "00";
            this.textBoxExtraLug.Name = "textBoxExtraLug";
            this.textBoxExtraLug.Size = new System.Drawing.Size(208, 22);
            this.textBoxExtraLug.TabIndex = 3;
            this.textBoxExtraLug.ValidatingType = typeof(int);
            // 
            // FormExtraLug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.textBoxExtraLug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExtraLug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExtraLag";
            this.Load += new System.EventHandler(this.FormExtraLug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox textBoxExtraLug;
    }
}