using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    public partial class Employees : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandEmployee = new SqlCommand("", Registry_Class.sqlConnection);
        private string filterEmployee = "";

        public Employees()
        {
            InitializeComponent();
        }
        public void UpdateEnable(bool valueUpdateEnable)
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Thread threadEmployee = new Thread(EmployeesFill);
            Thread threadDolj = new Thread(DoljFill);
            threadEmployee.Start();
            threadDolj.Start();
        }
        private void EmployeesFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTEmployee.Clear();
                    dbTables.DTEmployeeFill();
                    dbTables.dependency.OnChange += ChangeEmployees;

                    dgvEmployees.DataSource = dbTables.DTEmployee;
                    dgvEmployees.Columns[0].Visible = false;
                    dgvEmployees.Columns[1].HeaderText = "Фамилия сотрудника";
                    dgvEmployees.Columns[2].HeaderText = "Имя  сотрудника";
                    dgvEmployees.Columns[3].HeaderText = "Отчество сотрудника";
                    dgvEmployees.Columns[4].HeaderText = "Дата рождения";
                    dgvEmployees.Columns[5].HeaderText = "Номер аттестата";
                    dgvEmployees.Columns[6].HeaderText = "Название учебного заведения";
                    dgvEmployees.Columns[6].Width = 300;
                    dgvEmployees.Columns[7].HeaderText = "Дата окончания уч. заведения";
                    dgvEmployees.Columns[8].HeaderText = "Логин";
                    dgvEmployees.Columns[9].Visible = false;
                    dgvEmployees.Columns[9].HeaderText = "Пароль";
                    dgvEmployees.Columns[10].Visible = false;
                    dgvEmployees.Columns[11].HeaderText = "Должность";
                    dgvEmployees.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeEmployees(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                EmployeesFill();
        }
        private void DoljFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTDolj.Clear();
                    dbTables.DTDoljForComboBoxFill();
                    dbTables.dependency.OnChange += ChangeDolj;

                    cbDolj.DataSource = dbTables.DTDolj;
                    cbDolj.ValueMember = "ID_dolj";
                    cbDolj.DisplayMember = "dolj_name";
                    cbDolj.SelectedValue = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeDolj(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                DoljFill();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPEmployeeInsert(tbSurname.Text, tbName.Text, tbPantronymic.Text, Convert.ToDateTime(tbDateBirth.Text),
            Convert.ToInt32(tbNumUdostov.Text), tbNameUchilisha.Text, Convert.ToDateTime(tbDateOkonch.Text), tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbDolj.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbSurname.Clear();
            tbName.Clear();
            tbPantronymic.Clear();
            tbDateBirth.Clear();
            tbNumUdostov.Clear();
            tbNameUchilisha.Clear();
            tbDateOkonch.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
            cbDolj.SelectedValue = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedure.SPEmployeeUpdate(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()), tbSurname.Text, tbName.Text, tbPantronymic.Text, Convert.ToDateTime(tbDateBirth.Text),
            Convert.ToInt32(tbNumUdostov.Text), tbNameUchilisha.Text, Convert.ToDateTime(tbDateOkonch.Text), tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbDolj.SelectedIndex));
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении данных");
            }
            tbSurname.Clear();
            tbName.Clear();
            tbPantronymic.Clear();
            tbDateBirth.Clear();
            tbNumUdostov.Clear();
            tbNameUchilisha.Clear();
            tbDateOkonch.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
            cbDolj.SelectedValue = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно желаете полностью удалить запись " + tbSurname.Text + " " + tbName.Text + " " + tbPantronymic.Text + "?", "Удаления данных сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: 
                    try
                    {
                        storedProcedure.SPEmployeeDelete(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    try
                    {
                        storedProcedure.SPEmployeeLogicalDelete(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    tbSurname.Clear();
                    tbName.Clear();
                    tbPantronymic.Clear();
                    tbDateBirth.Clear();
                    tbNumUdostov.Clear();
                    tbNameUchilisha.Clear();
                    tbDateOkonch.Clear();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    cbDolj.SelectedValue = -1;
                    break;
            }
        }
    }
}
