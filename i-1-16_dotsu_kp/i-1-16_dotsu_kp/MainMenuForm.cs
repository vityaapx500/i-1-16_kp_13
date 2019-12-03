using System;
using System.Data;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class MainMenuForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private int selectedCellCount = 0;
        private DataTable dtSelectedRows = new DataTable();
        private DataTable dtSelectedExceptionRows = new DataTable();

        public MainMenuForm()
        {
            InitializeComponent();
            EnabledComponent.EventHandler = new EnabledComponent.MyEvent(MainMenuConstraint);
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            MainMenuConstraint(AuthorizationForm.userRole);
        }
        public void MainMenuConstraint(int userRole)   //загрузка формы с разрешениями для пользователей
        {
            switch (userRole)
            {
                case 1:
                    miHandBook.Visible = true;
                    miHandBook.Enabled = true;
                    miTicketFill.Enabled = true;
                    miEmployee.Visible = true;
                    miTrain.Visible = true;
                    miTrainDriver.Visible = true;
                    miDolj.Visible = true;
                    miPassenger.Visible = true;
                    miPlaceStatus.Visible = true;
                    miRoute.Visible = true;
                    miTicket.Visible = true;
                    miAuthorization.Enabled = false;
                    miAdmin.Visible = true;
                    break;

                case 2:
                    miHandBook.Visible = true;
                    miHandBook.Enabled = true;
                    miRoute.Visible = true;
                    miPlaceStatus.Visible = true;
                    miExitProfile.Visible = true;
                    miAuthorization.Enabled = false;
                    break;

                case 3:
                    miHandBook.Visible = true;
                    miHandBook.Enabled = true;
                    miEmployee.Visible = true;
                    miTrainDriver.Visible = true;
                    miExitProfile.Visible = true;
                    miSettings.Visible = true;
                    miAppSettings.Visible = true;
                    miAuthorization.Enabled = false;
                    break;

                case 4:
                    miHandBook.Visible = true;
                    miHandBook.Enabled = true;
                    miPassenger.Visible = true;
                    miRoute.Visible = true;
                    miTicket.Visible = true;
                    miExitProfile.Visible = true;
                    miSettings.Visible = true;
                    miAppSettings.Visible = true;
                    miAuthorization.Enabled = false;
                    break;

                case 5:
                    miHandBook.Visible = true;
                    miHandBook.Enabled = true;
                    miRoute.Visible = true;
                    miTrain.Visible = true;
                    miTrainDriver.Visible = true;
                    miEmployee.Visible = true;
                    miSettings.Visible = true;
                    miAppSettings.Visible = true;
                    miAuthorization.Enabled = false;
                    break;
                case 6:
                    miPassenger.Visible = true;
                    miHandBook.Enabled = true;
                    miRoute.Visible = true;
                    miTrain.Visible = true;
                    miTicket.Visible = true;
                    miSettings.Visible = true;
                    miAppSettings.Visible = true;
                    miAuthorization.Enabled = false;
                    break;
            }
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

        private void miUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    users.btnInsert.Enabled = true;
                    users.btnUpdate.Enabled = true;
                    users.btnDelete.Enabled = true;
                    break;
                case 3:
                    users.btnInsert.Enabled = true;
                    users.btnUpdate.Enabled = true;
                    users.btnDelete.Enabled = true;
                    break;
            }
            users.Show(this);
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
            //switch (AuthorizationForm.userRole)
            //{
            //    case 1:
            //        tickets.btnInsert.Enabled = true;
            //        tickets.btnUpdate.Enabled = true;
            //        tickets.btnDelete.Enabled = true;
            //        break;
            //    case 4:
            //        tickets.btnInsert.Enabled = true;
            //        tickets.btnUpdate.Enabled = true;
            //        tickets.btnDelete.Enabled = true;
            //        break;
            //    case 6:
            //        tickets.btnInsert.Enabled = true;
            //        tickets.btnUpdate.Enabled = true;
            //        tickets.btnDelete.Enabled = true;
            //        break;
            //}
            tickets.Show(this);
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
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
                case 2:
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
                case 3:
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
                case 4:
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
                case 5:
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
                case 6:
                    miHandBook.Visible = false;
                    miEmployee.Visible = false;
                    miTrain.Visible = false;
                    miTrainDriver.Visible = false;
                    miDolj.Visible = false;
                    miPassenger.Visible = false;
                    miPlaceStatus.Visible = false;
                    miRoute.Visible = false;
                    miTicket.Visible = false;
                    miAuthorization.Enabled = false;
                    break;
            }

            Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            AuthorizationForm.userRole = 0;
        }
        private void miAuthorization_Click(object sender, EventArgs e)  //открытие окна авторизации
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
        }
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)    //закрытие формы
        {
            //Application.Exit();
        }
        private void CreateTableSelectedRows()
        {

        }
        private void miEmployeeInfo_Click(object sender, EventArgs e)
        {
            //Создать форму со списком маршрутов и на ней сделать кнопки формирования документов Word and PDF
        }

        private void miRoute_Click(object sender, EventArgs e)
        {
            Route route = new Route();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    route.btnInsert.Enabled = true;
                    route.btnUpdate.Enabled = true;
                    route.btnDelete.Enabled = true;
                    break;
                case 2:
                    route.btnInsert.Enabled = false;
                    route.btnUpdate.Enabled = false;
                    route.btnDelete.Enabled = false;
                    break;
                case 4:
                    route.btnInsert.Enabled = false;
                    route.btnUpdate.Enabled = false;
                    route.btnDelete.Enabled = false;
                    break;
                case 5:
                    route.btnInsert.Enabled = true;
                    route.btnUpdate.Enabled = true;
                    route.btnDelete.Enabled = true;
                    break;
            }
            route.Show(this);
        }

        private void miTicketFill_Click(object sender, EventArgs e)
        {
            CreateTicket createTicket = new CreateTicket();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    createTicket.btnInsert.Enabled = true;
                    createTicket.btnUpdate.Enabled = true;
                    createTicket.btnDelete.Enabled = true;
                    break;
                case 6:
                    createTicket.btnInsert.Enabled = true;
                    createTicket.btnUpdate.Enabled = true;
                    createTicket.btnDelete.Enabled = true;
                    break;
            }
            createTicket.Show(this);
        }
    }
}