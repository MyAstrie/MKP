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
            this.registerTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.repeatPassBox = new System.Windows.Forms.TextBox();
            this.onSignUpButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.whoUserContext = new System.Windows.Forms.ComboBox();
            this.iAmTxt = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerTxt
            // 
            resources.ApplyResources(this.registerTxt, "registerTxt");
            this.registerTxt.ForeColor = System.Drawing.Color.White;
            this.registerTxt.Name = "registerTxt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Name = "nameBox";
            this.nameBox.Tag = "";
            this.nameBox.Enter += new System.EventHandler(this.UsernameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.UsernameBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.loginBox, "loginBox");
            this.loginBox.ForeColor = System.Drawing.Color.White;
            this.loginBox.Name = "loginBox";
            this.loginBox.Tag = "";
            this.loginBox.Enter += new System.EventHandler(this.LoginTxt_Enter);
            this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTxt_KeyPress);
            this.loginBox.Leave += new System.EventHandler(this.LoginTxt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.passBox, "passBox");
            this.passBox.ForeColor = System.Drawing.Color.White;
            this.passBox.Name = "passBox";
            this.passBox.Tag = "";
            this.passBox.Enter += new System.EventHandler(this.PassTxt_Enter);
            this.passBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxt_KeyPress);
            this.passBox.Leave += new System.EventHandler(this.PassTxt_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // repeatPassBox
            // 
            this.repeatPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.repeatPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.repeatPassBox, "repeatPassBox");
            this.repeatPassBox.ForeColor = System.Drawing.Color.White;
            this.repeatPassBox.Name = "repeatPassBox";
            this.repeatPassBox.Tag = "";
            this.repeatPassBox.Enter += new System.EventHandler(this.RepeatPassTxt_Enter);
            this.repeatPassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatPassTxt_KeyPress);
            this.repeatPassBox.Leave += new System.EventHandler(this.RepeatPassTxt_Leave);
            // 
            // onSignUpButton
            // 
            this.onSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(244)))));
            this.onSignUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.onSignUpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.onSignUpButton.FlatAppearance.BorderSize = 0;
            this.onSignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.onSignUpButton, "onSignUpButton");
            this.onSignUpButton.ForeColor = System.Drawing.Color.White;
            this.onSignUpButton.Name = "onSignUpButton";
            this.onSignUpButton.UseVisualStyleBackColor = false;
            this.onSignUpButton.Click += new System.EventHandler(this.OnSignUpButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Name = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.lastNameBox, "lastNameBox");
            this.lastNameBox.ForeColor = System.Drawing.Color.White;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Tag = "";
            this.lastNameBox.Enter += new System.EventHandler(this.LastName_Enter);
            this.lastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            this.lastNameBox.Leave += new System.EventHandler(this.LastName_Leave);
            // 
            // whoUserContext
            // 
            this.whoUserContext.FormattingEnabled = true;
            this.whoUserContext.Items.AddRange(new object[] {
            resources.GetString("whoUserContext.Items"),
            resources.GetString("whoUserContext.Items1")});
            resources.ApplyResources(this.whoUserContext, "whoUserContext");
            this.whoUserContext.Name = "whoUserContext";
            // 
            // iAmTxt
            // 
            resources.ApplyResources(this.iAmTxt, "iAmTxt");
            this.iAmTxt.ForeColor = System.Drawing.Color.White;
            this.iAmTxt.Name = "iAmTxt";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::MKP_ver1.Properties.Resources.ExitButton;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.iAmTxt);
            this.Controls.Add(this.whoUserContext);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.onSignUpButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.repeatPassBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.registerTxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpView";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registerTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox repeatPassBox;
        private System.Windows.Forms.Button onSignUpButton;
        private System.Windows.Forms.Button returnButton;
        private Panel panel4;
        private TextBox lastNameBox;
        private ComboBox whoUserContext;
        private Label iAmTxt;
        private PictureBox closeButton;
    }
}