﻿using System.ComponentModel;

namespace WindowsFormsApp1.Forms
{
    partial class MainLord
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
            this.buttonAddPrisoner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeletePrisoner = new System.Windows.Forms.Button();
            this.buttonAddRelative = new System.Windows.Forms.Button();
            this.buttonDeleteRelative = new System.Windows.Forms.Button();
            this.buttonDeleteCharacter = new System.Windows.Forms.Button();
            this.buttonAddCharacter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(157, 563);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(-1, 118);
            this.listView1.Size = new System.Drawing.Size(248, 316);
            // 
            // listViewCharacter
            // 
            this.listViewCharacter.Location = new System.Drawing.Point(170, 590);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDeleteCharacter);
            this.panel2.Controls.Add(this.buttonAddCharacter);
            this.panel2.Controls.Add(this.buttonDeleteRelative);
            this.panel2.Controls.Add(this.buttonAddRelative);
            this.panel2.Controls.Add(this.buttonDeletePrisoner);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxName, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxSurname, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxPatronymic, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxAge, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxBirth, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxID, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.label8, 0);
            this.panel2.Controls.SetChildIndex(this.label9, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxRoomNumber, 0);
            this.panel2.Controls.SetChildIndex(this.label10, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxRoomMax, 0);
            this.panel2.Controls.SetChildIndex(this.label11, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxRoomFree, 0);
            this.panel2.Controls.SetChildIndex(this.label12, 0);
            this.panel2.Controls.SetChildIndex(this.label13, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxStateNumber, 0);
            this.panel2.Controls.SetChildIndex(this.label14, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxStateGuardDate, 0);
            this.panel2.Controls.SetChildIndex(this.label15, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxStateReleaseDate, 0);
            this.panel2.Controls.SetChildIndex(this.label16, 0);
            this.panel2.Controls.SetChildIndex(this.label17, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxYears, 0);
            this.panel2.Controls.SetChildIndex(this.label18, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxMonths, 0);
            this.panel2.Controls.SetChildIndex(this.label19, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxDays, 0);
            this.panel2.Controls.SetChildIndex(this.label20, 0);
            this.panel2.Controls.SetChildIndex(this.textBoxStateText, 0);
            this.panel2.Controls.SetChildIndex(this.label21, 0);
            this.panel2.Controls.SetChildIndex(this.listViewRelatives, 0);
            this.panel2.Controls.SetChildIndex(this.label22, 0);
            this.panel2.Controls.SetChildIndex(this.listViewCharacter, 0);
            this.panel2.Controls.SetChildIndex(this.button2, 0);
            this.panel2.Controls.SetChildIndex(this.buttonDeletePrisoner, 0);
            this.panel2.Controls.SetChildIndex(this.buttonAddRelative, 0);
            this.panel2.Controls.SetChildIndex(this.buttonDeleteRelative, 0);
            this.panel2.Controls.SetChildIndex(this.buttonAddCharacter, 0);
            this.panel2.Controls.SetChildIndex(this.buttonDeleteCharacter, 0);
            // 
            // buttonAddPrisoner
            // 
            this.buttonAddPrisoner.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAddPrisoner.Location = new System.Drawing.Point(0, 58);
            this.buttonAddPrisoner.Name = "buttonAddPrisoner";
            this.buttonAddPrisoner.Size = new System.Drawing.Size(247, 60);
            this.buttonAddPrisoner.TabIndex = 6;
            this.buttonAddPrisoner.Text = "Додати нового в\'язня";
            this.buttonAddPrisoner.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.Location = new System.Drawing.Point(-1, 800);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 60);
            this.button2.TabIndex = 66;
            this.button2.Text = "Внести зміни";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePrisoner
            // 
            this.buttonDeletePrisoner.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeletePrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonDeletePrisoner.Location = new System.Drawing.Point(259, 800);
            this.buttonDeletePrisoner.Name = "buttonDeletePrisoner";
            this.buttonDeletePrisoner.Size = new System.Drawing.Size(260, 60);
            this.buttonDeletePrisoner.TabIndex = 67;
            this.buttonDeletePrisoner.Text = "Видалити в\'язня";
            this.buttonDeletePrisoner.UseVisualStyleBackColor = false;
            this.buttonDeletePrisoner.Click += new System.EventHandler(this.buttonDeletePrisoner_Click);
            // 
            // buttonAddRelative
            // 
            this.buttonAddRelative.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddRelative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRelative.Location = new System.Drawing.Point(49, 521);
            this.buttonAddRelative.Name = "buttonAddRelative";
            this.buttonAddRelative.Size = new System.Drawing.Size(219, 34);
            this.buttonAddRelative.TabIndex = 68;
            this.buttonAddRelative.Text = "Додати родича";
            this.buttonAddRelative.UseVisualStyleBackColor = false;
            this.buttonAddRelative.Click += new System.EventHandler(this.buttonAddRelative_Click);
            // 
            // buttonDeleteRelative
            // 
            this.buttonDeleteRelative.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteRelative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRelative.Location = new System.Drawing.Point(268, 521);
            this.buttonDeleteRelative.Name = "buttonDeleteRelative";
            this.buttonDeleteRelative.Size = new System.Drawing.Size(220, 34);
            this.buttonDeleteRelative.TabIndex = 69;
            this.buttonDeleteRelative.Text = "Видалити родича";
            this.buttonDeleteRelative.UseVisualStyleBackColor = false;
            this.buttonDeleteRelative.Click += new System.EventHandler(this.buttonDeleteRelative_Click);
            // 
            // buttonDeleteCharacter
            // 
            this.buttonDeleteCharacter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCharacter.Location = new System.Drawing.Point(259, 742);
            this.buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            this.buttonDeleteCharacter.Size = new System.Drawing.Size(220, 34);
            this.buttonDeleteCharacter.TabIndex = 71;
            this.buttonDeleteCharacter.Text = "Видалити рису характеру";
            this.buttonDeleteCharacter.UseVisualStyleBackColor = false;
            this.buttonDeleteCharacter.Click += new System.EventHandler(this.buttonDeleteCharacter_Click);
            // 
            // buttonAddCharacter
            // 
            this.buttonAddCharacter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCharacter.Location = new System.Drawing.Point(40, 742);
            this.buttonAddCharacter.Name = "buttonAddCharacter";
            this.buttonAddCharacter.Size = new System.Drawing.Size(219, 34);
            this.buttonAddCharacter.TabIndex = 70;
            this.buttonAddCharacter.Text = "Додати рису характеру";
            this.buttonAddCharacter.UseVisualStyleBackColor = false;
            this.buttonAddCharacter.Click += new System.EventHandler(this.buttonAddCharacter_Click_1);
            // 
            // MainLord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.buttonAddPrisoner);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainLord";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.buttonAddPrisoner, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddCharacter;
        private System.Windows.Forms.Button buttonAddPrisoner;
        private System.Windows.Forms.Button buttonAddRelative;
        private System.Windows.Forms.Button buttonDeleteCharacter;
        private System.Windows.Forms.Button buttonDeletePrisoner;
        private System.Windows.Forms.Button buttonDeleteRelative;

        #endregion
    }
}