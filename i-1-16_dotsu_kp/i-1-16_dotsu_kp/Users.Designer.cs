namespace i_1_16_dotsu_kp
{
    partial class Users
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
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.lblDolj = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbOtchestvo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblOtchestvo = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.gpManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(200, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(600, 43);
            this.gbSearchFiltration.TabIndex = 15;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(491, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(106, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(488, 20);
            this.tbSearchFlitration.TabIndex = 0;
            this.tbSearchFlitration.Text = "Введите данные поезда...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(528, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(72, 35);
            this.btnErrors.TabIndex = 12;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(200, 289);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(600, 35);
            this.pnCancel.TabIndex = 16;
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(200, 0);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(600, 324);
            this.dgvTickets.TabIndex = 18;
            // 
            // gpManipulation
            // 
            this.gpManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.cbDolj);
            this.gpManipulation.Controls.Add(this.lblDolj);
            this.gpManipulation.Controls.Add(this.tbConfirmPassword);
            this.gpManipulation.Controls.Add(this.lblConfirmPassword);
            this.gpManipulation.Controls.Add(this.tbPassword);
            this.gpManipulation.Controls.Add(this.lblPassword);
            this.gpManipulation.Controls.Add(this.tbLogin);
            this.gpManipulation.Controls.Add(this.lblLogin);
            this.gpManipulation.Controls.Add(this.tbOtchestvo);
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.lblOtchestvo);
            this.gpManipulation.Controls.Add(this.tbFirstName);
            this.gpManipulation.Controls.Add(this.lblFirstName);
            this.gpManipulation.Controls.Add(this.tbSecondName);
            this.gpManipulation.Controls.Add(this.lblSecondName);
            this.gpManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpManipulation.Location = new System.Drawing.Point(0, 0);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.Size = new System.Drawing.Size(200, 324);
            this.gpManipulation.TabIndex = 17;
            this.gpManipulation.TabStop = false;
            this.gpManipulation.Text = "Манипулирование данными";
            // 
            // cbDolj
            // 
            this.cbDolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(3, 227);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(194, 21);
            this.cbDolj.TabIndex = 26;
            // 
            // lblDolj
            // 
            this.lblDolj.AutoSize = true;
            this.lblDolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDolj.Location = new System.Drawing.Point(3, 214);
            this.lblDolj.Name = "lblDolj";
            this.lblDolj.Size = new System.Drawing.Size(65, 13);
            this.lblDolj.TabIndex = 25;
            this.lblDolj.Text = "Должность";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfirmPassword.Location = new System.Drawing.Point(3, 194);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(194, 20);
            this.tbConfirmPassword.TabIndex = 18;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 181);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Повторте пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(3, 161);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(194, 20);
            this.tbPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(3, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(3, 128);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(194, 20);
            this.tbLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(3, 115);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Логин";
            // 
            // tbOtchestvo
            // 
            this.tbOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOtchestvo.Location = new System.Drawing.Point(3, 95);
            this.tbOtchestvo.Name = "tbOtchestvo";
            this.tbOtchestvo.Size = new System.Drawing.Size(194, 20);
            this.tbOtchestvo.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(3, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить билет";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblOtchestvo
            // 
            this.lblOtchestvo.AutoSize = true;
            this.lblOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOtchestvo.Location = new System.Drawing.Point(3, 82);
            this.lblOtchestvo.Name = "lblOtchestvo";
            this.lblOtchestvo.Size = new System.Drawing.Size(128, 13);
            this.lblOtchestvo.TabIndex = 5;
            this.lblOtchestvo.Text = "Отчество пользователя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstName.Location = new System.Drawing.Point(3, 62);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(194, 20);
            this.tbFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Location = new System.Drawing.Point(3, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Имя пользователя";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSecondName.Location = new System.Drawing.Point(3, 29);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(194, 20);
            this.tbSecondName.TabIndex = 2;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecondName.Location = new System.Drawing.Point(3, 16);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(130, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Фамилия пользователя";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(3, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.Location = new System.Drawing.Point(3, 252);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(194, 23);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Добавить билет";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.gpManipulation);
            this.Name = "Users";
            this.Text = "Users";
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.gpManipulation.ResumeLayout(false);
            this.gpManipulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.GroupBox gpManipulation;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.Label lblDolj;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbOtchestvo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblOtchestvo;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
    }
}