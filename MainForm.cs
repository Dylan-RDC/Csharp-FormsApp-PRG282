using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Milestone2_PRG282.DataAccessLayer;
using Project_Milestone2_PRG282.BusinessLayer;
using System.IO;
using System.Globalization;

namespace Project_Milestone2_PRG282
{
    public partial class MainForm : Form
    {
        public static Form Creator;
        List<Student> s = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        DataHandler dh = new DataHandler();
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            bs.DataSource =  dh.getStudent();
            dgvDisplay.DataSource = bs;
            s = dh.getStudent();
            int i = 0;
            foreach (var sin in s)
                i = Int32.Parse(sin.StudNumber);
            i++;
            txtStudentNum.Text = i.ToString();
            lblDisplayCRUD.Text = "Insert a new student.";
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        lblDisplayCRUD.Text = "Insert a new student.";
                        break;
                    }
                case 1:
                    {
                        lblDisplayCRUD.Text = "Update/Delete student.";
                        break;
                    }
                case 2:
                    {
                        lblDisplayCRUD.Text = "Add a new module.";
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete *SOMEONE* from the database?", "WARNING", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

            }
        }
        string filename;
        private void btnPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })

            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    filename = odf.FileName;
                    lblFilePath.Text = filename;
                    picStudent.Image = Image.FromFile(filename);

                    string name = Path.GetFileName(filename);
                    string[] name1 = name.Split('.');
                    picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //if (txtStudName.Text != "" && txtStudSurname.Text != "" && txtPhone.Text != "" && cmbGender.SelectedIndex != -1 && richAddress.Text != "" && richModuleCodes.Text != "") ;
            Student tempStud = new Student(txtStudentNum.Text,txtStudName.Text,txtStudSurname.Text,txtPhone.Text,richAddress.Text,cmbGender.Text,dtDOB.Value,lblFilePath.Text);
            MessageBox.Show(tempStud.insertToDB());
            s = dh.getStudent();
            int i = 0;
            foreach (var sin in s)
                i = Int32.Parse(sin.StudNumber);
            i++;
            txtStudentNum.Text = i.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool success= false;
            foreach (var stud in s)
            {
                if (stud.StudNumber == edtStudNum.Text)
                {
                    stud.StudName = edtName.Text;
                    stud.StudSurname = edtSurname.Text;
                    stud.DateOfbirth = dtDate.Value;
                    stud.Phone = edtPhone.Text;
                    stud.Address = redAddress.Text;
                    stud.Gender = cbbGender.Text;
                    MessageBox.Show(stud.UpdateInDB());
                    success = true;
                }   
            }
            if (!success)
                MessageBox.Show("Update Failed");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows != null)
                if (dgvDisplay.SelectedRows.Count > 0)
                {
                    edtStudNum.Text = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();
                    edtName.Text = dgvDisplay.SelectedRows[0].Cells[1].Value.ToString();
                    edtSurname.Text = dgvDisplay.SelectedRows[0].Cells[2].Value.ToString();
                    edtPhone.Text = dgvDisplay.SelectedRows[0].Cells[3].Value.ToString();
                    redAddress.Text = dgvDisplay.SelectedRows[0].Cells[4].Value.ToString();
                    switch (dgvDisplay.SelectedRows[0].Cells[5].Value.ToString())
                    {
                        case "Male": cbbGender.SelectedIndex = 0;
                            break;
                        case "Female": cbbGender.SelectedIndex = 1;
                            break;
                        case "Undefined": cbbGender.SelectedIndex = 2;
                            break;
                        default: cbbGender.SelectedIndex = -1;
                            break;
                    }//Problem with getting date
                   // dtDate.Value = DateTime.ParseExact(dgvDisplay.SelectedRows[0].Cells[4].Value.ToString(),"yy-MM-dd",CultureInfo.InvariantCulture);
                }
                    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvDisplay.CurrentCell.RowIndex < dgvDisplay.Rows.Count -2)
            {
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Selected = false;
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex + 1].Selected = true;
                bs.MoveNext();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvDisplay.CurrentCell.RowIndex > 0)
            {
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex -1].Selected = true;
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Selected = false;
                bs.MovePrevious();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisplay.Rows[0].Selected = true;
            dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Selected = false;
            bs.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dgvDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvDisplay.Rows[dgvDisplay.Rows.Count-2].Selected = true;
            //dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Selected = false;
            //bs.MoveLast();

            while(dgvDisplay.CurrentCell.RowIndex < dgvDisplay.Rows.Count - 2)
            {
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Selected = false;
                dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex + 1].Selected = true;
                bs.MoveNext();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
