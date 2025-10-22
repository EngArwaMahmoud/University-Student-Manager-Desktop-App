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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddStudent(string ID,string name, string faculty, string majorIndex, string levelIndex)
        {
            ListViewItem item = new ListViewItem(name);

            item.SubItems.Add(ID);
            item.SubItems.Add(name);
            item.SubItems.Add(faculty);
            item.SubItems.Add(cmbMajor.Text.Trim());
            item.SubItems.Add(cmbLevel.Text.Trim());

            listView1.Items.Add(item);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Faculty", 150);
            listView1.Columns.Add("Major", 180);
            listView1.Columns.Add("Level", 180);

            cmbFaculty.Items.Add("Engineering");
            cmbFaculty.Items.Add("Science");
            cmbFaculty.Items.Add("Medicine");
            cmbFaculty.Items.Add("Commerce");
            cmbFaculty.Items.Add("Arts");
            cmbFaculty.Items.Add("Computer & Information");

            cmbMajor.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
            cmbView.SelectedIndex = 0;
            cmbFaculty.SelectedIndex = 0;

            tbSID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSID.Text) || string.IsNullOrEmpty(tbSname.Text))
                return;

            ListViewItem item = new ListViewItem(tbSID.Text.Trim());
            if (rdbtnFemale.Checked)
                item.ImageIndex = 0;
            if (rdbtnMale.Checked)
                item.ImageIndex = 1;

            item.SubItems.Add(tbSname.Text.Trim());
            item.SubItems.Add(cmbFaculty.Text.Trim());
            item.SubItems.Add(cmbMajor.Text.Trim());
            item.SubItems.Add(cmbLevel.Text.Trim());
            listView1.Items.Add(item);

            tbSID.Clear();
            tbSname.Clear();
            cmbFaculty.SelectedIndex = 0;
            cmbMajor.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;

            tbSID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    DialogResult result = MessageBox.Show(
                       "Are you sure you want to delete this student?",
                       "Confirm Delete",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                       );

                    if (result == DialogResult.Yes)
                    {
                        listView1.Items.Remove(item);
                    }
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text, "ID");
        }

        private void BtnFillRandom_Click(object sender, EventArgs e)
        {
            string[] faculties = { "Engineering", "Science", "Commerce", "Medicine" };
            string[] majors = { "Computer", "Electrical", "Mechanical", "Civil", "Architecture" };
            string[] levels = { "Preparatory", "Level 1", "Level 2", "Level 3", "Level 4" };

            Random rnd = new Random();

            for (int i = 1001; i <= 1010; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;

                item.SubItems.Add("Student "+i);
                item.SubItems.Add(faculties[rnd.Next(faculties.Length)]);
                item.SubItems.Add(majors[rnd.Next(majors.Length)]);
                item.SubItems.Add(levels[rnd.Next(levels.Length)]);
                listView1.Items.Add(item);
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbView.SelectedIndex)
            {
                case 0:
                    listView1.View = View.Details;
                    break;
                case 1:
                    listView1.View = View.LargeIcon;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.List;
                    break;
                case 4:
                    listView1.View = View.Tile;
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem SelectedItem = listView1.SelectedItems[0];

                string id = SelectedItem.SubItems[0].Text;
                string name = SelectedItem.SubItems[1].Text;
                string faculty = SelectedItem.SubItems[2].Text;
                string major = SelectedItem.SubItems[3].Text;
                string level = SelectedItem.SubItems[4].Text;

                frmEdit editForm = new frmEdit(id, name, faculty, major, level);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    SelectedItem.SubItems[0].Text = editForm.NewID;
                    SelectedItem.SubItems[1].Text = editForm.NewName;
                    SelectedItem.SubItems[2].Text = editForm.NewFaculty;
                    SelectedItem.SubItems[3].Text = editForm.NewMajor;
                    SelectedItem.SubItems[4].Text = editForm.NewLevel;
                }
            }
            else
            {
                MessageBox.Show("Please select a student first!");
            }
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
    }
}
