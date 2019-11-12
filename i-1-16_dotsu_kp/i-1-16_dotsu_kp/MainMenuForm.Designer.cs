namespace i_1_16_dotsu_kp
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuthorization = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miExitProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.завершениеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miExitFromSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHandBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrain = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrainDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.miTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.miDolj = new System.Windows.Forms.ToolStripMenuItem();
            this.miPassenger = new System.Windows.Forms.ToolStripMenuItem();
            this.miRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.miPlaceStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.miTicketFill = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miRoutesList = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.miRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.lbsstDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbsstConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.какоетоИзменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.ssInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miHandBook,
            this.miTicketFill,
            this.miDocs,
            this.miAdmin});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAuthorization,
            this.miSettings,
            this.miExitProfile,
            this.завершениеРаботыToolStripMenuItem,
            this.miExitFromSystem});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(66, 20);
            this.miSystem.Text = "Система";
            // 
            // miAuthorization
            // 
            this.miAuthorization.Name = "miAuthorization";
            this.miAuthorization.Size = new System.Drawing.Size(212, 22);
            this.miAuthorization.Text = "Авторизация";
            this.miAuthorization.Click += new System.EventHandler(this.miAuthorization_Click);
            // 
            // miSettings
            // 
            this.miSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAppSettings});
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(212, 22);
            this.miSettings.Text = "Настройки";
            // 
            // miAppSettings
            // 
            this.miAppSettings.Name = "miAppSettings";
            this.miAppSettings.Size = new System.Drawing.Size(207, 22);
            this.miAppSettings.Text = "Настройки приложения";
            // 
            // miExitProfile
            // 
            this.miExitProfile.Name = "miExitProfile";
            this.miExitProfile.Size = new System.Drawing.Size(212, 22);
            this.miExitProfile.Text = "Выход из учётной записи";
            this.miExitProfile.Click += new System.EventHandler(this.miExitProfile_Click);
            // 
            // завершениеРаботыToolStripMenuItem
            // 
            this.завершениеРаботыToolStripMenuItem.Name = "завершениеРаботыToolStripMenuItem";
            this.завершениеРаботыToolStripMenuItem.Size = new System.Drawing.Size(209, 6);
            // 
            // miExitFromSystem
            // 
            this.miExitFromSystem.Name = "miExitFromSystem";
            this.miExitFromSystem.Size = new System.Drawing.Size(212, 22);
            this.miExitFromSystem.Text = "Завершение работы";
            this.miExitFromSystem.Click += new System.EventHandler(this.miExitSystem_Click);
            // 
            // miHandBook
            // 
            this.miHandBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployee,
            this.miTrain,
            this.miTrainDriver,
            this.miTicket,
            this.miDolj,
            this.miPassenger,
            this.miRoute,
            this.miPlaceStatus});
            this.miHandBook.Enabled = false;
            this.miHandBook.Name = "miHandBook";
            this.miHandBook.Size = new System.Drawing.Size(94, 20);
            this.miHandBook.Text = "Справочники";
            // 
            // miEmployee
            // 
            this.miEmployee.Name = "miEmployee";
            this.miEmployee.Size = new System.Drawing.Size(145, 22);
            this.miEmployee.Text = "Сотрудники";
            this.miEmployee.Visible = false;
            this.miEmployee.Click += new System.EventHandler(this.miEmployee_Click);
            // 
            // miTrain
            // 
            this.miTrain.Name = "miTrain";
            this.miTrain.Size = new System.Drawing.Size(145, 22);
            this.miTrain.Text = "Поезда";
            this.miTrain.Visible = false;
            this.miTrain.Click += new System.EventHandler(this.miTrain_Click);
            // 
            // miTrainDriver
            // 
            this.miTrainDriver.Name = "miTrainDriver";
            this.miTrainDriver.Size = new System.Drawing.Size(145, 22);
            this.miTrainDriver.Text = "Машинисты";
            this.miTrainDriver.Visible = false;
            this.miTrainDriver.Click += new System.EventHandler(this.miTrainDriver_Click);
            // 
            // miTicket
            // 
            this.miTicket.Name = "miTicket";
            this.miTicket.Size = new System.Drawing.Size(145, 22);
            this.miTicket.Text = "Билеты";
            this.miTicket.Visible = false;
            this.miTicket.Click += new System.EventHandler(this.miTicket_Click);
            // 
            // miDolj
            // 
            this.miDolj.Name = "miDolj";
            this.miDolj.Size = new System.Drawing.Size(145, 22);
            this.miDolj.Text = "Должности";
            this.miDolj.Visible = false;
            // 
            // miPassenger
            // 
            this.miPassenger.Name = "miPassenger";
            this.miPassenger.Size = new System.Drawing.Size(145, 22);
            this.miPassenger.Text = "Пассажиры";
            this.miPassenger.Visible = false;
            // 
            // miRoute
            // 
            this.miRoute.Name = "miRoute";
            this.miRoute.Size = new System.Drawing.Size(145, 22);
            this.miRoute.Text = "Маршруты";
            this.miRoute.Visible = false;
            this.miRoute.Click += new System.EventHandler(this.miRoute_Click);
            // 
            // miPlaceStatus
            // 
            this.miPlaceStatus.Name = "miPlaceStatus";
            this.miPlaceStatus.Size = new System.Drawing.Size(145, 22);
            this.miPlaceStatus.Text = "Статус места";
            this.miPlaceStatus.Visible = false;
            // 
            // miTicketFill
            // 
            this.miTicketFill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какоетоИзменениеToolStripMenuItem});
            this.miTicketFill.Enabled = false;
            this.miTicketFill.Name = "miTicketFill";
            this.miTicketFill.Size = new System.Drawing.Size(134, 20);
            this.miTicketFill.Text = "Оформление билета";
            // 
            // miDocs
            // 
            this.miDocs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployeeInfo,
            this.miRoutesList});
            this.miDocs.Name = "miDocs";
            this.miDocs.Size = new System.Drawing.Size(172, 20);
            this.miDocs.Text = "Формирование документов";
            // 
            // miEmployeeInfo
            // 
            this.miEmployeeInfo.Name = "miEmployeeInfo";
            this.miEmployeeInfo.Size = new System.Drawing.Size(211, 22);
            this.miEmployeeInfo.Text = "Личное дело сотрудника";
            this.miEmployeeInfo.Click += new System.EventHandler(this.miEmployeeInfo_Click);
            // 
            // miRoutesList
            // 
            this.miRoutesList.Name = "miRoutesList";
            this.miRoutesList.Size = new System.Drawing.Size(211, 22);
            this.miRoutesList.Text = "Список маршрутов";
            // 
            // miAdmin
            // 
            this.miAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRoles,
            this.miUsers});
            this.miAdmin.Name = "miAdmin";
            this.miAdmin.Size = new System.Drawing.Size(134, 20);
            this.miAdmin.Text = "Администрирование";
            this.miAdmin.Visible = false;
            // 
            // miRoles
            // 
            this.miRoles.Name = "miRoles";
            this.miRoles.Size = new System.Drawing.Size(152, 22);
            this.miRoles.Text = "Роли";
            // 
            // miUsers
            // 
            this.miUsers.Name = "miUsers";
            this.miUsers.Size = new System.Drawing.Size(152, 22);
            this.miUsers.Text = "Пользователи";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstDateTime,
            this.lbsstConnection});
            this.ssInfo.Location = new System.Drawing.Point(0, 428);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(800, 22);
            this.ssInfo.TabIndex = 1;
            this.ssInfo.Text = "statusStrip1";
            // 
            // lbsstDateTime
            // 
            this.lbsstDateTime.Font = new System.Drawing.Font("Arial", 9F);
            this.lbsstDateTime.Name = "lbsstDateTime";
            this.lbsstDateTime.Size = new System.Drawing.Size(120, 17);
            this.lbsstDateTime.Text = "00:00:00/00.00.0000";
            // 
            // lbsstConnection
            // 
            this.lbsstConnection.Name = "lbsstConnection";
            this.lbsstConnection.Size = new System.Drawing.Size(12, 17);
            this.lbsstConnection.Text = "-";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // какоетоИзменениеToolStripMenuItem
            // 
            this.какоетоИзменениеToolStripMenuItem.Name = "какоетоИзменениеToolStripMenuItem";
            this.какоетоИзменениеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.какоетоИзменениеToolStripMenuItem.Text = "Какое-то изменение";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miAuthorization;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripMenuItem miExitProfile;
        private System.Windows.Forms.ToolStripSeparator завершениеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExitFromSystem;
        private System.Windows.Forms.ToolStripMenuItem miHandBook;
        private System.Windows.Forms.ToolStripMenuItem miTicketFill;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel lbsstDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lbsstConnection;
        private System.Windows.Forms.ToolStripMenuItem miEmployee;
        private System.Windows.Forms.ToolStripMenuItem miTrain;
        private System.Windows.Forms.ToolStripMenuItem miTrainDriver;
        private System.Windows.Forms.ToolStripMenuItem miRoute;
        private System.Windows.Forms.ToolStripMenuItem miTicket;
        private System.Windows.Forms.ToolStripMenuItem miDolj;
        private System.Windows.Forms.ToolStripMenuItem miPassenger;
        private System.Windows.Forms.ToolStripMenuItem miPlaceStatus;
        private System.Windows.Forms.ToolStripMenuItem miAppSettings;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem miAdmin;
        private System.Windows.Forms.ToolStripMenuItem miRoles;
        private System.Windows.Forms.ToolStripMenuItem miUsers;
        private System.Windows.Forms.ToolStripMenuItem miDocs;
        private System.Windows.Forms.ToolStripMenuItem miEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem miRoutesList;
        private System.Windows.Forms.ToolStripMenuItem какоетоИзменениеToolStripMenuItem;
    }
}