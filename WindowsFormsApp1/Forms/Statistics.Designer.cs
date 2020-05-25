using System.ComponentModel;

namespace WindowsFormsApp1.Forms
{
    partial class Statistics
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
            this.listViewState = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listViewAge = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxState = new System.Windows.Forms.TextBox();
            this.textBoxMaxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAverageAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewState
            // 
            this.listViewState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2});
            this.listViewState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewState.FullRowSelect = true;
            this.listViewState.GridLines = true;
            this.listViewState.HideSelection = false;
            this.listViewState.Location = new System.Drawing.Point(0, 82);
            this.listViewState.MultiSelect = false;
            this.listViewState.Name = "listViewState";
            this.listViewState.Size = new System.Drawing.Size(390, 280);
            this.listViewState.TabIndex = 2;
            this.listViewState.UseCompatibleStateImageBehavior = false;
            this.listViewState.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Стаття";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Кількість в\'язнів";
            this.columnHeader2.Width = 187;
            // 
            // listViewAge
            // 
            this.listViewAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader3, this.columnHeader4});
            this.listViewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewAge.FullRowSelect = true;
            this.listViewAge.GridLines = true;
            this.listViewAge.HideSelection = false;
            this.listViewAge.Location = new System.Drawing.Point(398, 82);
            this.listViewAge.MultiSelect = false;
            this.listViewAge.Name = "listViewAge";
            this.listViewAge.Size = new System.Drawing.Size(392, 280);
            this.listViewAge.TabIndex = 3;
            this.listViewAge.UseCompatibleStateImageBehavior = false;
            this.listViewAge.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вік";
            this.columnHeader3.Width = 187;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Кількість в\'язнів";
            this.columnHeader4.Width = 188;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(390, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 416);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(140, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стаття";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(581, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(103, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Мода:";
            // 
            // textBoxMaxState
            // 
            this.textBoxMaxState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxMaxState.Location = new System.Drawing.Point(172, 388);
            this.textBoxMaxState.Name = "textBoxMaxState";
            this.textBoxMaxState.ReadOnly = true;
            this.textBoxMaxState.Size = new System.Drawing.Size(51, 19);
            this.textBoxMaxState.TabIndex = 8;
            this.textBoxMaxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMaxAge
            // 
            this.textBoxMaxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxMaxAge.Location = new System.Drawing.Point(475, 388);
            this.textBoxMaxAge.Name = "textBoxMaxAge";
            this.textBoxMaxAge.ReadOnly = true;
            this.textBoxMaxAge.Size = new System.Drawing.Size(51, 19);
            this.textBoxMaxAge.TabIndex = 10;
            this.textBoxMaxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(406, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Мода:";
            // 
            // textBoxAverageAge
            // 
            this.textBoxAverageAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAverageAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxAverageAge.Location = new System.Drawing.Point(727, 388);
            this.textBoxAverageAge.Name = "textBoxAverageAge";
            this.textBoxAverageAge.ReadOnly = true;
            this.textBoxAverageAge.Size = new System.Drawing.Size(51, 19);
            this.textBoxAverageAge.TabIndex = 12;
            this.textBoxAverageAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(582, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Середній вік:";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAverageAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaxState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewAge);
            this.Controls.Add(this.listViewState);
            this.Name = "Statistics";
            this.Text = "Статистика";
            this.VisibleChanged += new System.EventHandler(this.Statistics_VisibleChanged);
            this.Controls.SetChildIndex(this.listViewState, 0);
            this.Controls.SetChildIndex(this.listViewAge, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxMaxState, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxMaxAge, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxAverageAge, 0);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewAge;
        private System.Windows.Forms.ListView listViewState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAverageAge;
        private System.Windows.Forms.TextBox textBoxMaxAge;
        private System.Windows.Forms.TextBox textBoxMaxState;

        #endregion
    }
}