﻿using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class Users : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandEmployee = new SqlCommand("", DBConnection.sqlConnection);
        private string filterEmployee = "";
        public Users()
        {
            InitializeComponent();
        }
        
        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Thread threadUsers = new Thread(UsersFill);
            Thread threadRoles = new Thread(RoleFill);
            threadUsers.Start();
            threadRoles.Start();
        }
        private void UsersFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTUsers.Clear();
                    dbTables.DTUsersFill();
                    dbTables.dependency.OnChange += ChangeRole;

                    dgvUsers.DataSource = dbTables.DTUsers;
                    dgvUsers.Columns[0].HeaderText = "Фамилия пользователя";
                    dgvUsers.Columns[1].HeaderText = "Имя  пользователя";
                    dgvUsers.Columns[2].HeaderText = "Отчество пользователя";
                    dgvUsers.Columns[3].HeaderText = "Логин";
                    dgvUsers.Columns[4].HeaderText = "Пароль";
                    dgvUsers.Columns[5].HeaderText = "Роль";
                    dgvUsers.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeUser(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                UsersFill();
        }
        private void RoleFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTRoles.Clear();
                    dbTables.DTRolesForComboBoxFill();
                    dbTables.dependency.OnChange += ChangeRole;

                    cbRole.DataSource = dbTables.DTRoles;
                    cbRole.ValueMember = "ID_role";
                    cbRole.DisplayMember = "role_name";
                    cbRole.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeRole(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                RoleFill();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPUsersInsert(tbSurname.Text, tbName.Text, tbPantronymic.Text, tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbRole.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbSurname.Clear();
            tbName.Clear();
            tbPantronymic.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
            cbRole.SelectedValue = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
//Работаю над формой пользовали