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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dataPrinter = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.seaechButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.imageOnTop = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaechButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnTop)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AccessibleName = "";
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(244)))));
            this.userNameLabel.Font = new System.Drawing.Font("Cera Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(4, 4);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(227, 41);
            this.userNameLabel.TabIndex = 28;
            this.userNameLabel.Text = "Авторизация";
            // 
            // dataPrinter
            // 
            this.dataPrinter.AllowUserToAddRows = false;
            this.dataPrinter.AllowUserToDeleteRows = false;
            this.dataPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPrinter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPrinter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPrinter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataPrinter.ColumnHeadersHeight = 29;
            this.dataPrinter.GridColor = System.Drawing.Color.White;
            this.dataPrinter.Location = new System.Drawing.Point(33, 144);
            this.dataPrinter.MultiSelect = false;
            this.dataPrinter.Name = "dataPrinter";
            this.dataPrinter.ReadOnly = true;
            this.dataPrinter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPrinter.RowHeadersWidth = 51;
            this.dataPrinter.RowTemplate.Height = 24;
            this.dataPrinter.Size = new System.Drawing.Size(1129, 494);
            this.dataPrinter.TabIndex = 29;
            this.dataPrinter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrinter_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Font = new System.Drawing.Font("Cera Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(723, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(192, 40);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteButton_Click);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Font = new System.Drawing.Font("Cera Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.White;
            this.idBox.Location = new System.Drawing.Point(612, 83);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(85, 23);
            this.idBox.TabIndex = 31;
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(33, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 5);
            this.panel2.TabIndex = 33;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Cera Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(33, 73);
            this.searchBox.MaxLength = 15;
            this.searchBox.Name = "searchBox";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.Size = new System.Drawing.Size(204, 23);
            this.searchBox.TabIndex = 32;
            this.searchBox.Tag = "";
            this.searchBox.Text = "Поиск по имени";
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // seaechButton
            // 
            this.seaechButton.Image = global::MKP_ver1.Properties.Resources.Search;
            this.seaechButton.Location = new System.Drawing.Point(265, 73);
            this.seaechButton.Name = "seaechButton";
            this.seaechButton.Size = new System.Drawing.Size(40, 40);
            this.seaechButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seaechButton.TabIndex = 34;
            this.seaechButton.TabStop = false;
            this.seaechButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.backButton.Click += new System.EventHandler(this.OnBackButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackgroundImage = global::MKP_ver1.Properties.Resources.TopGradien;
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createButton.Font = new System.Drawing.Font("Cera Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(922, 73);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(240, 40);
            this.createButton.TabIndex = 25;
            this.createButton.Text = "Создать заказ";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.OnCreateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(108)))));
            this.closeButton.Image = global::MKP_ver1.Properties.Resources.ExitButton;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(1163, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 24;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.OnCloseButton_Click);
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
            // idLabel
            // 
            this.idLabel.AccessibleName = "";
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(398, 77);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(194, 29);
            this.idLabel.TabIndex = 35;
            this.idLabel.Text = "Id пользователя:";
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.seaechButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataPrinter);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.imageOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindowView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaechButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOnTop;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel backButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.DataGridView dataPrinter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox seaechButton;
        private System.Windows.Forms.Label idLabel;
    }
}