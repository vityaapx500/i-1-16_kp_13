using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class Tickets : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandEmployee = new SqlCommand("", DBConnection.sqlConnection);
        private string filterEmployee = "";
        public Tickets()
        {
            InitializeComponent();
        }
        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            Thread threadTickets = new Thread(TicketFill);
            Thread threadPassenger = new Thread(PassengerFill);
            Thread threadRoute = new Thread(RouteFill);
            Thread threadCashier = new Thread(CashierFill);
            threadTickets.Start();
            threadPassenger.Start();
            threadRoute.Start();
            threadCashier.Start();
        }
        private void TicketFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTTicket.Clear();
                    dbTables.DTTicketFill();
                    dbTables.dependency.OnChange += ChangeTicket;

                    dgvTickets.DataSource = dbTables.DTTicket;
                    dgvTickets.Columns[0].Visible = false;
                    dgvTickets.Columns[1].HeaderText = "Номер билета";
                    dgvTickets.Columns[2].HeaderText = "Время оформления";
                    dgvTickets.Columns[3].HeaderText = "Вермя отправления";
                    dgvTickets.Columns[4].HeaderText = "Дата отправления";
                    dgvTickets.Columns[5].HeaderText = "Стоимость";
                    dgvTickets.Columns[6].HeaderText = "Место";
                    dgvTickets.Columns[7].Visible = false;
                    dgvTickets.Columns[8].HeaderText = "Статус места";
                    dgvTickets.Columns[9].Visible = false;
                    dgvTickets.Columns[10].HeaderText = "Пассажир";
                    dgvTickets.Columns[11].Visible = false;
                    dgvTickets.Columns[12].HeaderText = "Маршрут";
                    dgvTickets.Columns[13].Visible = false;
                    dgvTickets.Columns[14].HeaderText = "Кассир";
                    dgvTickets.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeTicket(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                TicketFill();
        }
        private void PassengerFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTPassenger.Clear();
                    dbTables.DTPassengerForComboBoxFill();
                    dbTables.dependency.OnChange += ChangePassenger;

                    cbPassenger.DataSource = dbTables.DTPassenger;
                    cbPassenger.ValueMember = "ID_passenger";
                    cbPassenger.DisplayMember = "[name] +' '+[surname]+' '+[pantronymic]";
                    cbPassenger.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangePassenger(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                PassengerFill();
        }

        private void RouteFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTRoute.Clear();
                    dbTables.DTRouteFill();
                    dbTables.dependency.OnChange += ChangeRoute;

                    cbPassenger.DataSource = dbTables.DTRoute;
                    cbPassenger.ValueMember = "ID_route";
                    cbPassenger.DisplayMember = "num_route";
                    cbPassenger.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeRoute(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                RouteFill();
        }
        //
        private void CashierFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTEmployee.Clear();
                    dbTables.DTCashierFill();
                    dbTables.dependency.OnChange += ChangeCashier;

                    cbPassenger.DataSource = dbTables.DTEmployee;
                    cbPassenger.ValueMember = "ID_employee";
                    cbPassenger.DisplayMember = "[surname] +' '+ [name] +' '+ [pantronymic]";
                    cbPassenger.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeCashier(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                CashierFill();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPTicketInsert(Convert.ToInt32(tbNumTicket.Text), Convert.ToDateTime(tbTimeRegistry.Text), 
                    Convert.ToDateTime(tbTimeDeparture.Text), Convert.ToDateTime(tbDateDeparture.Text), Convert.ToInt32(tbPrice.Text),
                    Convert.ToInt32(tbPlace.Text), Convert.ToInt32(tbPlaceStatus.Text), Convert.ToInt32(cbPassenger.Text), Convert.ToInt32(cbRoute.Text), 
                    Convert.ToInt32(cbEmployee.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbNumTicket.Clear();
            tbTimeRegistry.Clear();
            tbTimeDeparture.Clear();
            tbDateDeparture.Clear();
            tbPlace.Clear();
            tbPlaceStatus.Clear();
            cbPassenger.SelectedValue = -1;
            cbRoute.SelectedValue = -1;
            cbEmployee.SelectedValue = -1;
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