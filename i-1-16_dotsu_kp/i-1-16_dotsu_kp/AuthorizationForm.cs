using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
        private int checkUser = 0;
        public static int userRole = 0;
        public static string FIODirector = "";
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.TextLength == 0 || tbPassword.TextLength == 0)  //проверка заполненности полей
                MessageBox.Show("Все поля должны быть заполнены", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand commandSearchUser = new SqlCommand("", RegistryData.DBConnectionString);
                SqlCommand commandRoleUser = new SqlCommand("", RegistryData.DBConnectionString);
                commandSearchUser.CommandText = "select count(*) from[dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] = '" + tbPassword.Text + "'";
                //commandRoleUser.CommandText = "select [Role_User_ID] from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "' and CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    RegistryData.DBConnectionString.Open();
                    //dbTables.CommandOpenKey.ExecuteNonQuery();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                    //dbTables.CommandCloseKey.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не правильный логин или пароль", "Ошибки в результате работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RegistryData.DBConnectionString.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {

                    RegistryData.DBConnectionString.Open();
                    //dbTables.CommandOpenKey.ExecuteNonQuery();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    //dbTables.CommandCloseKey.ExecuteNonQuery();
                    RegistryData.DBConnectionString.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnabledComponent.EventHandler(userRole);
                    this.Hide();
                }
            }
        }
    }
}
