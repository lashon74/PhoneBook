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
    public partial class Reg_frm : Form
    {
        public Reg_frm()
        {
            InitializeComponent();
        }

        private void tsbtnRegNew_Click(object sender, EventArgs e)
        {
            tsbtnRegNew.Enabled = false;
            tsbtnRegSave.Enabled = true;
            gbInfo.Enabled = true;
            //Reset text box for nw entry
            tbID.ResetText();
            tbfirstName.ResetText();
            tblastName.ResetText();
            tbhousePhone.ResetText();
            tbcellPhone.ResetText();
            tbEmail.ResetText();
            tbAddress.ResetText();
            tbComment.ResetText();

        }

        private void tsbtnRegSave_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }

            tsbtnRegNew.Enabled = true;
            tsbtnRegSave.Enabled = false;
            gbInfo.Enabled = false;
            //string[] contents = new string[7];
            //contents[0] = "First name: " + tbfirstName.Text;
            //contents[1] = "Last name: " + tblastName.Text;
            //contents[2] = "House phone: " + tbhousePhone.Text;
            //contents[3] = "Cell phone: " + tbcellPhone.Text;
            //contents[4] = "Email: " + tbEmail.Text;
            //contents[5] = "Address: " + tbAddress.Text; 
            //contents[6] = "Comments: " + tbComment.Text;

            
            var fileName = "C:\\Users\\lasho\\source\\repos\\C#_.Net\\Phonebook_pro\\info\\";
<<<<<<< HEAD
            string pass;
            pass = fileName + tbID.Text + "_firstName.txt";
=======
            string pass = fileName + tbID.Text + tbfirstName + ".txt";
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            //File.WriteAllLines(pass, contents, Encoding.UTF8);
            File.WriteAllText(pass, tbfirstName.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_lastName.txt";
            File.WriteAllText(pass, tblastName.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_housePhone.txt";
            File.WriteAllText(pass, tbhousePhone.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_Cell.txt";
            File.WriteAllText(pass, tbcellPhone.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_Email.txt";
            File.WriteAllText(pass, tbEmail.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_Address.txt";
            File.WriteAllText(pass, tbAddress.Text, Encoding.UTF8);

            pass = fileName + tbID.Text + "_Comment.txt";
            File.WriteAllText(pass, tbComment.Text, Encoding.UTF8);

            MessageBox.Show("Saved");

        }

        private void Reg_frm_Load(object sender, EventArgs e)
        {
            gbInfo.Enabled = false;
        }
    }
}
