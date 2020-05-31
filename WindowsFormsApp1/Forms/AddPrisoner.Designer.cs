using System.ComponentModel;

namespace WindowsFormsApp1.Forms
{
    partial class AddPrisoner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerGuard = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMonths = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddPrisoner = new System.Windows.Forms.Button();
            this.comboBoxStateNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(243, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Основна інформація:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я:";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxName.Location = new System.Drawing.Point(119, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(90, 17);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxSurname.Location = new System.Drawing.Point(521, 65);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(90, 17);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(429, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Прізвище:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(138, 107);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(90, 17);
            this.textBoxPatronymic.TabIndex = 6;
            this.textBoxPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "По-батькові:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(374, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата народження:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(488, 105);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerBirth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(243, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Стаття:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerGuard
            // 
            this.dateTimePickerGuard.Location = new System.Drawing.Point(488, 197);
            this.dateTimePickerGuard.Name = "dateTimePickerGuard";
            this.dateTimePickerGuard.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerGuard.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(374, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 41);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата взяття під варту:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(66, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Номер:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ув\'язнен на:";
            // 
            // textBoxYears
            // 
            this.textBoxYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxYears.Location = new System.Drawing.Point(88, 285);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(90, 17);
            this.textBoxYears.TabIndex = 17;
            this.textBoxYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(32, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Років:";
            // 
            // textBoxMonths
            // 
            this.textBoxMonths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxMonths.Location = new System.Drawing.Point(331, 286);
            this.textBoxMonths.Name = "textBoxMonths";
            this.textBoxMonths.Size = new System.Drawing.Size(90, 17);
            this.textBoxMonths.TabIndex = 19;
            this.textBoxMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(259, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Місяців:";
            // 
            // textBoxDays
            // 
            this.textBoxDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxDays.Location = new System.Drawing.Point(521, 285);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(90, 17);
            this.textBoxDays.TabIndex = 21;
            this.textBoxDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(467, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Днів:";
            // 
            // buttonAddPrisoner
            // 
            this.buttonAddPrisoner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAddPrisoner.Location = new System.Drawing.Point(226, 351);
            this.buttonAddPrisoner.Name = "buttonAddPrisoner";
            this.buttonAddPrisoner.Size = new System.Drawing.Size(247, 60);
            this.buttonAddPrisoner.TabIndex = 22;
            this.buttonAddPrisoner.Text = "Додати нового в\'язня";
            this.buttonAddPrisoner.UseVisualStyleBackColor = false;
            this.buttonAddPrisoner.Click += new System.EventHandler(this.buttonAddPrisoner_Click);
            // 
            // comboBoxStateNumber
            // 
            this.comboBoxStateNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comboBoxStateNumber.FormattingEnabled = true;
            this.comboBoxStateNumber.Location = new System.Drawing.Point(138, 197);
            this.comboBoxStateNumber.Name = "comboBoxStateNumber";
            this.comboBoxStateNumber.Size = new System.Drawing.Size(90, 21);
            this.comboBoxStateNumber.TabIndex = 23;
            foreach (var item in Global.Codex.Keys)
            {
                comboBoxStateNumber.Items.Add(item);
            }
            // 
            // AddPrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(692, 456);
            this.Controls.Add(this.comboBoxStateNumber);
            this.Controls.Add(this.buttonAddPrisoner);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxMonths);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerGuard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(698, 413);
            this.Name = "AddPrisoner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати нового в\'язня";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonAddPrisoner;
        private System.Windows.Forms.ComboBox comboBoxStateNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerGuard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxMonths;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxYears;

        #endregion
    }
}