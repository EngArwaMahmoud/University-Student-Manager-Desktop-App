namespace CustomerManager
{
    partial class frmEdit
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
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.lbSname = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.lbSID = new System.Windows.Forms.Label();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.cmbFaculty);
            this.gbStudentInfo.Controls.Add(this.btnCancel);
            this.gbStudentInfo.Controls.Add(this.btnSave);
            this.gbStudentInfo.Controls.Add(this.cmbLevel);
            this.gbStudentInfo.Controls.Add(this.cmbMajor);
            this.gbStudentInfo.Controls.Add(this.label3);
            this.gbStudentInfo.Controls.Add(this.lbMajor);
            this.gbStudentInfo.Controls.Add(this.lbFaculty);
            this.gbStudentInfo.Controls.Add(this.tbSname);
            this.gbStudentInfo.Controls.Add(this.lbSname);
            this.gbStudentInfo.Controls.Add(this.tbSID);
            this.gbStudentInfo.Controls.Add(this.lbSID);
            this.gbStudentInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 26);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(360, 246);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student information";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "-- Select College --"});
            this.cmbFaculty.Location = new System.Drawing.Point(112, 98);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(183, 24);
            this.cmbFaculty.Sorted = true;
            this.cmbFaculty.TabIndex = 14;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(220, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"});
            this.cmbLevel.Location = new System.Drawing.Point(112, 136);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(183, 24);
            this.cmbLevel.TabIndex = 11;
            this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLevel_SelectedIndexChanged);
            // 
            // cmbMajor
            // 
            this.cmbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "--Select Major--"});
            this.cmbMajor.Location = new System.Drawing.Point(112, 173);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(183, 24);
            this.cmbMajor.Sorted = true;
            this.cmbMajor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Level:";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(22, 173);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(45, 16);
            this.lbMajor.TabIndex = 8;
            this.lbMajor.Text = "Major:";
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Location = new System.Drawing.Point(22, 98);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(52, 16);
            this.lbFaculty.TabIndex = 6;
            this.lbFaculty.Text = "Faculty:";
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(112, 59);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(183, 23);
            this.tbSname.TabIndex = 3;
            // 
            // lbSname
            // 
            this.lbSname.AutoSize = true;
            this.lbSname.Location = new System.Drawing.Point(22, 62);
            this.lbSname.Name = "lbSname";
            this.lbSname.Size = new System.Drawing.Size(45, 16);
            this.lbSname.TabIndex = 4;
            this.lbSname.Text = "Name:";
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(112, 24);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(183, 23);
            this.tbSID.TabIndex = 2;
            // 
            // lbSID
            // 
            this.lbSID.AutoSize = true;
            this.lbSID.Location = new System.Drawing.Point(22, 27);
            this.lbSID.Name = "lbSID";
            this.lbSID.Size = new System.Drawing.Size(72, 16);
            this.lbSID.TabIndex = 2;
            this.lbSID.Text = "Student ID:";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 274);
            this.Controls.Add(this.gbStudentInfo);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Label lbSname;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbFaculty;
    }
}