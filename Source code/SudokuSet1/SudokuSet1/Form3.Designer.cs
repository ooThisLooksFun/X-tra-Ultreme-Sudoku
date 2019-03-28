namespace SudokuSet1
{
    partial class rulesForm
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
            this.rulesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(263, 67);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(113, 31);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = "RULES!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Each number (1-9) must appear exactly once in every row, column and 3x3 square." +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "* A number cannot go into any cell if the same color already appears in that row," +
    " column or square.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(630, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Diagonal lines don\'t count - Only 3x3 squares, the horizontal rows and the vert" +
    "ical columns count.";
            // 
            // btnGoBack
            // 
            this.btnGoBack.AutoSize = true;
            this.btnGoBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(157, 416);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(307, 48);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Back To Main Menu";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // rulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 585);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rulesLabel);
            this.Name = "rulesForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.rulesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoBack;
    }
}