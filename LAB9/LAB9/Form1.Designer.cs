namespace LAB9
{
    partial class labFrm
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
            this.everythingBox = new System.Windows.Forms.GroupBox();
            this.mulResultLbl = new System.Windows.Forms.Label();
            this.mulSignLbl = new System.Windows.Forms.Label();
            this.mulBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.wordBtn = new System.Windows.Forms.Button();
            this.mulNumNud2 = new System.Windows.Forms.NumericUpDown();
            this.addNumNud2 = new System.Windows.Forms.NumericUpDown();
            this.mulNumNud1 = new System.Windows.Forms.NumericUpDown();
            this.addNumNud1 = new System.Windows.Forms.NumericUpDown();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.mulLbl = new System.Windows.Forms.Label();
            this.addResultLbl = new System.Windows.Forms.Label();
            this.addSignLbl = new System.Windows.Forms.Label();
            this.addLbl = new System.Windows.Forms.Label();
            this.wordLbl = new System.Windows.Forms.Label();
            this.hideChkBox = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.everythingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mulNumNud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNumNud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulNumNud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNumNud1)).BeginInit();
            this.SuspendLayout();
            // 
            // everythingBox
            // 
            this.everythingBox.Controls.Add(this.mulResultLbl);
            this.everythingBox.Controls.Add(this.mulSignLbl);
            this.everythingBox.Controls.Add(this.mulBtn);
            this.everythingBox.Controls.Add(this.addBtn);
            this.everythingBox.Controls.Add(this.wordBtn);
            this.everythingBox.Controls.Add(this.mulNumNud2);
            this.everythingBox.Controls.Add(this.addNumNud2);
            this.everythingBox.Controls.Add(this.mulNumNud1);
            this.everythingBox.Controls.Add(this.addNumNud1);
            this.everythingBox.Controls.Add(this.wordTextBox);
            this.everythingBox.Controls.Add(this.mulLbl);
            this.everythingBox.Controls.Add(this.addResultLbl);
            this.everythingBox.Controls.Add(this.addSignLbl);
            this.everythingBox.Controls.Add(this.addLbl);
            this.everythingBox.Controls.Add(this.wordLbl);
            this.everythingBox.Location = new System.Drawing.Point(12, 12);
            this.everythingBox.Name = "everythingBox";
            this.everythingBox.Size = new System.Drawing.Size(447, 283);
            this.everythingBox.TabIndex = 0;
            this.everythingBox.TabStop = false;
            this.everythingBox.Text = "Everything";
            // 
            // mulResultLbl
            // 
            this.mulResultLbl.AutoSize = true;
            this.mulResultLbl.Location = new System.Drawing.Point(390, 220);
            this.mulResultLbl.Name = "mulResultLbl";
            this.mulResultLbl.Size = new System.Drawing.Size(15, 15);
            this.mulResultLbl.TabIndex = 14;
            this.mulResultLbl.Text = "?";
            // 
            // mulSignLbl
            // 
            this.mulSignLbl.AutoSize = true;
            this.mulSignLbl.Location = new System.Drawing.Point(192, 220);
            this.mulSignLbl.Name = "mulSignLbl";
            this.mulSignLbl.Size = new System.Drawing.Size(16, 15);
            this.mulSignLbl.TabIndex = 13;
            this.mulSignLbl.Text = "x";
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(326, 212);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(39, 23);
            this.mulBtn.TabIndex = 12;
            this.mulBtn.Text = "=";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(326, 120);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(39, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "=";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // wordBtn
            // 
            this.wordBtn.Location = new System.Drawing.Point(252, 46);
            this.wordBtn.Name = "wordBtn";
            this.wordBtn.Size = new System.Drawing.Size(75, 23);
            this.wordBtn.TabIndex = 10;
            this.wordBtn.Text = "Yell";
            this.wordBtn.Click += new System.EventHandler(this.wordBtn_Click);
            // 
            // mulNumNud2
            // 
            this.mulNumNud2.DecimalPlaces = 2;
            this.mulNumNud2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.mulNumNud2.Location = new System.Drawing.Point(232, 209);
            this.mulNumNud2.Name = "mulNumNud2";
            this.mulNumNud2.Size = new System.Drawing.Size(79, 25);
            this.mulNumNud2.TabIndex = 9;
            // 
            // addNumNud2
            // 
            this.addNumNud2.Location = new System.Drawing.Point(229, 118);
            this.addNumNud2.Name = "addNumNud2";
            this.addNumNud2.Size = new System.Drawing.Size(82, 25);
            this.addNumNud2.TabIndex = 8;
            // 
            // mulNumNud1
            // 
            this.mulNumNud1.DecimalPlaces = 2;
            this.mulNumNud1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.mulNumNud1.Location = new System.Drawing.Point(90, 210);
            this.mulNumNud1.Name = "mulNumNud1";
            this.mulNumNud1.Size = new System.Drawing.Size(82, 25);
            this.mulNumNud1.TabIndex = 7;
            // 
            // addNumNud1
            // 
            this.addNumNud1.Location = new System.Drawing.Point(90, 118);
            this.addNumNud1.Name = "addNumNud1";
            this.addNumNud1.Size = new System.Drawing.Size(82, 25);
            this.addNumNud1.TabIndex = 6;
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(90, 43);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(156, 25);
            this.wordTextBox.TabIndex = 5;
            // 
            // mulLbl
            // 
            this.mulLbl.AutoSize = true;
            this.mulLbl.Location = new System.Drawing.Point(39, 172);
            this.mulLbl.Name = "mulLbl";
            this.mulLbl.Size = new System.Drawing.Size(91, 15);
            this.mulLbl.TabIndex = 4;
            this.mulLbl.Text = "Multiplication";
            // 
            // addResultLbl
            // 
            this.addResultLbl.AutoSize = true;
            this.addResultLbl.Location = new System.Drawing.Point(390, 128);
            this.addResultLbl.Name = "addResultLbl";
            this.addResultLbl.Size = new System.Drawing.Size(15, 15);
            this.addResultLbl.TabIndex = 3;
            this.addResultLbl.Text = "?";
            // 
            // addSignLbl
            // 
            this.addSignLbl.AutoSize = true;
            this.addSignLbl.Location = new System.Drawing.Point(192, 128);
            this.addSignLbl.Name = "addSignLbl";
            this.addSignLbl.Size = new System.Drawing.Size(15, 15);
            this.addSignLbl.TabIndex = 2;
            this.addSignLbl.Text = "+";
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Location = new System.Drawing.Point(39, 83);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(59, 15);
            this.addLbl.TabIndex = 1;
            this.addLbl.Text = "Addition";
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Location = new System.Drawing.Point(39, 46);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(42, 15);
            this.wordLbl.TabIndex = 0;
            this.wordLbl.Text = "Word";
            // 
            // hideChkBox
            // 
            this.hideChkBox.AutoSize = true;
            this.hideChkBox.Location = new System.Drawing.Point(12, 318);
            this.hideChkBox.Name = "hideChkBox";
            this.hideChkBox.Size = new System.Drawing.Size(131, 19);
            this.hideChkBox.TabIndex = 1;
            this.hideChkBox.Text = "Hide Everything";
            this.hideChkBox.UseVisualStyleBackColor = true;
            this.hideChkBox.CheckedChanged += new System.EventHandler(this.hideChkBox_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(384, 318);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // labFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 370);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.hideChkBox);
            this.Controls.Add(this.everythingBox);
            this.Name = "labFrm";
            this.Text = "Lab 9";
            this.everythingBox.ResumeLayout(false);
            this.everythingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mulNumNud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNumNud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulNumNud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNumNud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox everythingBox;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button wordBtn;
        private System.Windows.Forms.NumericUpDown mulNumNud2;
        private System.Windows.Forms.NumericUpDown addNumNud2;
        private System.Windows.Forms.NumericUpDown mulNumNud1;
        private System.Windows.Forms.NumericUpDown addNumNud1;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label mulLbl;
        private System.Windows.Forms.Label addResultLbl;
        private System.Windows.Forms.Label addSignLbl;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.Label mulResultLbl;
        private System.Windows.Forms.Label mulSignLbl;
        private System.Windows.Forms.CheckBox hideChkBox;
        private System.Windows.Forms.Button closeBtn;
    }
}

