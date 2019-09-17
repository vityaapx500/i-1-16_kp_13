using System;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class MainMenuForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private RegistryData registryData = new RegistryData();
        private Thread threadCheckConnection;

        public MainMenuForm()
        {
            InitializeComponent();
            //EnabledComponent.EventHandler = new EnabledComponent.MyEvent(EnableMenu);
        }

        public void MainMenu_Load(object sender, EventArgs e)   //загрузка формы
        {
            lbsstConnection.Visible = true;
            lbsstConnection.Text = "Определение сервера...";
            dbConnection.ConnectionState += InformationConnection;
            threadCheckConnection = new Thread(dbConnection.CheckConnection);
            threadCheckConnection.Start();
        }


        private void EnableMenu(int userRole)    //доступность меню
        {
            switch (userRole)
            {
                case 1:
                    miHandBook.Enabled = true;
                    miEmployee.Enabled = true;
                    miTrain.Enabled = true;
                    miTrainDriver.Enabled = true;
                    miDolj.Enabled = true;
                    miPassenger.Enabled = true;
                    miPlaceStatus.Enabled = true;
                    miRoute.Enabled = true;
                    miTicket.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 2:
                    miHandBook.Enabled = true;
                    miRoute.Enabled = true;
                    miPlaceStatus.Enabled = true;
                    miExitProfile.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 3:
                    miHandBook.Enabled = true;
                    miEmployee.Enabled = true;
                    miTrainDriver.Enabled = true;
                    miDocs.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miAppSettings.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 4:
                    miHandBook.Enabled = true;
                    miPassenger.Enabled = true;
                    miRoute.Enabled = true;
                    miTicket.Enabled = true;
                    miDocs.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miAppSettings.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 5:
                    miHandBook.Enabled = true;
                    miRoute.Enabled = true;
                    miTrain.Enabled = true;
                    miTrainDriver.Enabled = true;
                    miEmployee.Enabled = true;
                    miDocs.Enabled = true;
                    miSettings.Enabled = true;
                    miAppSettings.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;
                case 6:
                    miPassenger.Enabled = true;
                    miRoute.Enabled = true;
                    miTrain.Enabled = true;
                    miTicket.Enabled = true;
                    miSettings.Enabled = true;
                    miAppSettings.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;
            }
        }

        private void InformationConnection(bool value)  //проверка подключения к базе данных
        {
            try
            {
                Action action = () =>
                {
                    switch (value)
                    {
                        case (true):
                            lbsstConnection.Text = RegistryData.DataSourceIP + "\\" + RegistryData.DataSourceServerName + " - " + RegistryData.InitialCatalog;
                            AuthorizationForm authorizationForm = new AuthorizationForm();
                            authorizationForm.Show(this);
                            break;
                        case (false):
                            lbsstConnection.Text = "Подключение отсутствует!";

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "ConnectionForm")
                                    return;
                            }

                            ConnectionForm connectionForm = new ConnectionForm();
                            connectionForm.Show(this);
                            break;
                    }
                };
                Invoke(action);
            }
            catch
            {
                threadCheckConnection.Abort();
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)    //закрытие формы
        {
            Application.Exit();
        }

        private void miEmployee_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    employees.btnInsert.Enabled = true;
                    employees.btnUpdate.Enabled = true;
                    employees.btnDelete.Enabled = true;
                    break;
                case 3:
                    employees.btnInsert.Enabled = true;
                    employees.btnUpdate.Enabled = true;
                    employees.btnDelete.Enabled = true;
                    break;
            }
            employees.Show(this);
        }

        private void miTrain_Click(object sender, EventArgs e)
        {
            TrainsForm trains = new TrainsForm();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    trains.btnInsert.Enabled = true;
                    trains.btnUpdate.Enabled = true;
                    trains.btnDelete.Enabled = true;
                    break;
                case 5:
                    trains.btnInsert.Enabled = true;
                    trains.btnUpdate.Enabled = true;
                    trains.btnDelete.Enabled = true;
                    break;
            }
            trains.Show(this);
        }

        private void miTrainDriver_Click(object sender, EventArgs e)
        {
            //Сделать форму
        }

        private void miTicket_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    tickets.btnInsert.Enabled = true;
                    tickets.btnUpdate.Enabled = true;
                    tickets.btnDelete.Enabled = true;
                    break;
                case 4:
                    tickets.btnInsert.Enabled = true;
                    tickets.btnUpdate.Enabled = true;
                    tickets.btnDelete.Enabled = true;
                    break;
                case 6:
                    tickets.btnInsert.Enabled = true;
                    tickets.btnUpdate.Enabled = true;
                    tickets.btnDelete.Enabled = true;
                    break;
            }
            tickets.Show(this);
        }

        private void miDolj_Click(object sender, EventArgs e)
        {
            //DoljForm doljForm = new DoljForm();
            //genreBookForm.Show(this);
        }

        private void miPassenger_Click(object sender, EventArgs e)
        {
            //Сделать форму
        }

        private void miRoute_Click(object sender, EventArgs e)
        {
            //Сделать форму
        }

        private void miPlaceStatus_Click(object sender, EventArgs e)
        {
            //Сделать форму
        }
        private void miExitSystem_Click(object sender, EventArgs e) //выход из ИС
        {
            Application.Exit();
        }

        private void miExitProfile_Click(object sender, EventArgs e)    //выход из профиля
        {
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
                case 2:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
                case 3:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
                case 4:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
                case 5:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
                case 6:
                    miHandBook.Enabled = false;
                    miEmployee.Enabled = false;
                    miTrain.Enabled = false;
                    miTrainDriver.Enabled = false;
                    miDolj.Enabled = false;
                    miPassenger.Enabled = false;
                    miPlaceStatus.Enabled = false;
                    miRoute.Enabled = false;
                    miTicket.Enabled = false;
                    miAuthorization.Enabled = false;
                    break;
            }
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
            AuthorizationForm.userRole = 0;
        }
        //private void miCreateActs_Click(object sender, EventArgs e) //открытия форма для формирования документов актов
        //{
        //    FormationActsForm formationActsForm = new FormationActsForm();
        //    formationActsForm.Show(this);
        //}

        //private void miCreateSummaryBook_Click(object sender, EventArgs e)  //формирования документа Книга суммарного учета
        //{
        //    SummaryBookExcel summaryBookExcel = new SummaryBookExcel();
        //    Thread threadSummaryBookExcel = new Thread(summaryBookExcel.SummaryBookFill);
        //    threadSummaryBookExcel.Start();
        //}

        private void miAuthorization_Click(object sender, EventArgs e)  //открытие окна авторизации
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
        }

        //private void miSettingApplication_Click(object sender, EventArgs e) //открытие окна настройки приложения
        //{
        //    SettingsApplication settingsApplication = new SettingsApplication();
        //    settingsApplication.Show(this);
        //}

        private void miSettingConnection_Click(object sender, EventArgs e)  //открытие окна настройки подключения к БД
        {
            ConnectionForm connectionFormOpen = new ConnectionForm();
            connectionFormOpen.Show(this);
        }
    }
}
