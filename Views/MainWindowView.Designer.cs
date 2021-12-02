namespace MKP_ver1
{
    partial class MainWindowView
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
            this.createOrderButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.imageOnTop = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnTop)).BeginInit();
            this.SuspendLayout();
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackgroundImage = global::MKP_ver1.Properties.Resources.TopGradien;
            this.createOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createOrderButton.Font = new System.Drawing.Font("Cera Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.ForeColor = System.Drawing.Color.White;
            this.createOrderButton.Location = new System.Drawing.Point(970, 73);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(192, 40);
            this.createOrderButton.TabIndex = 25;
            this.createOrderButton.Text = "Создать Заказ";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::MKP_ver1.Properties.Resources.ExitButton;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(1163, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 24;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // imageOnTop
            // 
            this.imageOnTop.Image = global::MKP_ver1.Properties.Resources.TopGradien;
            this.imageOnTop.Location = new System.Drawing.Point(0, 0);
            this.imageOnTop.Name = "imageOnTop";
            this.imageOnTop.Size = new System.Drawing.Size(1200, 50);
            this.imageOnTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOnTop.TabIndex = 0;
            this.imageOnTop.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(108)))));
            this.backButton.BackgroundImage = global::MKP_ver1.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.backButton.Location = new System.Drawing.Point(1124, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(26, 25);
            this.backButton.TabIndex = 27;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.imageOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOnTop;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Panel backButton;
    }
}