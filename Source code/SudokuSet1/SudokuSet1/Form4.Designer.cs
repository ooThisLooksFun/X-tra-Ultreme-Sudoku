namespace SudokuSet1
{
    partial class Form4
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
            this.sumbtn = new System.Windows.Forms.Button();
            this.fallbtn = new System.Windows.Forms.Button();
            this.hallobtn = new System.Windows.Forms.Button();
            this.chrisbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.classbtn = new System.Windows.Forms.Button();
            this.beabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumbtn
            // 
            this.sumbtn.Location = new System.Drawing.Point(274, 162);
            this.sumbtn.Name = "sumbtn";
            this.sumbtn.Size = new System.Drawing.Size(75, 23);
            this.sumbtn.TabIndex = 0;
            this.sumbtn.Text = "Summer";
            this.sumbtn.UseVisualStyleBackColor = true;
            this.sumbtn.Click += new System.EventHandler(this.sumbtn_Click);
            // 
            // fallbtn
            // 
            this.fallbtn.Location = new System.Drawing.Point(274, 284);
            this.fallbtn.Name = "fallbtn";
            this.fallbtn.Size = new System.Drawing.Size(75, 23);
            this.fallbtn.TabIndex = 1;
            this.fallbtn.Text = "Fall";
            this.fallbtn.UseVisualStyleBackColor = true;
            this.fallbtn.Click += new System.EventHandler(this.fallbtn_Click);
            // 
            // hallobtn
            // 
            this.hallobtn.Location = new System.Drawing.Point(274, 344);
            this.hallobtn.Name = "hallobtn";
            this.hallobtn.Size = new System.Drawing.Size(75, 23);
            this.hallobtn.TabIndex = 2;
            this.hallobtn.Text = "Halloween";
            this.hallobtn.UseVisualStyleBackColor = true;
            this.hallobtn.Click += new System.EventHandler(this.hallobtn_Click);
            // 
            // chrisbtn
            // 
            this.chrisbtn.Location = new System.Drawing.Point(274, 411);
            this.chrisbtn.Name = "chrisbtn";
            this.chrisbtn.Size = new System.Drawing.Size(75, 23);
            this.chrisbtn.TabIndex = 3;
            this.chrisbtn.Text = "Christmas";
            this.chrisbtn.UseVisualStyleBackColor = true;
            this.chrisbtn.Click += new System.EventHandler(this.chrisbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(466, 543);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "THEMES";
            // 
            // classbtn
            // 
            this.classbtn.Location = new System.Drawing.Point(274, 468);
            this.classbtn.Name = "classbtn";
            this.classbtn.Size = new System.Drawing.Size(75, 23);
            this.classbtn.TabIndex = 6;
            this.classbtn.Text = "Classic";
            this.classbtn.UseVisualStyleBackColor = true;
            this.classbtn.Click += new System.EventHandler(this.classbtn_Click);
            // 
            // beabtn
            // 
            this.beabtn.Location = new System.Drawing.Point(274, 223);
            this.beabtn.Name = "beabtn";
            this.beabtn.Size = new System.Drawing.Size(75, 23);
            this.beabtn.TabIndex = 7;
            this.beabtn.Text = "Beach";
            this.beabtn.UseVisualStyleBackColor = true;
            this.beabtn.Click += new System.EventHandler(this.beabtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 654);
            this.Controls.Add(this.beabtn);
            this.Controls.Add(this.classbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.chrisbtn);
            this.Controls.Add(this.hallobtn);
            this.Controls.Add(this.fallbtn);
            this.Controls.Add(this.sumbtn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumbtn;
        private System.Windows.Forms.Button fallbtn;
        private System.Windows.Forms.Button hallobtn;
        private System.Windows.Forms.Button chrisbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classbtn;
        private System.Windows.Forms.Button beabtn;
    }
}