using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKP_ver1
{
    partial class SignUpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpView));
            this.Register = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RepeatPassTxt = new System.Windows.Forms.TextBox();
            this.OnSignUpButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LastName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Iam = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register
            // 
            resources.ApplyResources(this.Register, "Register");
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Name = "Register";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.UsernameBox, "UsernameBox");
            this.UsernameBox.ForeColor = System.Drawing.Color.White;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Tag = "";
            this.UsernameBox.Enter += new System.EventHandler(this.UsernameBox_Enter);
            this.UsernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameBox_KeyPress);
            this.UsernameBox.Leave += new System.EventHandler(this.UsernameBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LoginTxt
            // 
            this.LoginTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.LoginTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.LoginTxt, "LoginTxt");
            this.LoginTxt.ForeColor = System.Drawing.Color.White;
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Tag = "";
            this.LoginTxt.Enter += new System.EventHandler(this.LoginTxt_Enter);
            this.LoginTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTxt_KeyPress);
            this.LoginTxt.Leave += new System.EventHandler(this.LoginTxt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // PassTxt
            // 
            this.PassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.PassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.PassTxt, "PassTxt");
            this.PassTxt.ForeColor = System.Drawing.Color.White;
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Tag = "";
            this.PassTxt.Enter += new System.EventHandler(this.PassTxt_Enter);
            this.PassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxt_KeyPress);
            this.PassTxt.Leave += new System.EventHandler(this.PassTxt_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // RepeatPassTxt
            // 
            this.RepeatPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.RepeatPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepeatPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.RepeatPassTxt, "RepeatPassTxt");
            this.RepeatPassTxt.ForeColor = System.Drawing.Color.White;
            this.RepeatPassTxt.Name = "RepeatPassTxt";
            this.RepeatPassTxt.Tag = "";
            this.RepeatPassTxt.Enter += new System.EventHandler(this.RepeatPassTxt_Enter);
            this.RepeatPassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatPassTxt_KeyPress);
            this.RepeatPassTxt.Leave += new System.EventHandler(this.RepeatPassTxt_Leave);
            // 
            // OnSignUpButton
            // 
            this.OnSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(244)))));
            this.OnSignUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OnSignUpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.OnSignUpButton.FlatAppearance.BorderSize = 0;
            this.OnSignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.OnSignUpButton, "OnSignUpButton");
            this.OnSignUpButton.ForeColor = System.Drawing.Color.White;
            this.OnSignUpButton.Name = "OnSignUpButton";
            this.OnSignUpButton.UseVisualStyleBackColor = false;
            this.OnSignUpButton.Click += new System.EventHandler(this.OnSignUpButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.ReturnButton, "ReturnButton");
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Name = "LastName";
            this.LastName.Tag = "";
            this.LastName.Enter += new System.EventHandler(this.LastName_Enter);
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // Iam
            // 
            resources.ApplyResources(this.Iam, "Iam");
            this.Iam.ForeColor = System.Drawing.Color.White;
            this.Iam.Name = "Iam";
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::MKP_ver1.Properties.Resources.ExitButton;
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // SignUpView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Iam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.OnSignUpButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.RepeatPassTxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpView";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox RepeatPassTxt;
        private System.Windows.Forms.Button OnSignUpButton;
        private System.Windows.Forms.Button ReturnButton;
        private Panel panel4;
        private TextBox LastName;
        private ComboBox comboBox1;
        private Label Iam;
        private PictureBox CloseButton;
    }
}