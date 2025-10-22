namespace CustomerManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbStudentManager = new System.Windows.Forms.Label();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.lbSname = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.lbSID = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lbView = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnFillRandom = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.gbStudentInfo.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStudentManager
            // 
            this.lbStudentManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbStudentManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStudentManager.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbStudentManager.Location = new System.Drawing.Point(1, 10);
            this.lbStudentManager.Name = "lbStudentManager";
            this.lbStudentManager.Size = new System.Drawing.Size(794, 35);
            this.lbStudentManager.TabIndex = 0;
            this.lbStudentManager.Text = "University Student Manager";
            this.lbStudentManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.cmbFaculty);
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
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 64);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(317, 212);
            this.gbStudentInfo.TabIndex = 1;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student information";
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "--Select Level--",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"});
            this.cmbLevel.Location = new System.Drawing.Point(112, 139);
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
            "--Selecet Major--"});
            this.cmbMajor.Location = new System.Drawing.Point(112, 178);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(183, 24);
            this.cmbMajor.Sorted = true;
            this.cmbMajor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Level:";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(22, 178);
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
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdbtnFemale);
            this.gbGender.Controls.Add(this.rdbtnMale);
            this.gbGender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(492, 64);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(219, 50);
            this.gbGender.TabIndex = 2;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(142, 22);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(67, 20);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(6, 22);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(52, 20);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "Details",
            "Large Icon",
            "Small Icon",
            "List",
            "Tile"});
            this.cmbView.Location = new System.Drawing.Point(560, 135);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(151, 21);
            this.cmbView.TabIndex = 13;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Location = new System.Drawing.Point(489, 138);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(65, 13);
            this.lbView.TabIndex = 12;
            this.lbView.Text = "Select View:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(492, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(492, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnFillRandom
            // 
            this.BtnFillRandom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFillRandom.Location = new System.Drawing.Point(619, 235);
            this.BtnFillRandom.Name = "BtnFillRandom";
            this.BtnFillRandom.Size = new System.Drawing.Size(92, 37);
            this.BtnFillRandom.TabIndex = 17;
            this.BtnFillRandom.Text = "Fill Random";
            this.BtnFillRandom.UseVisualStyleBackColor = true;
            this.BtnFillRandom.Click += new System.EventHandler(this.BtnFillRandom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(619, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(16, 297);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(772, 212);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "6833591.png");
            this.imageList2.Images.SetKeyName(1, "3233508.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "6833591.png");
            this.imageList1.Images.SetKeyName(1, "3233508.png");
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
            this.cmbFaculty.TabIndex = 12;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnFillRandom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.lbStudentManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentManager;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Label lbSname;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnFillRandom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ComboBox cmbFaculty;
    }
}

