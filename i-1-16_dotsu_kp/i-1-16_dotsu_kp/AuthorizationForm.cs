using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
        private static DBConnection dBConnection = new DBConnection();
        private int checkUser = 0;
        public static int userRole = 0;        
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
                SqlCommand commandSearchUser = new SqlCommand("", DBConnection.sqlConnection);
                SqlCommand commandRoleUser = new SqlCommand("", DBConnection.sqlConnection);
                commandSearchUser.CommandText = "select count(*) from[dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [user_role_id] from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] ='" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    DBConnection.sqlConnection.Open();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                }
                catch
                {
                    MessageBox.Show("Не правильный логин или пароль", "Ошибки в результате работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.sqlConnection.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {

                    DBConnection.sqlConnection.Open();
                    //dbTables.CommandOpenKey.ExecuteNonQuery();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    //dbTables.CommandCloseKey.ExecuteNonQuery();
                    DBConnection.sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //EnabledComponent.EventHandler(userRole);
                    this.Hide();
                    MainMenuForm MMF = new MainMenuForm();
                    MMF.Show();
                }
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}