using System;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class FormReceive : Form
    {
        public FormReceive()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.SendMailFeedBack(tbMessage.Text, tbFromWho.Text, tbTheme.Text);
            Close();
        }
    }
}