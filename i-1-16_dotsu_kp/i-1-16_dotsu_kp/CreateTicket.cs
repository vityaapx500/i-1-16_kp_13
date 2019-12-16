using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class CreateTicket : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        public CreateTicket()
        {
            InitializeComponent();
        }
        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
        }
        private void CreateTicket_Load(object sender, EventArgs e)
        {
            Thread threadPlaceStatus = new Thread(PlaceStatusFill);

            threadPlaceStatus.Start();
            int numNextticket;
            SqlCommand nextTicket = new SqlCommand("", DBConnection.sqlConnection);
            nextTicket.CommandText = "select count(*) as 'Count_Ticket' from dbo.ticket where ticket_logical_delete = 0";
            try
            {
                DBConnection.sqlConnection.Open();
                numNextticket = Convert.ToInt32(nextTicket.ExecuteScalar().ToString()) + 1;
                tbNumTicket.Text = numNextticket.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка оформления билета", ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPTicketInsert(Convert.ToInt32(tbNumTicket.Text), Convert.ToDateTime(tbTimeRegistry.Text),
                    Convert.ToDateTime(tbTimeDeparture.Text), Convert.ToDateTime(tbDateDeparture.Text), Convert.ToInt32(tbPrice.Text),
                    Convert.ToInt32(tbPlace.Text), Convert.ToInt32(cbPlaceStatus.Text), Convert.ToInt32(cbPassenger.Text), Convert.ToInt32(cbRoute.Text),
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
            cbPlaceStatus.SelectedValue = -1;
            cbPassenger.SelectedValue = -1;
            cbRoute.SelectedValue = -1;
            cbEmployee.SelectedValue = -1;
        }
        private void PlaceStatusFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTPlaceStatus.Clear();
                    dbTables.DTPlaceStatusForCB();
                    dbTables.dependency.OnChange += ChangePlaceStatus;

                    cbPlaceStatus.DataSource = dbTables.DTPlaceStatus;
                    cbPlaceStatus.ValueMember = "ID_place_status";
                    cbPlaceStatus.DisplayMember = "name_status";
                    cbPlaceStatus.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangePlaceStatus(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                PlaceStatusFill();
        }
    }
}
