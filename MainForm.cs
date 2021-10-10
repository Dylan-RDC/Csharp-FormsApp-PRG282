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
using System.Drawing.Imaging;

namespace Project_Milestone2_PRG282
{
    public partial class MainForm : Form
    {
        
        public static Form Creator;
        List<Student> s;
        List<Module> modules = new List<Module>();
        Image studpic_Update;
        public MainForm()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        DataHandler dh = new DataHandler();
        private void MainForm_Load(object sender, EventArgs e)
        {
       
            

            dgvDisplay.DefaultCellStyle.SelectionBackColor = Color.FromArgb(125, 197, 196); ;
            DisplayStudents();
            tabControl1.SelectedIndex = 0;

            modules = dh.ReadModules();

            foreach (var item in modules)//displays all modules insede the second checklistbox//
            {
                checkedListBox2.Items.Add(item.ModuleCode);
            }

            List<Module> newModuleList = new List<Module>();
            newModuleList = dh.FilterModules(edtStudNum.Text);

            for (int j = 0; j < checkedListBox2.Items.Count; j++)
            {
                checkedListBox2.SetItemChecked(j, false);
            }

            foreach (Module item in newModuleList)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (item.ModuleCode.ToString() == checkedListBox2.Items[i].ToString())
                    {
                        checkedListBox2.SetItemChecked(i, true);
                    }
                }
            }

