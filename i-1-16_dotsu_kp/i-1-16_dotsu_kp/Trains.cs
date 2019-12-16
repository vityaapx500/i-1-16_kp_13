using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class Trains : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandEmployee = new SqlCommand("", Registry_Class.sqlConnection);
        private string filterEmployee = "";
        public Trains()
        {
            InitializeComponent();
        }

        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void Trains_Load(object sender, EventArgs e)
        {
            Thread threadTrains = new Thread(TrainsFill);
            threadTrains.Start();
        }
        private void TrainsFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTTrain.Clear();
                    dbTables.DTTrainFill();
                    dbTables.dependency.OnChange += ChangeTrain;

                    dgvTrains.DataSource = dbTables.DTTrain;
                    dgvTrains.Columns[0].Visible = false;
                    dgvTrains.Columns[1].HeaderText = "Номер поезда";
                    dgvTrains.Columns[2].HeaderText = "Количество вагонов в составе";
                    dgvTrains.Columns[3].Visible = false;
                    dgvTrains.Columns[4].HeaderText = "Машинист";
                    dgvTrains.Columns[4].Width = 230;
                    dgvTrains.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeTrain(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                TrainsFill();
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
                    cbTrainDriver.DisplayMember = "surname";
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
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPTrainInsert(Convert.ToInt32(tbNomerTrain.Text), Convert.ToInt32(tbKol_voWagon.Text), Convert.ToInt32(cbTrainDriver.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbNomerTrain.Clear();
            tbKol_voWagon.Clear();
            cbTrainDriver.SelectedValue = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}