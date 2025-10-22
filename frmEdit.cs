using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManager
{
    public partial class frmEdit : Form
    {
        public string NewID { get; set; }
        public string NewName { get; set; }
        public string NewFaculty { get; set; }
        public string NewMajor { get; set; }
        public string NewLevel { get; set; }
        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit (string id, string name, string faculty, string major, string level)
        {

            InitializeComponent(); 

            tbSID.Text = id;
            tbSname.Text = name;
            cmbFaculty.SelectedItem = faculty;
            cmbMajor.SelectedItem = major;
            cmbLevel.SelectedItem = level;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedItem == null)
                return;

            NewID = tbSID.Text;
            NewName = tbSname.Text;
            NewFaculty = cmbFaculty.SelectedItem.ToString();
            NewMajor = cmbMajor.SelectedItem.ToString();
            NewLevel = cmbLevel.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedItem == null)
                return;
            cmbMajor.Items.Clear();
            cmbMajor.Items.Add("--Select Major--");
            cmbMajor.SelectedIndex = 0;
            switch (cmbFaculty.SelectedItem.ToString())
            {
                case "Engineering":
                    cmbMajor.Items.Add("Architectural Engineering");
                    cmbMajor.Items.Add("Artificial Intelligence Engineering");
                    cmbMajor.Items.Add("Biomedical Engineering");
                    cmbMajor.Items.Add("Chemical Engineering");
                    cmbMajor.Items.Add("Civil Engineering");
                    cmbMajor.Items.Add("Computer Engineering");
                    cmbMajor.Items.Add("Electronics & Communication Engineering");

                    cmbLevel.Items.Add("preparatory (إعدادي هندسة)");
                    break;

                case "Science":
                    cmbMajor.Items.Add("Physics");
                    cmbMajor.Items.Add("Chemistry");
                    cmbMajor.Items.Add("Biology");
                    cmbMajor.Items.Add("Mathematics");
                    break;

                case "Medicine":
                    cmbMajor.Items.Add("General Medicine");
                    cmbMajor.Items.Add("Dentistry");
                    cmbMajor.Items.Add("Pharmacy");
                    cmbMajor.Items.Add("Nursing");
                    break;

                case "Commerce":
                    cmbMajor.Items.Add("Accounting");
                    cmbMajor.Items.Add("Business Administration");
                    cmbMajor.Items.Add("Economics");
                    cmbMajor.Items.Add("Statistics");
                    break;

                case "Arts":
                    cmbMajor.Items.Add("History");
                    cmbMajor.Items.Add("Geography");
                    cmbMajor.Items.Add("Sociology");
                    cmbMajor.Items.Add("Psychology");
                    break;

                case "Computer & Information":
                    cmbMajor.Items.Add("Computer Science");
                    cmbMajor.Items.Add("Information Systems");
                    cmbMajor.Items.Add("Software Engineering");
                    cmbMajor.Items.Add("Artificial Intelligence");
                    break;
            }
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLevel.SelectedItem == "preparatory (إعدادي هندسة)")
            {
                cmbMajor.Items.Clear();
                cmbMajor.Items.Add("--Select Major--");
                cmbMajor.SelectedIndex = 0;
                cmbMajor.Items.Add((string)cmbLevel.SelectedItem);
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            cmbFaculty.Items.Add("Engineering");
            cmbFaculty.Items.Add("Science");
            cmbFaculty.Items.Add("Medicine");
            cmbFaculty.Items.Add("Commerce");
            cmbFaculty.Items.Add("Arts");
            cmbFaculty.Items.Add("Computer & Information");
        }
    }
}
