using System;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.CustomElements;

namespace WindowsFormsApp1.Forms
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new WindowsFormsApp1.Forms.CustomElements.TextBoxWithPlaceholder();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewCharacter = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label22 = new System.Windows.Forms.Label();
            this.listViewRelatives = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxStateText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMonths = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxStateReleaseDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxStateGuardDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxStateNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRoomFree = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRoomMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 34);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"ID", "ПІБ", "Номер статті", "Номер камери"});
            this.comboBox1.Location = new System.Drawing.Point(661, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.Location = new System.Drawing.Point(550, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Шукати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox1.Location = new System.Drawing.Point(39, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "Пошук";
            this.textBox1.Size = new System.Drawing.Size(512, 22);
            this.textBox1.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ПІБ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 186;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 58);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 376);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.listViewCharacter);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.listViewRelatives);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBoxStateText);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.textBoxDays);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.textBoxMonths);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBoxYears);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBoxStateReleaseDate);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBoxStateGuardDate);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBoxStateNumber);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxRoomFree);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxRoomMax);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxRoomNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxBirth);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxAge);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxPatronymic);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSurname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(248, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 376);
            this.panel2.TabIndex = 5;
            // 
            // listViewCharacter
            // 
            this.listViewCharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCharacter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader7});
            this.listViewCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewCharacter.FullRowSelect = true;
            this.listViewCharacter.GridLines = true;
            this.listViewCharacter.HideSelection = false;
            this.listViewCharacter.Location = new System.Drawing.Point(159, 568);
            this.listViewCharacter.MultiSelect = false;
            this.listViewCharacter.Name = "listViewCharacter";
            this.listViewCharacter.Size = new System.Drawing.Size(194, 135);
            this.listViewCharacter.TabIndex = 65;
            this.listViewCharacter.UseCompatibleStateImageBehavior = false;
            this.listViewCharacter.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Риса характеру";
            this.columnHeader7.Width = 174;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(155, 530);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(207, 24);
            this.label22.TabIndex = 64;
            this.label22.Text = "Особлива інформація:\r\n";
            // 
            // listViewRelatives
            // 
            this.listViewRelatives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRelatives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader3, this.columnHeader4, this.columnHeader5, this.columnHeader6});
            this.listViewRelatives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewRelatives.FullRowSelect = true;
            this.listViewRelatives.GridLines = true;
            this.listViewRelatives.HideSelection = false;
            this.listViewRelatives.Location = new System.Drawing.Point(49, 407);
            this.listViewRelatives.MultiSelect = false;
            this.listViewRelatives.Name = "listViewRelatives";
            this.listViewRelatives.Size = new System.Drawing.Size(439, 108);
            this.listViewRelatives.TabIndex = 63;
            this.listViewRelatives.UseCompatibleStateImageBehavior = false;
            this.listViewRelatives.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ім\'я";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Прізвище";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "По-батькові";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип рідства";
            this.columnHeader6.Width = 101;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(222, 371);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 24);
            this.label21.TabIndex = 62;
            this.label21.Text = "Родичі:\r\n";
            // 
            // textBoxStateText
            // 
            this.textBoxStateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxStateText.Location = new System.Drawing.Point(75, 298);
            this.textBoxStateText.Multiline = true;
            this.textBoxStateText.Name = "textBoxStateText";
            this.textBoxStateText.ReadOnly = true;
            this.textBoxStateText.Size = new System.Drawing.Size(437, 61);
            this.textBoxStateText.TabIndex = 61;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(20, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 19);
            this.label20.TabIndex = 60;
            this.label20.Text = "Текст:";
            // 
            // textBoxDays
            // 
            this.textBoxDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxDays.Location = new System.Drawing.Point(366, 259);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.ReadOnly = true;
            this.textBoxDays.Size = new System.Drawing.Size(49, 20);
            this.textBoxDays.TabIndex = 59;
            this.textBoxDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(325, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 19);
            this.label19.TabIndex = 58;
            this.label19.Text = "Днів:";
            // 
            // textBoxMonths
            // 
            this.textBoxMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxMonths.Location = new System.Drawing.Point(235, 259);
            this.textBoxMonths.Name = "textBoxMonths";
            this.textBoxMonths.ReadOnly = true;
            this.textBoxMonths.Size = new System.Drawing.Size(49, 20);
            this.textBoxMonths.TabIndex = 57;
            this.textBoxMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(180, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
            this.label18.TabIndex = 56;
            this.label18.Text = "Місяців:";
            // 
            // textBoxYears
            // 
            this.textBoxYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxYears.Location = new System.Drawing.Point(75, 259);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.ReadOnly = true;
            this.textBoxYears.Size = new System.Drawing.Size(49, 20);
            this.textBoxYears.TabIndex = 55;
            this.textBoxYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(20, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 19);
            this.label17.TabIndex = 54;
            this.label17.Text = "Років:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(20, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 19);
            this.label16.TabIndex = 53;
            this.label16.Text = "Ув\'язнен на:";
            // 
            // textBoxStateReleaseDate
            // 
            this.textBoxStateReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStateReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxStateReleaseDate.Location = new System.Drawing.Point(440, 198);
            this.textBoxStateReleaseDate.Name = "textBoxStateReleaseDate";
            this.textBoxStateReleaseDate.ReadOnly = true;
            this.textBoxStateReleaseDate.Size = new System.Drawing.Size(76, 20);
            this.textBoxStateReleaseDate.TabIndex = 52;
            this.textBoxStateReleaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(342, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 19);
            this.label15.TabIndex = 51;
            this.label15.Text = "Дата виходу:";
            // 
            // textBoxStateGuardDate
            // 
            this.textBoxStateGuardDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStateGuardDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxStateGuardDate.Location = new System.Drawing.Point(247, 199);
            this.textBoxStateGuardDate.Name = "textBoxStateGuardDate";
            this.textBoxStateGuardDate.ReadOnly = true;
            this.textBoxStateGuardDate.Size = new System.Drawing.Size(76, 20);
            this.textBoxStateGuardDate.TabIndex = 50;
            this.textBoxStateGuardDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(149, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 49;
            this.label14.Text = "Взят під варту:";
            // 
            // textBoxStateNumber
            // 
            this.textBoxStateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxStateNumber.Location = new System.Drawing.Point(75, 199);
            this.textBoxStateNumber.Name = "textBoxStateNumber";
            this.textBoxStateNumber.ReadOnly = true;
            this.textBoxStateNumber.Size = new System.Drawing.Size(49, 20);
            this.textBoxStateNumber.TabIndex = 48;
            this.textBoxStateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(20, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "Номер:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(222, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 46;
            this.label12.Text = "Стаття:\r\n";
            // 
            // textBoxRoomFree
            // 
            this.textBoxRoomFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxRoomFree.Location = new System.Drawing.Point(460, 142);
            this.textBoxRoomFree.Name = "textBoxRoomFree";
            this.textBoxRoomFree.ReadOnly = true;
            this.textBoxRoomFree.Size = new System.Drawing.Size(49, 20);
            this.textBoxRoomFree.TabIndex = 44;
            this.textBoxRoomFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(366, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Вільних місць:";
            // 
            // textBoxRoomMax
            // 
            this.textBoxRoomMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxRoomMax.Location = new System.Drawing.Point(274, 142);
            this.textBoxRoomMax.Name = "textBoxRoomMax";
            this.textBoxRoomMax.ReadOnly = true;
            this.textBoxRoomMax.Size = new System.Drawing.Size(49, 20);
            this.textBoxRoomMax.TabIndex = 42;
            this.textBoxRoomMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(163, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Максімум місць:";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(75, 142);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.ReadOnly = true;
            this.textBoxRoomNumber.Size = new System.Drawing.Size(49, 20);
            this.textBoxRoomNumber.TabIndex = 40;
            this.textBoxRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(20, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Номер:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(222, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Камера:\r\n";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(180, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 36);
            this.label7.TabIndex = 37;
            this.label7.Text = "Основна інформація:";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxID.Location = new System.Drawing.Point(448, 78);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(37, 20);
            this.textBoxID.TabIndex = 36;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(417, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID:";
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxBirth.Location = new System.Drawing.Point(281, 78);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.ReadOnly = true;
            this.textBoxBirth.Size = new System.Drawing.Size(76, 20);
            this.textBoxBirth.TabIndex = 34;
            this.textBoxBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(163, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Дата народження:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxAge.Location = new System.Drawing.Point(68, 77);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(38, 20);
            this.textBoxAge.TabIndex = 32;
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Вік:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(417, 36);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(95, 20);
            this.textBoxPatronymic.TabIndex = 30;
            this.textBoxPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(333, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "По-батькові:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxSurname.Location = new System.Drawing.Point(220, 39);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(95, 20);
            this.textBoxSurname.TabIndex = 28;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(149, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Прізвище:";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxName.Location = new System.Drawing.Point(39, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(95, 20);
            this.textBoxName.TabIndex = 26;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ім\'я:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Text = "Головна";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.ColumnHeader columnHeader1;
        protected System.Windows.Forms.ColumnHeader columnHeader2;
        protected System.Windows.Forms.ColumnHeader columnHeader3;
        protected System.Windows.Forms.ColumnHeader columnHeader4;
        protected System.Windows.Forms.ColumnHeader columnHeader5;
        protected System.Windows.Forms.ColumnHeader columnHeader6;
        protected System.Windows.Forms.ColumnHeader columnHeader7;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label20;
        protected System.Windows.Forms.Label label21;
        protected System.Windows.Forms.Label label22;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ListView listView1;
        protected System.Windows.Forms.ListView listViewCharacter;
        protected System.Windows.Forms.ListView listViewRelatives;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel2;
        private WindowsFormsApp1.Forms.CustomElements.TextBoxWithPlaceholder textBox1;
        protected System.Windows.Forms.TextBox textBoxAge;
        protected System.Windows.Forms.TextBox textBoxBirth;
        protected System.Windows.Forms.TextBox textBoxDays;
        protected System.Windows.Forms.TextBox textBoxID;
        protected System.Windows.Forms.TextBox textBoxMonths;
        protected System.Windows.Forms.TextBox textBoxName;
        protected System.Windows.Forms.TextBox textBoxPatronymic;
        protected System.Windows.Forms.TextBox textBoxRoomFree;
        protected System.Windows.Forms.TextBox textBoxRoomMax;
        protected System.Windows.Forms.TextBox textBoxRoomNumber;
        protected System.Windows.Forms.TextBox textBoxStateGuardDate;
        protected System.Windows.Forms.TextBox textBoxStateNumber;
        protected System.Windows.Forms.TextBox textBoxStateReleaseDate;
        protected System.Windows.Forms.TextBox textBoxStateText;
        protected System.Windows.Forms.TextBox textBoxSurname;
        protected System.Windows.Forms.TextBox textBoxYears;

        #endregion
    }
}