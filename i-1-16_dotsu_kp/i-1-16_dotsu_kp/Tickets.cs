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
       private void Tickets_Load(object sender, EventArgs e)
        {
            Thread threadTickets = new Thread(TicketFill);
            threadTickets.Start();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}