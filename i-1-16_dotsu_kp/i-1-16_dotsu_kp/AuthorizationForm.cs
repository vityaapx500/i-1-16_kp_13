using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
        private static DBConnection0 dBConnection = new DBConnection0();
        private int checkUser = 0;
        public static int userRole = 0;

        public string qwSotr = "select *  from  [dbo].[train]";
        
        private static string dataSource = @"ВИКТОР-ПК\VICTOR_SQL";
        private static string initialCatalog = "vokzal_v1";
        private static string userID = "sa";
        private static string password = "123";
        private static bool checkSecurity = true;
        SqlConnection sqlConnection = new SqlConnection($"Data Source = {dataSource}; Initial Catalog = {initialCatalog};" +
            $"Persist Security Info = {checkSecurity}; User ID = {userID}; password = \"{password}\"");
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
                SqlCommand commandSearchUser = new SqlCommand("", sqlConnection);
                SqlCommand commandRoleUser = new SqlCommand("", sqlConnection);
                commandSearchUser.CommandText = "select count(*) from[dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [user_role_id] from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] ='" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    sqlConnection.Open();
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
                    sqlConnection.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {

                    sqlConnection.Open();
                    //dbTables.CommandOpenKey.ExecuteNonQuery();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    //dbTables.CommandCloseKey.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //EnabledComponent.EventHandler(userRole);
                    this.Hide();
                    MainMenuForm MMF = new MainMenuForm();
                    MMF.Show();
                }
            }
        }
    }
}