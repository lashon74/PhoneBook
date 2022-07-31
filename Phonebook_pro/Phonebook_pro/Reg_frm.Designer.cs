namespace Phonebook_pro
{
    partial class Reg_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_frm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRegNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRegSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbhousePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcellPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRegNew,
            this.toolStripSeparator1,
            this.tsbtnRegSave,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRegNew
            // 
            this.tsbtnRegNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRegNew.Image")));
            this.tsbtnRegNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRegNew.Name = "tsbtnRegNew";
            this.tsbtnRegNew.Size = new System.Drawing.Size(99, 50);
            this.tsbtnRegNew.Text = "New Data";
            this.tsbtnRegNew.Click += new System.EventHandler(this.tsbtnRegNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // tsbtnRegSave
            // 
            this.tsbtnRegSave.Enabled = false;
            this.tsbtnRegSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRegSave.Image")));
            this.tsbtnRegSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRegSave.Name = "tsbtnRegSave";
            this.tsbtnRegSave.Size = new System.Drawing.Size(124, 50);
            this.tsbtnRegSave.Text = "Save Changes";
            this.tsbtnRegSave.Click += new System.EventHandler(this.tsbtnRegSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbComment);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.tbhousePhone);
            this.gbInfo.Controls.Add(this.tbEmail);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.tbAddress);
            this.gbInfo.Controls.Add(this.tbfirstName);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.tblastName);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.tbcellPhone);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.tbID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Enabled = false;
            this.gbInfo.Location = new System.Drawing.Point(10, 69);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(534, 406);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(145, 35);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(240, 22);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // tbfirstName
            // 
            this.tbfirstName.Location = new System.Drawing.Point(145, 63);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(240, 22);
            this.tbfirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(145, 94);
            this.tblastName.Name = "tblastName";
            this.tblastName.Size = new System.Drawing.Size(240, 22);
            this.tblastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "House Phone:";
            // 
            // tbhousePhone
            // 
            this.tbhousePhone.Location = new System.Drawing.Point(145, 122);
            this.tbhousePhone.Name = "tbhousePhone";
            this.tbhousePhone.Size = new System.Drawing.Size(240, 22);
            this.tbhousePhone.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cell Phone:";
            // 
            // tbcellPhone
            // 
            this.tbcellPhone.Location = new System.Drawing.Point(145, 150);
            this.tbcellPhone.Name = "tbcellPhone";
            this.tbcellPhone.Size = new System.Drawing.Size(240, 22);
            this.tbcellPhone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(145, 209);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(240, 22);
            this.tbAddress.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(145, 178);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(240, 22);
            this.tbEmail.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Comment:";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(145, 237);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(240, 22);
            this.tbComment.TabIndex = 1;
            // 
            // Reg_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(556, 485);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "Reg_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.Reg_frm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRegNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnRegSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbhousePhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbfirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tblastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcellPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}