using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook_pro
{
    public partial class Search_frm : Form
    {
        public Search_frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }

<<<<<<< HEAD
            string fileName;
            fileName = "C:\\Users\\lasho\\source\\repos\\C#_.Net\\Phonebook_pro\\info\\";
            string pass;
            string result;

            pass = fileName + tbSearch.Text + "_firstName.txt";
            if (File.Exists(pass)==true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbfirstName.Text = result;

            }

            pass = fileName + tbSearch.Text + "_lastName.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tblastName.Text = result;

            }

            pass = fileName + tbSearch.Text + "_housePhone.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbhousePhone.Text = result;

            }

            pass = fileName + tbSearch.Text + "_Cell.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbcellPhone.Text = result;

            }

            pass = fileName + tbSearch.Text + "_Email.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbEmail.Text = result;

            }

            pass = fileName + tbSearch.Text + "_Address.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbAddress.Text = result;

            }

            pass = fileName + tbSearch.Text + "_Comment.txt";
            if (File.Exists(pass) == true)
            {
                result = File.ReadAllText(pass, Encoding.UTF8);
                tbComment.Text = result;

            }
            tbID.Text = tbSearch.Text;
=======
            var fileName = "C:\\Users\\lasho\\source\\repos\\C#_.Net\\Phonebook_pro\\info\\";
            string pass = fileName + tbSearch.Text + tbfirstName + ".txt";
            File.ReadAllText(fileName, Encoding.UTF8);
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
        }
    }
}
