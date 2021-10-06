using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Milestone2_PRG282.BusinessLayer;

namespace Project_Milestone2_PRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to exit?" , "Exit" , MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                this.Close();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection MyCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|StudentsDB.mdf;Integrated Security=True");
            MyCon.Open();

            MyCon.Close();
        }

        private void btnSign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm Main = new MainForm();


            FileMethods fm = new FileMethods();

            List<User> users;

            users = fm.Read();

            foreach (var item in users)
            {
                MessageBox.Show(string.Format("Username: {0}\nPassword: {1}",item.Name,item.Password));
            }

           // Main.ShowDialog();
           // this.Dispose();
        }
    }
}
