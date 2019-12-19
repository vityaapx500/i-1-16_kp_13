using System;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
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
                SqlCommand commandSearchUser = new SqlCommand("", Registry_Class.sqlConnection);
                SqlCommand commandRoleUser = new SqlCommand("", Registry_Class.sqlConnection);
                commandSearchUser.CommandText = "select count(*) from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [user_role_id] from [dbo].[users] where [login_user] = '" + tbLogin.Text + "' and [password_user] ='" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    Registry_Class.sqlConnection.Open();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                }
                catch
                {
                    MessageBox.Show("Не правильный логин или пароль", "Ошибки в результате работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Registry_Class.sqlConnection.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {
                    Registry_Class.sqlConnection.Open();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    Registry_Class.sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MainMenuForm MMF = new MainMenuForm();
                    //MMF.MainMenuConstraint(userRole);
                    EnabledComponent.EventHandler(userRole);
                    Hide();
                }
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Close();
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