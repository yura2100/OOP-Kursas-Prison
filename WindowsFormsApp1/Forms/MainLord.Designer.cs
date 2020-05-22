using System.ComponentModel;

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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 58);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(247, 60);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Додати нового в\'язня";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // MainLord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.buttonAdd);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainLord";
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            //ListView1
            //
            this.listView1.Location = new System.Drawing.Point(-1, 118);
            this.listView1.Size = new System.Drawing.Size(248, 316);
        }

        private System.Windows.Forms.Button buttonAdd;

        #endregion
    }
}