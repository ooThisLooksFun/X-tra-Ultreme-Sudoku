namespace WindowsFormsApp3
{
    partial class menuForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-tra Ultreme Sudoku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(261, 165);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(75, 23);
            this.pbtn.TabIndex = 1;
            this.pbtn.Text = "Play";
            this.pbtn.UseVisualStyleBackColor = true;
            this.pbtn.Click += new System.EventHandler(this.pbtn_Click);
            // 
            // tbtn
            // 
            this.tbtn.Location = new System.Drawing.Point(261, 249);
            this.tbtn.Name = "tbtn";
            this.tbtn.Size = new System.Drawing.Size(75, 23);
            this.tbtn.TabIndex = 2;
            this.tbtn.Text = "Themes";
            this.tbtn.UseVisualStyleBackColor = true;
            // 
            // rbtn
            // 
            this.rbtn.Location = new System.Drawing.Point(261, 336);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(75, 23);
            this.rbtn.TabIndex = 3;
            this.rbtn.Text = "Rules";
            this.rbtn.UseVisualStyleBackColor = true;
            this.rbtn.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Report Bugs";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rbtn);
            this.Controls.Add(this.tbtn);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.label1);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pbtn;
        private System.Windows.Forms.Button tbtn;
        private System.Windows.Forms.Button rbtn;
        private System.Windows.Forms.Button button4;
    }
}

