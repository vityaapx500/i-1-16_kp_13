namespace i_1_16_dotsu_kp
{
    partial class Employees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblOtchestvo = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.lblDolj = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbDateOkonch = new System.Windows.Forms.TextBox();
            this.lblDateOkonch = new System.Windows.Forms.Label();
            this.tbNumUdostov = new System.Windows.Forms.TextBox();
            this.lblNumUdostov = new System.Windows.Forms.Label();
            this.tbNameUchilisha = new System.Windows.Forms.TextBox();
            this.lblNameUchilisha = new System.Windows.Forms.Label();
            this.tbDateBirth = new System.Windows.Forms.TextBox();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.tbOtchestvo = new System.Windows.Forms.TextBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gpManipulation.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbSearchFiltration.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(200, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(601, 478);
            this.dgvEmployees.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(729, 0);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить сотрудника";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(0, 363);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(194, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Добавить сотрудника";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // lblOtchestvo
            // 
            this.lblOtchestvo.AutoSize = true;
            this.lblOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOtchestvo.Location = new System.Drawing.Point(3, 82);
            this.lblOtchestvo.Name = "lblOtchestvo";
            this.lblOtchestvo.Size = new System.Drawing.Size(115, 13);
            this.lblOtchestvo.TabIndex = 5;
            this.lblOtchestvo.Text = "Отчество сотрудника";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(194, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя сотрудника";
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
            this.lblSecondName.Size = new System.Drawing.Size(117, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Фамилия сотрудника";
            // 
            // gpManipulation
            // 
            this.gpManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpManipulation.Controls.Add(this.cbDolj);
            this.gpManipulation.Controls.Add(this.lblDolj);
            this.gpManipulation.Controls.Add(this.tbPassword);
            this.gpManipulation.Controls.Add(this.lblPassword);
            this.gpManipulation.Controls.Add(this.tbLogin);
            this.gpManipulation.Controls.Add(this.lblLogin);
            this.gpManipulation.Controls.Add(this.tbDateOkonch);
            this.gpManipulation.Controls.Add(this.lblDateOkonch);
            this.gpManipulation.Controls.Add(this.tbNumUdostov);
            this.gpManipulation.Controls.Add(this.lblNumUdostov);
            this.gpManipulation.Controls.Add(this.tbNameUchilisha);
            this.gpManipulation.Controls.Add(this.lblNameUchilisha);
            this.gpManipulation.Controls.Add(this.tbDateBirth);
            this.gpManipulation.Controls.Add(this.lblDateBirth);
            this.gpManipulation.Controls.Add(this.tbOtchestvo);
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.lblOtchestvo);
            this.gpManipulation.Controls.Add(this.tbName);
            this.gpManipulation.Controls.Add(this.lblName);
            this.gpManipulation.Controls.Add(this.tbSecondName);
            this.gpManipulation.Controls.Add(this.lblSecondName);
            this.gpManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpManipulation.Location = new System.Drawing.Point(0, 0);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.Size = new System.Drawing.Size(200, 478);
            this.gpManipulation.TabIndex = 9;
            this.gpManipulation.TabStop = false;
            this.gpManipulation.Text = "Манипулирование данными";
            // 
            // cbDolj
            // 
            this.cbDolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(3, 326);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(194, 21);
            this.cbDolj.TabIndex = 26;
            // 
            // lblDolj
            // 
            this.lblDolj.AutoSize = true;
            this.lblDolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDolj.Location = new System.Drawing.Point(3, 313);
            this.lblDolj.Name = "lblDolj";
            this.lblDolj.Size = new System.Drawing.Size(65, 13);
            this.lblDolj.TabIndex = 25;
            this.lblDolj.Text = "Должность";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(3, 293);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(194, 20);
            this.tbPassword.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(3, 280);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(3, 260);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(194, 20);
            this.tbLogin.TabIndex = 22;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(3, 247);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Логин";
            // 
            // tbDateOkonch
            // 
            this.tbDateOkonch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateOkonch.Location = new System.Drawing.Point(3, 227);
            this.tbDateOkonch.Name = "tbDateOkonch";
            this.tbDateOkonch.Size = new System.Drawing.Size(194, 20);
            this.tbDateOkonch.TabIndex = 20;
            // 
            // lblDateOkonch
            // 
            this.lblDateOkonch.AutoSize = true;
            this.lblDateOkonch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDateOkonch.Location = new System.Drawing.Point(3, 214);
            this.lblDateOkonch.Name = "lblDateOkonch";
            this.lblDateOkonch.Size = new System.Drawing.Size(89, 13);
            this.lblDateOkonch.TabIndex = 19;
            this.lblDateOkonch.Text = "Дата окончания";
            // 
            // tbNumUdostov
            // 
            this.tbNumUdostov.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumUdostov.Location = new System.Drawing.Point(3, 194);
            this.tbNumUdostov.Name = "tbNumUdostov";
            this.tbNumUdostov.Size = new System.Drawing.Size(194, 20);
            this.tbNumUdostov.TabIndex = 18;
            // 
            // lblNumUdostov
            // 
            this.lblNumUdostov.AutoSize = true;
            this.lblNumUdostov.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumUdostov.Location = new System.Drawing.Point(3, 181);
            this.lblNumUdostov.Name = "lblNumUdostov";
            this.lblNumUdostov.Size = new System.Drawing.Size(120, 13);
            this.lblNumUdostov.TabIndex = 17;
            this.lblNumUdostov.Text = "Номер удостоверения";
            // 
            // tbNameUchilisha
            // 
            this.tbNameUchilisha.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameUchilisha.Location = new System.Drawing.Point(3, 161);
            this.tbNameUchilisha.Name = "tbNameUchilisha";
            this.tbNameUchilisha.Size = new System.Drawing.Size(194, 20);
            this.tbNameUchilisha.TabIndex = 16;
            // 
            // lblNameUchilisha
            // 
            this.lblNameUchilisha.AutoSize = true;
            this.lblNameUchilisha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameUchilisha.Location = new System.Drawing.Point(3, 148);
            this.lblNameUchilisha.Name = "lblNameUchilisha";
            this.lblNameUchilisha.Size = new System.Drawing.Size(115, 13);
            this.lblNameUchilisha.TabIndex = 15;
            this.lblNameUchilisha.Text = "Название уличилища";
            // 
            // tbDateBirth
            // 
            this.tbDateBirth.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateBirth.Location = new System.Drawing.Point(3, 128);
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.Size = new System.Drawing.Size(194, 20);
            this.tbDateBirth.TabIndex = 14;
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDateBirth.Location = new System.Drawing.Point(3, 115);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(86, 13);
            this.lblDateBirth.TabIndex = 13;
            this.lblDateBirth.Text = "Дата рождения";
            // 
            // tbOtchestvo
            // 
            this.tbOtchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOtchestvo.Location = new System.Drawing.Point(3, 95);
            this.tbOtchestvo.Name = "tbOtchestvo";
            this.tbOtchestvo.Size = new System.Drawing.Size(194, 20);
            this.tbOtchestvo.TabIndex = 12;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 478);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(801, 35);
            this.pnCancel.TabIndex = 8;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(200, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(601, 43);
            this.gbSearchFiltration.TabIndex = 11;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(490, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(108, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(487, 20);
            this.tbSearchFlitration.TabIndex = 0;
            this.tbSearchFlitration.Text = "Введите данные поезда...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.gpManipulation);
            this.Controls.Add(this.pnCancel);
            this.Name = "Employees";
            this.Text = "Справочник Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gpManipulation.ResumeLayout(false);
            this.gpManipulation.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblOtchestvo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.GroupBox gpManipulation;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.Label lblDolj;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbDateOkonch;
        private System.Windows.Forms.Label lblDateOkonch;
        private System.Windows.Forms.TextBox tbNumUdostov;
        private System.Windows.Forms.Label lblNumUdostov;
        private System.Windows.Forms.TextBox tbNameUchilisha;
        private System.Windows.Forms.Label lblNameUchilisha;
        private System.Windows.Forms.TextBox tbDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.TextBox tbOtchestvo;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
    }
}