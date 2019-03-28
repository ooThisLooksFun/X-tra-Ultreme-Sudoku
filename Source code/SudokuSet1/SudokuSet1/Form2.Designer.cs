namespace SudokuSet1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbtn = new System.Windows.Forms.Button();
            this.tbtn = new System.Windows.Forms.Button();
            this.rbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-tra Ultreame Sudoku";
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(283, 149);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(75, 23);
            this.pbtn.TabIndex = 1;
            this.pbtn.Text = "Play";
            this.pbtn.UseVisualStyleBackColor = true;
            this.pbtn.Click += new System.EventHandler(this.pbtn_Click);
            // 
            // tbtn
            // 
            this.tbtn.Location = new System.Drawing.Point(283, 273);
            this.tbtn.Name = "tbtn";
            this.tbtn.Size = new System.Drawing.Size(75, 23);
            this.tbtn.TabIndex = 2;
            this.tbtn.Text = "Themes";
            this.tbtn.UseVisualStyleBackColor = true;
            this.tbtn.Click += new System.EventHandler(this.tbtn_Click);
            // 
            // rbtn
            // 
            this.rbtn.Location = new System.Drawing.Point(283, 387);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(75, 23);
            this.rbtn.TabIndex = 3;
            this.rbtn.Text = "Rules";
            this.rbtn.UseVisualStyleBackColor = true;
            this.rbtn.Click += new System.EventHandler(this.rbtn_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Report Bug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtn);
            this.Controls.Add(this.tbtn);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pbtn;
        private System.Windows.Forms.Button tbtn;
        private System.Windows.Forms.Button rbtn;
        private System.Windows.Forms.Button button1;
    }
}