namespace Test2
{
    partial class frmPeople
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
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbtnAndroid = new System.Windows.Forms.RadioButton();
            this.rbtnApple = new System.Windows.Forms.RadioButton();
            this.lblMobile = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.gbxPeople = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.lblVisiblePeople = new System.Windows.Forms.Label();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.rbtnShowAndroid = new System.Windows.Forms.RadioButton();
            this.rbtnShowApple = new System.Windows.Forms.RadioButton();
            this.rbtnShowAll = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.gbxPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.btnAdd);
            this.gbxPerson.Controls.Add(this.btnClear);
            this.gbxPerson.Controls.Add(this.rbtnAndroid);
            this.gbxPerson.Controls.Add(this.rbtnApple);
            this.gbxPerson.Controls.Add(this.lblMobile);
            this.gbxPerson.Controls.Add(this.nudAge);
            this.gbxPerson.Controls.Add(this.lblAge);
            this.gbxPerson.Controls.Add(this.tbxLName);
            this.gbxPerson.Controls.Add(this.lblLName);
            this.gbxPerson.Controls.Add(this.tbxFName);
            this.gbxPerson.Controls.Add(this.lblFName);
            this.gbxPerson.Location = new System.Drawing.Point(12, 12);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(536, 188);
            this.gbxPerson.TabIndex = 0;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Person";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(368, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbtnAndroid
            // 
            this.rbtnAndroid.AutoSize = true;
            this.rbtnAndroid.Location = new System.Drawing.Point(157, 127);
            this.rbtnAndroid.Name = "rbtnAndroid";
            this.rbtnAndroid.Size = new System.Drawing.Size(77, 19);
            this.rbtnAndroid.TabIndex = 8;
            this.rbtnAndroid.TabStop = true;
            this.rbtnAndroid.Text = "Android";
            this.rbtnAndroid.UseVisualStyleBackColor = true;
            // 
            // rbtnApple
            // 
            this.rbtnApple.AutoSize = true;
            this.rbtnApple.Location = new System.Drawing.Point(87, 127);
            this.rbtnApple.Name = "rbtnApple";
            this.rbtnApple.Size = new System.Drawing.Size(64, 19);
            this.rbtnApple.TabIndex = 7;
            this.rbtnApple.TabStop = true;
            this.rbtnApple.Text = "Apple";
            this.rbtnApple.UseVisualStyleBackColor = true;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(6, 127);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(50, 15);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "Mobile";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(87, 93);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(443, 25);
            this.nudAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(88, 54);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(442, 25);
            this.tbxLName.TabIndex = 3;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(6, 57);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(76, 15);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(87, 18);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(443, 25);
            this.tbxFName.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(6, 21);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(75, 15);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // gbxPeople
            // 
            this.gbxPeople.Controls.Add(this.btnDeleteAll);
            this.gbxPeople.Controls.Add(this.dgvPeople);
            this.gbxPeople.Controls.Add(this.lblVisiblePeople);
            this.gbxPeople.Controls.Add(this.lblTotalPeople);
            this.gbxPeople.Controls.Add(this.rbtnShowAndroid);
            this.gbxPeople.Controls.Add(this.rbtnShowApple);
            this.gbxPeople.Controls.Add(this.rbtnShowAll);
            this.gbxPeople.Location = new System.Drawing.Point(12, 206);
            this.gbxPeople.Name = "gbxPeople";
            this.gbxPeople.Size = new System.Drawing.Size(536, 254);
            this.gbxPeople.TabIndex = 1;
            this.gbxPeople.TabStop = false;
            this.gbxPeople.Text = "People";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(424, 207);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(12, 51);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowTemplate.Height = 27;
            this.dgvPeople.Size = new System.Drawing.Size(512, 150);
            this.dgvPeople.TabIndex = 3;
            // 
            // lblVisiblePeople
            // 
            this.lblVisiblePeople.AutoSize = true;
            this.lblVisiblePeople.Location = new System.Drawing.Point(130, 204);
            this.lblVisiblePeople.Name = "lblVisiblePeople";
            this.lblVisiblePeople.Size = new System.Drawing.Size(122, 15);
            this.lblVisiblePeople.TabIndex = 5;
            this.lblVisiblePeople.Text = "Visible People : ?";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.AutoSize = true;
            this.lblTotalPeople.Location = new System.Drawing.Point(11, 204);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(113, 15);
            this.lblTotalPeople.TabIndex = 4;
            this.lblTotalPeople.Text = "Total People : ?";
            // 
            // rbtnShowAndroid
            // 
            this.rbtnShowAndroid.AutoSize = true;
            this.rbtnShowAndroid.Location = new System.Drawing.Point(330, 26);
            this.rbtnShowAndroid.Name = "rbtnShowAndroid";
            this.rbtnShowAndroid.Size = new System.Drawing.Size(194, 19);
            this.rbtnShowAndroid.TabIndex = 2;
            this.rbtnShowAndroid.Text = "Only show Android users";
            this.rbtnShowAndroid.UseVisualStyleBackColor = true;
            this.rbtnShowAndroid.CheckedChanged += new System.EventHandler(this.rbtnShowAndroid_CheckedChanged);
            // 
            // rbtnShowApple
            // 
            this.rbtnShowApple.AutoSize = true;
            this.rbtnShowApple.Location = new System.Drawing.Point(143, 26);
            this.rbtnShowApple.Name = "rbtnShowApple";
            this.rbtnShowApple.Size = new System.Drawing.Size(181, 19);
            this.rbtnShowApple.TabIndex = 1;
            this.rbtnShowApple.Text = "Only show Apple users";
            this.rbtnShowApple.UseVisualStyleBackColor = true;
            this.rbtnShowApple.CheckedChanged += new System.EventHandler(this.rbtnShowApple_CheckedChanged);
            // 
            // rbtnShowAll
            // 
            this.rbtnShowAll.AutoSize = true;
            this.rbtnShowAll.Checked = true;
            this.rbtnShowAll.Location = new System.Drawing.Point(12, 25);
            this.rbtnShowAll.Name = "rbtnShowAll";
            this.rbtnShowAll.Size = new System.Drawing.Size(125, 19);
            this.rbtnShowAll.TabIndex = 0;
            this.rbtnShowAll.TabStop = true;
            this.rbtnShowAll.Text = "Show all users";
            this.rbtnShowAll.UseVisualStyleBackColor = true;
            this.rbtnShowAll.CheckedChanged += new System.EventHandler(this.rbtnShowAll_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(436, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxPeople);
            this.Controls.Add(this.gbxPerson);
            this.Name = "frmPeople";
            this.Text = "People";
            this.gbxPerson.ResumeLayout(false);
            this.gbxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.gbxPeople.ResumeLayout(false);
            this.gbxPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtnAndroid;
        private System.Windows.Forms.RadioButton rbtnApple;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.GroupBox gbxPeople;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblVisiblePeople;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.RadioButton rbtnShowAndroid;
        private System.Windows.Forms.RadioButton rbtnShowApple;
        private System.Windows.Forms.RadioButton rbtnShowAll;
        private System.Windows.Forms.Button btnClose;
    }
}

