using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    class SendMail
    {
        public void SendMailFeedBack(string bodyMail, string nameAuthor, string subject)
        {
            try
            {
                var from = new MailAddress("vityaapx500@mail.ru", nameAuthor);
                var to = new MailAddress("VictorSC30@yandex.ru");

                SmtpClient client = new SmtpClient("smtp.mail.ru", 25);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("vityaapx500@mail.ru", "finiasiferb");
                client.EnableSsl = true;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = bodyMail;
                mail.IsBodyHtml = true;

                client.SendMailAsync(mail);

                MessageBox.Show("Сообщение отправлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
