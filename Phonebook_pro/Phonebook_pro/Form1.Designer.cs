namespace Phonebook_pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnReg = new System.Windows.Forms.ToolStripButton();
<<<<<<< HEAD
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCalc = new System.Windows.Forms.ToolStripButton();
=======
            this.tsbtnCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.tsbtnAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.process1 = new System.Diagnostics.Process();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnReg,
<<<<<<< HEAD
            this.tsbtnSearch,
            this.tsbtnCalc,
=======
            this.tsbtnCalc,
            this.toolStripButton4,
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.tsbtnAbout,
            this.tsbtnExit,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnReg
            // 
            this.tsbtnReg.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReg.Image")));
            this.tsbtnReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReg.Name = "tsbtnReg";
<<<<<<< HEAD
            this.tsbtnReg.Size = new System.Drawing.Size(142, 49);
            this.tsbtnReg.Text = "Register Data F2";
            this.tsbtnReg.Click += new System.EventHandler(this.tsbtnReg_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(96, 49);
            this.tsbtnSearch.Text = "Search F3";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnCalc_Click);
            // 
=======
            this.tsbtnReg.Size = new System.Drawing.Size(123, 49);
            this.tsbtnReg.Text = "Register Data";
            this.tsbtnReg.Click += new System.EventHandler(this.tsbtnReg_Click);
            // 
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            // tsbtnCalc
            // 
            this.tsbtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCalc.Image")));
            this.tsbtnCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCalc.Name = "tsbtnCalc";
<<<<<<< HEAD
            this.tsbtnCalc.Size = new System.Drawing.Size(119, 49);
            this.tsbtnCalc.Text = "Calculator F4";
            this.tsbtnCalc.Click += new System.EventHandler(this.toolStripButton4_Click);
=======
            this.tsbtnCalc.Size = new System.Drawing.Size(77, 49);
            this.tsbtnCalc.Text = "Search";
            this.tsbtnCalc.Click += new System.EventHandler(this.tsbtnCalc_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(100, 49);
            this.toolStripButton4.Text = "Calculator";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            // 
            // tsbtnAbout
            // 
            this.tsbtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAbout.Image")));
            this.tsbtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAbout.Name = "tsbtnAbout";
<<<<<<< HEAD
            this.tsbtnAbout.Size = new System.Drawing.Size(113, 49);
            this.tsbtnAbout.Text = "About Us F5";
=======
            this.tsbtnAbout.Size = new System.Drawing.Size(94, 49);
            this.tsbtnAbout.Text = "About Us";
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.tsbtnAbout.Click += new System.EventHandler(this.tsbtnAbout_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
<<<<<<< HEAD
            this.tsbtnExit.Size = new System.Drawing.Size(96, 49);
            this.tsbtnExit.Text = "Exit (ESC)";
=======
            this.tsbtnExit.Size = new System.Drawing.Size(57, 49);
            this.tsbtnExit.Text = "Exit";
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
<<<<<<< HEAD
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
=======
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Text = "Phone Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
=======
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnReg;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnCalc;
=======
        private System.Windows.Forms.ToolStripButton tsbtnCalc;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
>>>>>>> a3e1c45772447e9caeb3feadd7e72dfeaa3ac0a3
        private System.Windows.Forms.ToolStripButton tsbtnAbout;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Diagnostics.Process process1;
    }
}

