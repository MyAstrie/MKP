using System;

namespace MKP_ver1
{
    partial class OrderWindowView
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.createOrderTxt = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.deviceBox = new System.Windows.Forms.TextBox();
            this.countryOfOriginBox = new System.Windows.Forms.TextBox();
            this.remontTypeLabel = new System.Windows.Forms.Label();
            this.deviceTypeContext = new System.Windows.Forms.ComboBox();
            this.timesInRepairBox = new System.Windows.Forms.TextBox();
            this.daysInOperationBox = new System.Windows.Forms.TextBox();
            this.endDateTxt = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTxt = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.deviceTypeBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.createYearDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(48, 91);
            this.nameBox.MaxLength = 15;
            this.nameBox.Name = "nameBox";
            this.nameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameBox.Size = new System.Drawing.Size(414, 23);
            this.nameBox.TabIndex = 26;
            this.nameBox.Tag = "";
            this.nameBox.Text = "Имя";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // createOrderTxt
            // 
            this.createOrderTxt.AccessibleName = "";
            this.createOrderTxt.AutoSize = true;
            this.createOrderTxt.Font = new System.Drawing.Font("Cera Pro", 19.8F, System.Drawing.FontStyle.Bold);
            this.createOrderTxt.ForeColor = System.Drawing.Color.White;
            this.createOrderTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createOrderTxt.Location = new System.Drawing.Point(41, 19);
            this.createOrderTxt.Name = "createOrderTxt";
            this.createOrderTxt.Size = new System.Drawing.Size(290, 41);
            this.createOrderTxt.TabIndex = 27;
            this.createOrderTxt.Text = "Создание заказа";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.lastNameBox.ForeColor = System.Drawing.Color.White;
            this.lastNameBox.Location = new System.Drawing.Point(48, 146);
            this.lastNameBox.MaxLength = 15;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastNameBox.Size = new System.Drawing.Size(414, 23);
            this.lastNameBox.TabIndex = 28;
            this.lastNameBox.Tag = "";
            this.lastNameBox.Text = "Фамилия";
            this.lastNameBox.Enter += new System.EventHandler(this.lastNameBox_Enter);
            this.lastNameBox.Leave += new System.EventHandler(this.lastNameBox_Leave);
            // 
            // companyBox
            // 
            this.companyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.companyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.companyBox.ForeColor = System.Drawing.Color.White;
            this.companyBox.Location = new System.Drawing.Point(48, 206);
            this.companyBox.MaxLength = 15;
            this.companyBox.Name = "companyBox";
            this.companyBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.companyBox.Size = new System.Drawing.Size(414, 23);
            this.companyBox.TabIndex = 29;
            this.companyBox.Tag = "";
            this.companyBox.Text = "Компания";
            this.companyBox.Enter += new System.EventHandler(this.companyBox_Enter);
            this.companyBox.Leave += new System.EventHandler(this.companyBox_Leave);
            // 
            // deviceBox
            // 
            this.deviceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.deviceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deviceBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.deviceBox.ForeColor = System.Drawing.Color.White;
            this.deviceBox.Location = new System.Drawing.Point(48, 265);
            this.deviceBox.MaxLength = 15;
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deviceBox.Size = new System.Drawing.Size(414, 23);
            this.deviceBox.TabIndex = 30;
            this.deviceBox.Tag = "";
            this.deviceBox.Text = "Оборудование";
            this.deviceBox.Enter += new System.EventHandler(this.deviceBox_Enter);
            this.deviceBox.Leave += new System.EventHandler(this.deviceBox_Leave);
            // 
            // countryOfOriginBox
            // 
            this.countryOfOriginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.countryOfOriginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryOfOriginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countryOfOriginBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.countryOfOriginBox.ForeColor = System.Drawing.Color.White;
            this.countryOfOriginBox.Location = new System.Drawing.Point(48, 444);
            this.countryOfOriginBox.MaxLength = 15;
            this.countryOfOriginBox.Name = "countryOfOriginBox";
            this.countryOfOriginBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countryOfOriginBox.Size = new System.Drawing.Size(414, 23);
            this.countryOfOriginBox.TabIndex = 33;
            this.countryOfOriginBox.Tag = "";
            this.countryOfOriginBox.Text = "Страна производитель";
            this.countryOfOriginBox.Enter += new System.EventHandler(this.countryOfOriginBox_Enter);
            this.countryOfOriginBox.Leave += new System.EventHandler(this.countryOfOriginBox_Leave);
            // 
            // remontTypeLabel
            // 
            this.remontTypeLabel.AccessibleName = "";
            this.remontTypeLabel.AutoSize = true;
            this.remontTypeLabel.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.remontTypeLabel.ForeColor = System.Drawing.Color.White;
            this.remontTypeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.remontTypeLabel.Location = new System.Drawing.Point(688, 91);
            this.remontTypeLabel.Name = "remontTypeLabel";
            this.remontTypeLabel.Size = new System.Drawing.Size(163, 29);
            this.remontTypeLabel.TabIndex = 35;
            this.remontTypeLabel.Text = "Вид ремонта:";
            // 
            // deviceTypeContext
            // 
            this.deviceTypeContext.FormattingEnabled = true;
            this.deviceTypeContext.Items.AddRange(new object[] {
            "Малый",
            "Средний",
            "Капитальный"});
            this.deviceTypeContext.Location = new System.Drawing.Point(914, 96);
            this.deviceTypeContext.Name = "deviceTypeContext";
            this.deviceTypeContext.Size = new System.Drawing.Size(223, 24);
            this.deviceTypeContext.TabIndex = 34;
            this.deviceTypeContext.TextChanged += new System.EventHandler(this.deviceTypeContext_TextChanged);
            // 
            // timesInRepairBox
            // 
            this.timesInRepairBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.timesInRepairBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timesInRepairBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timesInRepairBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.timesInRepairBox.ForeColor = System.Drawing.Color.White;
            this.timesInRepairBox.Location = new System.Drawing.Point(693, 146);
            this.timesInRepairBox.MaxLength = 15;
            this.timesInRepairBox.Name = "timesInRepairBox";
            this.timesInRepairBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timesInRepairBox.Size = new System.Drawing.Size(444, 23);
            this.timesInRepairBox.TabIndex = 36;
            this.timesInRepairBox.Tag = "";
            this.timesInRepairBox.Text = "Кол-во раз в ремонте";
            this.timesInRepairBox.Enter += new System.EventHandler(this.timesInRepairBox_Enter);
            this.timesInRepairBox.Leave += new System.EventHandler(this.timesInRepairBox_Leave);
            // 
            // daysInOperationBox
            // 
            this.daysInOperationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.daysInOperationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daysInOperationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daysInOperationBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.daysInOperationBox.ForeColor = System.Drawing.Color.White;
            this.daysInOperationBox.Location = new System.Drawing.Point(693, 265);
            this.daysInOperationBox.MaxLength = 15;
            this.daysInOperationBox.Name = "daysInOperationBox";
            this.daysInOperationBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.daysInOperationBox.Size = new System.Drawing.Size(444, 23);
            this.daysInOperationBox.TabIndex = 38;
            this.daysInOperationBox.Tag = "";
            this.daysInOperationBox.Text = "Дней в работе";
            this.daysInOperationBox.TextChanged += new System.EventHandler(this.daysInOperationBox_TextChanged);
            this.daysInOperationBox.Enter += new System.EventHandler(this.daysInOperationBox_Enter);
            this.daysInOperationBox.Leave += new System.EventHandler(this.daysInOperationBox_Leave);
            // 
            // endDateTxt
            // 
            this.endDateTxt.AccessibleName = "";
            this.endDateTxt.AutoSize = true;
            this.endDateTxt.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.endDateTxt.ForeColor = System.Drawing.Color.White;
            this.endDateTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.endDateTxt.Location = new System.Drawing.Point(688, 320);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.Size = new System.Drawing.Size(201, 29);
            this.endDateTxt.TabIndex = 39;
            this.endDateTxt.Text = "Дата окончания:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(914, 197);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(223, 22);
            this.startDatePicker.TabIndex = 41;
            this.startDatePicker.Value = new System.DateTime(2021, 12, 17, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AccessibleName = "";
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.endDateLabel.ForeColor = System.Drawing.Color.White;
            this.endDateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.endDateLabel.Location = new System.Drawing.Point(909, 320);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(43, 29);
            this.endDateLabel.TabIndex = 42;
            this.endDateLabel.Text = "Да";
            // 
            // startDateTxt
            // 
            this.startDateTxt.AccessibleName = "";
            this.startDateTxt.AutoSize = true;
            this.startDateTxt.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.startDateTxt.ForeColor = System.Drawing.Color.White;
            this.startDateTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startDateTxt.Location = new System.Drawing.Point(688, 192);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.Size = new System.Drawing.Size(152, 29);
            this.startDateTxt.TabIndex = 44;
            this.startDateTxt.Text = "Дата начала";
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(244)))));
            this.createOrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.createOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.createOrderButton.FlatAppearance.BorderSize = 0;
            this.createOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            this.createOrderButton.Font = new System.Drawing.Font("Cera Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.ForeColor = System.Drawing.Color.White;
            this.createOrderButton.Location = new System.Drawing.Point(693, 555);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createOrderButton.Size = new System.Drawing.Size(444, 55);
            this.createOrderButton.TabIndex = 45;
            this.createOrderButton.Text = "Создать заказ";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond;
            this.returnButton.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnButton.Location = new System.Drawing.Point(48, 555);
            this.returnButton.Name = "returnButton";
            this.returnButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.returnButton.Size = new System.Drawing.Size(444, 55);
            this.returnButton.TabIndex = 46;
            this.returnButton.Text = "Вернуться назад";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // deviceTypeBox
            // 
            this.deviceTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.deviceTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceTypeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deviceTypeBox.Font = new System.Drawing.Font("Cera Pro", 10.8F);
            this.deviceTypeBox.ForeColor = System.Drawing.Color.White;
            this.deviceTypeBox.Location = new System.Drawing.Point(48, 326);
            this.deviceTypeBox.MaxLength = 15;
            this.deviceTypeBox.Name = "deviceTypeBox";
            this.deviceTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deviceTypeBox.Size = new System.Drawing.Size(414, 23);
            this.deviceTypeBox.TabIndex = 31;
            this.deviceTypeBox.Tag = "";
            this.deviceTypeBox.Text = "Тип оборудования";
            this.deviceTypeBox.Enter += new System.EventHandler(this.deviceTypeBox_Enter);
            this.deviceTypeBox.Leave += new System.EventHandler(this.deviceTypeBox_Leave);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::MKP_ver1.Properties.Resources.ExitButton;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(1163, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 25;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createYearDatePicker
            // 
            this.createYearDatePicker.Location = new System.Drawing.Point(239, 391);
            this.createYearDatePicker.Name = "createYearDatePicker";
            this.createYearDatePicker.Size = new System.Drawing.Size(223, 22);
            this.createYearDatePicker.TabIndex = 47;
            this.createYearDatePicker.Value = new System.DateTime(2021, 12, 17, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(43, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Год выпуска:";
            // 
            // costTxt
            // 
            this.costTxt.AccessibleName = "";
            this.costTxt.AutoSize = true;
            this.costTxt.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.costTxt.ForeColor = System.Drawing.Color.White;
            this.costTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.costTxt.Location = new System.Drawing.Point(688, 384);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(141, 29);
            this.costTxt.TabIndex = 40;
            this.costTxt.Text = "Стоимость:";
            // 
            // costLabel
            // 
            this.costLabel.AccessibleName = "";
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Cera Pro", 13.8F, System.Drawing.FontStyle.Bold);
            this.costLabel.ForeColor = System.Drawing.Color.White;
            this.costLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.costLabel.Location = new System.Drawing.Point(909, 384);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(130, 29);
            this.costLabel.TabIndex = 43;
            this.costLabel.Text = "Я являюсь";
            // 
            // OrderWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createYearDatePicker);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.startDateTxt);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.costTxt);
            this.Controls.Add(this.endDateTxt);
            this.Controls.Add(this.daysInOperationBox);
            this.Controls.Add(this.timesInRepairBox);
            this.Controls.Add(this.remontTypeLabel);
            this.Controls.Add(this.deviceTypeContext);
            this.Controls.Add(this.countryOfOriginBox);
            this.Controls.Add(this.deviceTypeBox);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.createOrderTxt);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderWindow";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label createOrderTxt;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.TextBox deviceBox;
        private System.Windows.Forms.TextBox countryOfOriginBox;
        private System.Windows.Forms.Label remontTypeLabel;
        private System.Windows.Forms.ComboBox deviceTypeContext;
        private System.Windows.Forms.TextBox timesInRepairBox;
        private System.Windows.Forms.TextBox daysInOperationBox;
        private System.Windows.Forms.Label endDateTxt;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateTxt;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox deviceTypeBox;
        private System.Windows.Forms.DateTimePicker createYearDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costTxt;
        private System.Windows.Forms.Label costLabel;
    }
}