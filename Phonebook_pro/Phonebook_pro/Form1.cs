using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnReg_Click(object sender, EventArgs e)
        {
            Reg_frm registerFrm = new Reg_frm();
            registerFrm.MdiParent = this;
            registerFrm.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnCalc_Click(object sender, EventArgs e)
        {
            Search_frm searchFrm = new Search_frm();
            searchFrm.MdiParent = this;
            searchFrm.Show();
        }

        private void tsbtnAbout_Click(object sender, EventArgs e)
        {
            AboutUs_frm aboutFrm = new AboutUs_frm();
            aboutFrm.MdiParent = this;
            aboutFrm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            process1.Start();
        }
<<<<<<< HEAD

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.F2)
            {
                tsbtnReg_Click(sender, e);

            }else if (e.KeyCode == Keys.F3){
                tsbtnCalc_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                toolStripButton4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                tsbtnAbout_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                tsbtnExit_Click(sender, e);
            }

        }
=======
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
    }
}
