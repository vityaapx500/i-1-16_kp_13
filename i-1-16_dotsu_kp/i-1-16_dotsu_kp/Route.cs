using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class Route : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandEmployee = new SqlCommand("", DBConnection.sqlConnection);
        private string filterEmployee = "";
        public Route()
        {
            InitializeComponent();
        }
        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void Route_Load(object sender, EventArgs e)
        {
            Thread threadRoute = new Thread(RouteFill);
            Thread threadTrain = new Thread(TrainFill);
            Thread threadTrainDriver = new Thread(EmployeeFill);
            threadRoute.Start();
            threadTrain.Start();
            threadTrainDriver.Start();
        }
        private void RouteFill()
        {
            DBTables dBTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dBTables.DTRoute.Clear();
                    dBTables.DTRouteFill();
                    dBTables.dependency.OnChange += ChangeRoute;

                    dgvRoute.DataSource = dBTables.DTRoute;
                    dgvRoute.Columns[0].Visible = false;
                    dgvRoute.Columns[1].HeaderText = "Номер маршрута";
                    dgvRoute.Columns[2].HeaderText = "Станция назначения";
                    dgvRoute.Columns[3].HeaderText = "Время прибытия";
                    dgvRoute.Columns[4].HeaderText = "Время отправления";
                    dgvRoute.Columns[5].Visible = false;
                    dgvRoute.Columns[6].HeaderText = "Поезд";
                    dgvRoute.Columns[7].Visible = false;
                    dgvRoute.Columns[8].Visible = false;
                    dgvRoute.Columns[9].Width = 200;
                    dgvRoute.Columns[9].HeaderText = "Машинист";
                    dgvRoute.Columns[10].HeaderText = "Цена";
                    dgvRoute.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void TrainFill()
        {
            DBTables dBTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dBTables.DTTrain.Clear();
                    dBTables.DTTrainForComboBoxFill();
                    dBTables.dependency.OnChange += ChangeTrain;

                    cbTrain.DataSource = dBTables.DTTrain;
                    cbTrain.ValueMember = "ID_train";
                    cbTrain.DisplayMember = "num_train";
                    cbTrain.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void EmployeeFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTEmployee.Clear();
                    dbTables.DTTrainDriverFill();
                    dbTables.dependency.OnChange += ChangeEmployee;

                    cbTrainDriver.DataSource = dbTables.DTEmployee;
                    cbTrainDriver.ValueMember = "ID_employee";
                    cbTrainDriver.DisplayMember = "Name_Driver";
                    cbTrainDriver.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeEmployee(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                EmployeeFill();
        }
        private void ChangeRoute(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                RouteFill();
        }
        private void ChangeTrain(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                TrainFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