            UpdateModuleDisplay();

        }

        public void UpdateModuleDisplay()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            foreach (var item in modules)//displays all modules//
            {
                checkedListBox1.Items.Add(item.ModuleCode);
                checkedListBox2.Items.Add(item.ModuleCode);
            }

            
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        lblDisplayCRUD.Text = "Add a Student:";
                        txtSearch.Text = "Student Number";
                        DisplayStudents();
                        modules = dh.ReadModules();
                        UpdateModuleDisplay();
                        break;
                    }
                case 1:
                    {
                        lblDisplayCRUD.Text = "Edit Students:";
                        txtSearch.Text = "Student Number";
                        DisplayStudents();
                        break;
                    }
                case 2:
                    {
                        lblDisplayCRUD.Text = "Add a Module:";
                        txtSearch.Text = "Module Code";
                        DisplayModules();
                        break;
                    }
                case 3:
                    {
                        lblDisplayCRUD.Text = "Edit Modules:";
                        txtSearch.Text = "Modulce Code";
                        DisplayModules();
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
            this.Dispose();

   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Are you sure you want to delete StudentNo: {0} from the database?",edtStudNum.Text), "WARNING", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(dh.Delete(int.Parse(edtStudNum.Text)));
                DisplayStudents();
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
            byte[] imgbytes;

            ImageConverter imgCon = new ImageConverter();
            imgbytes =  (byte[])imgCon.ConvertTo(picStudent.Image, typeof(byte[]));


            Student tempStud = new Student(txtStudentNum.Text, txtStudName.Text, txtStudSurname.Text, txtPhone.Text, richAddress.Text, cmbGender.Text, dtDOB.Value, imgbytes);
            MessageBox.Show(tempStud.insertToDB());
            List<string> Mods = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    Mods.Add(checkedListBox1.Items[i].ToString());
                }
            }
            StudentModule studMod = new StudentModule(int.Parse(tempStud.StudNumber), Mods);
            studMod.sendInsertToDataHandler();

            DisplayStudents(); //---------------------------------------------------------------------------------------------------------------------------------------------------------------



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> Mods = new List<string>();
            for (int x = 0; x < checkedListBox2.Items.Count; x++)
            {
                if (checkedListBox2.GetItemCheckState(x) == CheckState.Checked)
                    Mods.Add(checkedListBox2.Items[x].ToString());
            }
            StudentModule SM = new StudentModule(int.Parse(edtStudNum.Text),Mods);
            MessageBox.Show($"Update Modules: {SM.UpdateModules()}" );
            bool success= false;
            foreach (var stud in s)
            {
                if (stud.StudNumber == edtStudNum.Text)
                {
                    Image img = PreviewPic.Image;
                    stud.StudName = edtName.Text;
                    stud.StudSurname = edtSurname.Text;
                    stud.DateOfbirth = dtDate.Value;
                    stud.Phone = edtPhone.Text;
                    stud.Address = redAddress.Text;
                    stud.Gender = cbbGender.Text;

                    if (studpic_Update != PreviewPic.Image)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, ImageFormat.Jpeg);
                            stud.ImageData = ms.ToArray();
                            ms.Dispose();
                        }
                    }
                   


                    MessageBox.Show($"Student Updated: {stud.UpdateInDB()} ");
                        success = true;
                        DisplayStudents();
                        lblUpdatePath.Text = "";
  
                }   
            }
            
            if (!success)
            {
                MessageBox.Show("Update Failed");
                return;
            }

           
                
            
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            List<Module> module_list = new List<Module>();
            module_list = dh.ReadModules();
            Student stud;
            Module mod;


            if (dgvDisplay.SelectedRows != null)
            {
               // MessageBox.Show(bs.Current.GetType().ToString()) ;
                if (( stud = bs.Current as Student) != null)
                {//checks if the display is displaying the correct objects
                    if (dgvDisplay.SelectedRows.Count > 0)
                     {
                        edtStudNum.Text = stud.StudNumber.ToString();
                        edtName.Text = stud.StudName; ;
                        edtSurname.Text = stud.StudSurname; ;
                        edtPhone.Text = stud.Phone; 
                        redAddress.Text = stud.Address;
                        dtDate.Value = stud.DateOfbirth; // FIXED THE DATE DISPLAY WHEN CLICKED ON THE DATAGRIDVIEW

                        
                        byte[] imagedata = stud.ImageData;
                        using (MemoryStream ms = new MemoryStream(imagedata))
                        {
                
                            studpic_Update = Image.FromStream(ms);
                        }

                        PreviewPic.Image = studpic_Update;





                        switch (stud.Gender)
                        {
                            case "Male":
                                cbbGender.SelectedIndex = 0;
                                break;
                            case "Female":
                                cbbGender.SelectedIndex = 1;
                                break;
                            case "Undefined":
                                cbbGender.SelectedIndex = 2;
                                break;
                            default:
                                cbbGender.SelectedIndex = -1;
                                break;
                        }//Problem with getting date
                         //dtDate.Text = DateTime.ParseExact(dgvDisplay.SelectedRows[0].Cells[7].Value.ToString(),"yy-MM-dd",CultureInfo.InvariantCulture).ToString();
                         //Try it with the format: yyyy-MM-dd

                        // insert the data from DGV to check list box
                        List<Module> newModuleList = dh.FilterModules(edtStudNum.Text);


                        for (int j = 0; j < checkedListBox2.Items.Count; j++)
                        {
                            checkedListBox2.SetItemChecked(j, false);
                        }

                        foreach (Module item in newModuleList)
                        {
                            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                            {
                                if (item.ModuleCode.ToString() == checkedListBox2.Items[i].ToString())
                                {
                                    checkedListBox2.SetItemChecked(i, true);
                                }
                            }
                        }
                      }

                    }
                else
                {
                    if ((mod = bs.Current as Module) != null)
                    {
                        mod = (Module)bs.Current;

                        txtMCode_UD.Text = mod.ModuleCode;
                        txtMDescrp_UD.Text = mod.Description;
                        txtMLink_UD.Text = mod.Links;
                        txtMName_UD.Text = mod.ModuleName;


                    }
                }
                }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        
            bs.MovePrevious();
         
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           
            bs.MoveFirst();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            bs.MoveLast();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnResetStudent_Click(object sender, EventArgs e)
        {
            richAddress.Clear();
            //richModuleCodes.Clear();
            txtPhone.Clear();
            txtStudName.Clear();
            cmbGender.SelectedIndex = -1;
            txtStudSurname.Clear();
            picStudent.Image = null;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student studtest;
            Module mod;

            if ((studtest = bs.Current as Student) != null)
            {
                int index = 0;
                string value = dh.Search_Students(txtSearch.Text);
                if (value != "1")
                {

                    foreach (var stud in s)
                    {
                        if (txtSearch.Text == stud.StudNumber)
                        {

                            index = bs.IndexOf(stud); // searches the for the stud in the source if found will change the index to the index of the stud thus invoking the update information invoked by the DGV itself
                            bs.Position = index;
                            //tabControl1.SelectedIndex = 1;


                           /* checkedListBox1.Items.Clear();
                            foreach (var item in module_list)//displays all modules for 2nd checklistbox//
                            {
                                checkedListBox2.Items.Add(item.ModuleCode);
                            }
                            List<Module> newModuleList = new List<Module>();
                            newModuleList = dh.FilterModules(txtSearch.Text);

                            for (int i = 0; i < checkedListBox1.Items.Count; i++)

                            {
                                if (checkedListBox1.Items[i].ToString() == txtSearch.Text)
                                {
                                    checkedListBox1.SetItemChecked(i, true);//Dynamically checking the items
                                }
                            }

                            foreach (Module item in newModuleList)
                            {
                                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                                {
                                    if (item.ModuleCode.ToString() == checkedListBox2.Items[i].ToString())
                                    {
                                        checkedListBox2.SetItemChecked(i, true);
                                    }
                                }
                            }*/

                            MessageBox.Show("Student Found");
                        }
                    }

                }
                else
                {
                    /*List<Module> newModuleList = new List<Module>();
                    newModuleList = dh.FilterModules(edtStudNum.Text);

                    for (int j = 0; j < checkedListBox2.Items.Count; j++)
                    {
                        checkedListBox2.SetItemChecked(j, false);
                    }

                    foreach (Module item in newModuleList)
                    {
                        for (int i = 0; i < checkedListBox2.Items.Count; i++)
                        {
                            if (item.ModuleCode.ToString() == checkedListBox2.Items[i].ToString())
                            {
                                checkedListBox2.SetItemChecked(i, true);
                            }
                        }
                    }*/
                    MessageBox.Show("Student does not exist");
                }//else
            }
            if ((mod = bs.Current as Module) != null)
            {
                bool mFound = false;
                foreach (Module module in modules)
                {
                    if (module.ModuleCode == txtSearch.Text)
                    {
                        int index = bs.IndexOf(module); // searches the for the stud in the source if found will change the index to the index of the stud thus invoking the update information invoked by the DGV itself
                        bs.Position = index;
                        mFound = true;
                    }
                }
                if (mFound)
                {
                    MessageBox.Show("Module Found");
                }
                else MessageBox.Show("Module doesn't exist");
            }
        }

        public void DisplayStudents()
        {
            
            s = dh.getStudent();
           
            bs.DataSource = null;
            bs.DataSource = s;
            dgvDisplay.DataSource = bs;
            dgvDisplay.Columns["ImageData"].Visible = false;

           

            int i = 0;
            foreach (var item in s)
            {
                if (int.Parse(item.StudNumber)>i)
                {
                    i = int.Parse(item.StudNumber);
                }
            }
            i++;
            txtStudentNum.Text = i.ToString();

        }


        public void DisplayModules()
        {
            modules = dh.ReadModules();
            bs.DataSource = null;
            bs.DataSource = modules;
            dgvDisplay.DataSource = bs;

            


        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Student Number")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Student Number";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMCode_Insert.Clear();
            txtMDescr_Inser.Clear();
            txtMLink_Inser.Clear();
            txtMName_Insert.Clear();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplay_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })

            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    filename = odf.FileName;
                    lblUpdatePath.Text = filename;
                    PreviewPic.Image = Image.FromFile(filename);

                    string name = Path.GetFileName(filename);
                    string[] name1 = name.Split('.');
                    picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            btnEditModule.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertModule.BackColor = Color.FromArgb(119, 33, 64);
            btnEditStudent.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertStudent.BackColor = Color.FromArgb(172, 46, 88);



        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            btnEditModule.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertModule.BackColor = Color.FromArgb(119, 33, 64);
            btnEditStudent.BackColor = Color.FromArgb(172, 46, 88); 
            btnInsertStudent.BackColor = Color.FromArgb(119, 33, 64);
        }

        private void btnInsertModule_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            btnEditModule.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertModule.BackColor = Color.FromArgb(172, 46, 88);
            btnEditStudent.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertStudent.BackColor = Color.FromArgb(119, 33, 64);
        }

        private void btnEditModule_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            btnEditModule.BackColor = Color.FromArgb(172, 46, 88);
            btnInsertModule.BackColor = Color.FromArgb(119, 33, 64);
            btnEditStudent.BackColor = Color.FromArgb(119, 33, 64);
            btnInsertStudent.BackColor = Color.FromArgb(119, 33, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtMCode_Insert.Text == "" || txtMName_Insert.Text == "" || txtMDescr_Inser.Text == "")
            //    {
            //        throw new Exception("Please ensure both password and username are entered");
            //    }
            //    if (txtMCode_Insert.Text.Any(Char.IsWhiteSpace))
            //    {
            //        throw new Exception("There cannot be any spaces");
            //    }
            //    if (txtMCode_Insert.Text.Any(Char.IsPunctuation))
            //    {
            //        throw new Exception("Module code can only contain numbers and letters!");
            //    }
            //}
            //catch (Exception exep)
            //{
            //    return exep.Message;
            //}

            MessageBox.Show(dh.addNewModules(txtMCode_Insert.Text, txtMName_Insert.Text, txtMDescr_Inser.Text, txtMLink_Inser.Text));
            DisplayModules();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Are you sure you want to delete Module: {0} from the database?", txtMCode_UD.Text), "WARNING", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(dh.DeleteModule(txtMCode_UD.Text));
                DisplayModules();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
