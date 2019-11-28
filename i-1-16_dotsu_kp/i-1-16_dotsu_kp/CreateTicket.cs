using System;
using System.Data;
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
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
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
    }
}
