using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace i_1_16_dotsu_kp
{
    class DBStoredProcedure
    {
        private SqlCommand storedProcedure = new SqlCommand("", DBConnection.sqlConnection);

        private void ConfigurationProcedure(string nameProcedure)
        {
            storedProcedure.CommandText = nameProcedure;
            storedProcedure.CommandType = System.Data.CommandType.StoredProcedure;
        }
        //Процедуры для таблицы Пассажир
        public void SPPassengerInsert(string surname, string name, string pantronymic) //Добавление пассажира
        {
            ConfigurationProcedure("passenger_insert");

            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);

            ExecuteStoredProcedure();
        }

        public void SPPassengerUpdate(Int32 idPassenger, string surname, string name, string pantronymic) //Обновление данных о Пассажире
        {
            ConfigurationProcedure("passenger_update");

            storedProcedure.Parameters.AddWithValue("@ID_passenger", idPassenger);
            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);

            ExecuteStoredProcedure();
        }

        public void SPPassengerDelete(Int32 idPassenger) //Удаление пассажира
        {
            ConfigurationProcedure("passenger_delete");

            storedProcedure.Parameters.AddWithValue("@ID_passenger", idPassenger);

            ExecuteStoredProcedure();
        }

        public void SPPassengerLogicalDelete(Int32 idPassenger) //Логическое удаление пассажира
        {
            ConfigurationProcedure("passenger_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_passenger", idPassenger);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Роли
        public void SPRoleInsert(string roleName, string adminRole, string guestrole, string employeeKadrRole, string employeeRaspRole, string employee_sale_role, string cashier_role) //Добавление роли
        {
            ConfigurationProcedure("role_insert");

            storedProcedure.Parameters.AddWithValue("@role_name", roleName);
            storedProcedure.Parameters.AddWithValue("@admin_role", adminRole);
            storedProcedure.Parameters.AddWithValue("@guest_role", guestrole);
            storedProcedure.Parameters.AddWithValue("@employee_kadr_role", employeeKadrRole);
            storedProcedure.Parameters.AddWithValue("@employee_rasp_role", employee_sale_role);
            storedProcedure.Parameters.AddWithValue("@employee_sale_role", cashier_role);
            storedProcedure.Parameters.AddWithValue("@cashier_role", cashier_role);

            ExecuteStoredProcedure();
        }

        public void SPRoleUpdate(Int32 idRole, string roleName, Int32 adminRole, Int32 guestrole, Int32 employeeKadrRole, Int32 employeeRaspRole, Int32 employee_sale_role, Int32 cashier_role) //Обновление данных о роли
        {
            ConfigurationProcedure("role_update");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);
            storedProcedure.Parameters.AddWithValue("@role_name", roleName);
            storedProcedure.Parameters.AddWithValue("@admin_role", adminRole);
            storedProcedure.Parameters.AddWithValue("@guest_role", guestrole);
            storedProcedure.Parameters.AddWithValue("@employee_kadr_role", employeeKadrRole);
            storedProcedure.Parameters.AddWithValue("@employee_rasp_role", employee_sale_role);
            storedProcedure.Parameters.AddWithValue("@employee_sale_role", cashier_role);
            storedProcedure.Parameters.AddWithValue("@cashier_role", cashier_role);

            ExecuteStoredProcedure();
        }

        public void SPRoleDelete(Int32 idRole) //Удаление роли
        {
            ConfigurationProcedure("role_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        public void SPRoleLogicalDelete(Int32 idRole) //Логическое удаление роли
        {
            ConfigurationProcedure("role_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Пользоавтели
        public void SPUsersInsert(string surname, string name, string pantronymic, string loginUser, string passwordUser, Int32 userRoleID) //Добавление пользователя
        {
            ConfigurationProcedure("users_insert");

            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@pantronymic", loginUser);
            storedProcedure.Parameters.AddWithValue("@pantronymic", passwordUser);
            storedProcedure.Parameters.AddWithValue("@pantronymic", userRoleID);

            ExecuteStoredProcedure();
        }

        public void SPUsersUpdate(Int32 idUser, string surname, string name, string pantronymic, string loginUser, string passwordUser, Int32 userRoleID) //Обновление данных о пользователе
        {
            ConfigurationProcedure("users_update");

            storedProcedure.Parameters.AddWithValue("ID_user", idUser);
            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@pantronymic", loginUser);
            storedProcedure.Parameters.AddWithValue("@pantronymic", passwordUser);
            storedProcedure.Parameters.AddWithValue("@pantronymic", userRoleID);

            ExecuteStoredProcedure();
        }

        public void SPUsersDelete(Int32 idUser) //Удаление пользователя
        {
            ConfigurationProcedure("users_delete");

            storedProcedure.Parameters.AddWithValue("@ID_user", idUser);

            ExecuteStoredProcedure();
        }

        public void SPUsersLogicalDelete(Int32 idUser) //Логическое удаление пользователя
        {
            ConfigurationProcedure("users_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_user", idUser);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Должность
        public void SPDoljInsert(string doljName, Int32 salary) //Добавление должности
        {
            ConfigurationProcedure("dolj_insert");

            storedProcedure.Parameters.AddWithValue("@dolj_name", doljName);
            storedProcedure.Parameters.AddWithValue("@salary", salary);
           

            ExecuteStoredProcedure();
        }

        public void SPDoljUpdate(Int32 idDolj, string doljName, Int32 salary) //Обновление данных о должности
        {
            ConfigurationProcedure("dolj_update");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);
            storedProcedure.Parameters.AddWithValue("@dolj_name", doljName);
            storedProcedure.Parameters.AddWithValue("@salary", salary);

            ExecuteStoredProcedure();
        }

        public void SPDoljDelete(Int32 idDolj) //Удаление должности
        {
            ConfigurationProcedure("dolj_delete");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);

            ExecuteStoredProcedure();
        }

        public void SPDoljLogicalDelete(Int32 idDolj) //Логическое удаление должности
        {
            ConfigurationProcedure("dolj_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Сотрудники
        public void SPEmployeeInsert(string surname, string name, string pantronymic, DateTime dateBirth, 
            Int32 numUdostov, string nameUchilisha, DateTime dateOkonch, string login, string password, Int32 dolj_id) //Добавление сотрудника
        {
            ConfigurationProcedure("employee_insert");

            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@date_birth", dateBirth);
            storedProcedure.Parameters.AddWithValue("@num_udostov", numUdostov);
            storedProcedure.Parameters.AddWithValue("@name_uchilisha", nameUchilisha);
            storedProcedure.Parameters.AddWithValue("@date_okonch", dateOkonch);
            storedProcedure.Parameters.AddWithValue("@login", login);
            storedProcedure.Parameters.AddWithValue("@password", password);
            storedProcedure.Parameters.AddWithValue("@dolj_id", dolj_id);

            ExecuteStoredProcedure();
        }

        public void SPEmployeeUpdate(Int32 idEmployee, string surname, string name, string pantronymic, DateTime dateBirth, 
            Int32 numUdostov, string nameUchilisha, DateTime dateOkonch, string login, string password, Int32 dolj_id) //Обновление данныx о сотруднике
        {
            ConfigurationProcedure("employee_update");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);
            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@date_birth", dateBirth);
            storedProcedure.Parameters.AddWithValue("@num_udostov", numUdostov);
            storedProcedure.Parameters.AddWithValue("@name_uchilisha", nameUchilisha);
            storedProcedure.Parameters.AddWithValue("@date_okonch", dateOkonch);
            storedProcedure.Parameters.AddWithValue("@login", login);
            storedProcedure.Parameters.AddWithValue("@password", password);
            storedProcedure.Parameters.AddWithValue("@dolj_id", dolj_id);

            ExecuteStoredProcedure();
        }

        public void SPEmployeeDelete(Int32 idEmployee) //Удаление сотрудника
        {
            ConfigurationProcedure("employee_delete");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);

            ExecuteStoredProcedure();
        }

        public void SPEmployeeLogicalDelete(Int32 idEmployee) //Логическое удаление сотрудника
        {
            ConfigurationProcedure("employee_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Поезда
        public void SPTrainInsert(Int32 numTrain, Int32 kol_voWagon, Int32 trainDriver) //Добавление поезда
        {
            ConfigurationProcedure("train_insert");

            storedProcedure.Parameters.AddWithValue("@num_train", numTrain);
            storedProcedure.Parameters.AddWithValue("@kol_vo_wagon", kol_voWagon);
            storedProcedure.Parameters.AddWithValue("@mach_employee_id", trainDriver);

            ExecuteStoredProcedure();
        }

        public void SPTrainUpdate(Int32 idTrain, Int32 numTrain, Int32 kol_voWagon, Int32 trainDriver) //Обновление данных о поезде
        {
            ConfigurationProcedure("train_update");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);
            storedProcedure.Parameters.AddWithValue("@num_train", numTrain);
            storedProcedure.Parameters.AddWithValue("@kol_vo_wagon", kol_voWagon);
            storedProcedure.Parameters.AddWithValue("@mach_employee_id", trainDriver);

            ExecuteStoredProcedure();
        }

        public void SPTrainDelete(Int32 idTrain) //Удаление поезда
        {
            ConfigurationProcedure("train_delete");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);

            ExecuteStoredProcedure();
        }

        public void SPTrainLogicalDelete(Int32 idTrain) //Логическое удаление поезда
        {
            ConfigurationProcedure("train_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Билет
        public void SPTicketInsert(Int32 numTicket, DateTime timeRegisry, DateTime timeDeparture, DateTime dateDeparture, 
            Int32 price, Int32 place, Int32 placeStatusID,Int32 passengerID, Int32 employeeID, Int32 routeID) //Добавление билета
        {
            ConfigurationProcedure("ticket_insert");

            storedProcedure.Parameters.AddWithValue("@num_ticket", numTicket);
            storedProcedure.Parameters.AddWithValue("@time_registry", timeRegisry);
            storedProcedure.Parameters.AddWithValue("@time_departure", timeDeparture);
            storedProcedure.Parameters.AddWithValue("@date_departure", dateDeparture);
            storedProcedure.Parameters.AddWithValue("@price", price);
            storedProcedure.Parameters.AddWithValue("@place", place);
            storedProcedure.Parameters.AddWithValue("@place_status_id", placeStatusID);
            storedProcedure.Parameters.AddWithValue("@passenger_id", passengerID);
            storedProcedure.Parameters.AddWithValue("@employee_id", employeeID);
            storedProcedure.Parameters.AddWithValue("@route_id", routeID);

            ExecuteStoredProcedure();
        }

        public void SPTicketUpdate(Int32 idTicket, Int32 numTicket, string timeRegisry, string timeDeparture, string dateDeparture, 
            Int32 price, Int32 place, Int32 passengerID, Int32 employeeID, Int32 routeID) //Обновление данных о билетt
        {
            ConfigurationProcedure("ticket_update");

            storedProcedure.Parameters.AddWithValue("@ID_ticket", idTicket);
            storedProcedure.Parameters.AddWithValue("@num_ticket", numTicket);
            storedProcedure.Parameters.AddWithValue("@time_registry", timeRegisry);
            storedProcedure.Parameters.AddWithValue("@time_departure", timeDeparture);
            storedProcedure.Parameters.AddWithValue("@date_departure", dateDeparture);
            storedProcedure.Parameters.AddWithValue("@price", price);
            storedProcedure.Parameters.AddWithValue("@place", place);
            storedProcedure.Parameters.AddWithValue("@passenger_id", passengerID);
            storedProcedure.Parameters.AddWithValue("@employee_id", employeeID);
            storedProcedure.Parameters.AddWithValue("@route_id", routeID);

            ExecuteStoredProcedure();
        }

        public void SPTicketDelete(Int32 idTicket) //Удаление билета
        {
            ConfigurationProcedure("ticket_delete");

            storedProcedure.Parameters.AddWithValue("@ID_ticket", idTicket);

            ExecuteStoredProcedure();
        }

        public void SPTicketLogicalDelete(Int32 idTicket) //Логическое удаление билета
        {
            ConfigurationProcedure("ticket_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_ticket", idTicket);

            ExecuteStoredProcedure();
        }

        public void ExecuteStoredProcedure() //Выполнение процедуры
        {
            try
            {
                DBConnection.sqlConnection.Open();
                DBConnection.sqlConnection.InfoMessage += MessageInformation;
                storedProcedure.ExecuteNonQuery();
                storedProcedure.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }

        public void MessageInformation(object sender, SqlInfoMessageEventArgs e) //Сообщение об ошибке
        {
            MessageBox.Show(e.Message);
        }
    }
}
