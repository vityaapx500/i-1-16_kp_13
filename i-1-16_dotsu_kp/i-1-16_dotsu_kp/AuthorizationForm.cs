using System;
using System.Data.SqlClient;
using Microsoft.Win32;
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
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    DBConnection.sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEnter_Click(sender, e);
        }
        private void AuthorizationForm_Load(object sender, EventArgs e) //Проверка имени операционной системы
        {
            string key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(key))
            {
                if (regKey != null)
                {
                    try
                    {
                        string name = regKey.GetValue("ProductName").ToString();
                        if (name.Contains("XP") || name.Contains("Vista"))
                        {
                            MessageBox.Show("Версия вашей операционной сисетмы не поддерживается. \nПожалуйства обновитесь до версии не ниже Windows 7 Home 32bit!", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Не удалось получить имя ОС в реестре");
            }
        }
    }
}