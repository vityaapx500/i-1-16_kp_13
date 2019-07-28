using System;
using System.Data.SqlClient;

namespace i_1_16_dotsu_kp
{
    class DBStoredProcedure
    {
        private SqlCommand storedProcedure = new SqlCommand("", RegistryData.DBConnectionString);

        private void ConfigurationProcedure(string nameProcedure)
        {
            storedProcedure.CommandText = nameProcedure;
            storedProcedure.CommandType = System.Data.CommandType.StoredProcedure;
        }
        //Процедуры для таблицы Пассажир
        public void SPPassengerInsert(string secondName, string firstName, string otchestvo) //Добавление пассажира
        {
            ConfigurationProcedure("passenger_insert");

            storedProcedure.Parameters.AddWithValue("@second_name", secondName);
            storedProcedure.Parameters.AddWithValue("@first_name", firstName);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);

            ExecuteStoredProcedure();
        }

        public void SPPassengerUpdate(Int32 idPassenger, string secondName, string firstName, string otchestvo) //Обновление данный о Пассажире
        {
            ConfigurationProcedure("passenger_update");

            storedProcedure.Parameters.AddWithValue("@ID_passenger", idPassenger);
            storedProcedure.Parameters.AddWithValue("@second_name", secondName);
            storedProcedure.Parameters.AddWithValue("@first_name", firstName);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);

            ExecuteStoredProcedure();
        }

        private void SPPassengerDelete(Int32 idPassenger) //Удаление пассажира
        {
            ConfigurationProcedure("passenger_delete");

            storedProcedure.Parameters.AddWithValue("@ID_passenger", idPassenger);

            ExecuteStoredProcedure();
        }

        private void SPPassengerLogicalDelete(Int32 idPassenger) //Логическое удаление пассажира
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

        public void SPRoleUpdate(Int32 idRole, string roleName, Int32 adminRole, Int32 guestrole, Int32 employeeKadrRole, Int32 employeeRaspRole, Int32 employee_sale_role, Int32 cashier_role) //Обновление данный о роли
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

        private void SPRoleDelete(Int32 idRole) //Удаление роли
        {
            ConfigurationProcedure("role_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        private void SPRoleLogicalDelete(Int32 idRole) //Логическое удаление роли
        {
            ConfigurationProcedure("role_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Пользоавтели
        public void SPUsersInsert(string surname, string name, string otchestvo, string loginUser, string passwordUser, Int32 userRoleID) //Добавление пользователя
        {
            ConfigurationProcedure("users_insert");

            storedProcedure.Parameters.AddWithValue("@second_name", surname);
            storedProcedure.Parameters.AddWithValue("@first_name", name);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);
            storedProcedure.Parameters.AddWithValue("@otchestvo", loginUser);
            storedProcedure.Parameters.AddWithValue("@otchestvo", passwordUser);
            storedProcedure.Parameters.AddWithValue("@otchestvo", userRoleID);

            ExecuteStoredProcedure();
        }

        public void SPUsersUpdate(Int32 idUser, string surname, string name, string otchestvo, string loginUser, string passwordUser, Int32 userRoleID) //Обновление данный о пользователе
        {
            ConfigurationProcedure("users_update");

            storedProcedure.Parameters.AddWithValue("ID_user", idUser);
            storedProcedure.Parameters.AddWithValue("@second_name", surname);
            storedProcedure.Parameters.AddWithValue("@first_name", name);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);
            storedProcedure.Parameters.AddWithValue("@otchestvo", loginUser);
            storedProcedure.Parameters.AddWithValue("@otchestvo", passwordUser);
            storedProcedure.Parameters.AddWithValue("@otchestvo", userRoleID);

            ExecuteStoredProcedure();
        }

        private void SPUsersDelete(Int32 idUser) //Удаление пользователя
        {
            ConfigurationProcedure("users_delete");

            storedProcedure.Parameters.AddWithValue("@ID_user", idUser);

            ExecuteStoredProcedure();
        }

        private void SPUsersLogicalDelete(Int32 idUser) //Логическое удаление пользователя
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

        public void SPDoljUpdate(Int32 idDolj, string doljName, Int32 salary) //Обновление данный о должности
        {
            ConfigurationProcedure("dolj_update");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);
            storedProcedure.Parameters.AddWithValue("@dolj_name", doljName);
            storedProcedure.Parameters.AddWithValue("@salary", salary);

            ExecuteStoredProcedure();
        }

        private void SPDoljDelete(Int32 idDolj) //Удаление должности
        {
            ConfigurationProcedure("dolj_delete");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);

            ExecuteStoredProcedure();
        }

        private void SPDoljLogicalDelete(Int32 idDolj) //Логическое удаление должности
        {
            ConfigurationProcedure("dolj_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_dolj", idDolj);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Сотрудники
        public void SPEmployeeInsert(string secondName, string firstName, string otchestvo, string dateBirth, 
            Int32 numUdostov, string nameUchilisha, string dateOkonch, string login, string password) //Добавление сотрудника
        {
            ConfigurationProcedure("employee_insert");

            storedProcedure.Parameters.AddWithValue("@second_name", secondName);
            storedProcedure.Parameters.AddWithValue("@first_name", firstName);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);
            storedProcedure.Parameters.AddWithValue("@date_birth", dateBirth);
            storedProcedure.Parameters.AddWithValue("@num_udostov", numUdostov);
            storedProcedure.Parameters.AddWithValue("@name_uchilisha", nameUchilisha);
            storedProcedure.Parameters.AddWithValue("@date_okonch", dateOkonch);
            storedProcedure.Parameters.AddWithValue("@login", login);
            storedProcedure.Parameters.AddWithValue("@password", password);

            ExecuteStoredProcedure();
        }

        public void SPEmployeeUpdate(Int32 idEmployee, string secondName, string firstName, string otchestvo, string dateBirth, 
            Int32 numUdostov, string nameUchilisha, string dateOkonch, string login, string password) //Обновление данный о сотруднике
        {
            ConfigurationProcedure("employee_update");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);
            storedProcedure.Parameters.AddWithValue("@second_name", secondName);
            storedProcedure.Parameters.AddWithValue("@first_name", firstName);
            storedProcedure.Parameters.AddWithValue("@otchestvo", otchestvo);
            storedProcedure.Parameters.AddWithValue("@date_birth", dateBirth);
            storedProcedure.Parameters.AddWithValue("@num_udostov", numUdostov);
            storedProcedure.Parameters.AddWithValue("@name_uchilisha", nameUchilisha);
            storedProcedure.Parameters.AddWithValue("@date_okonch", dateOkonch);
            storedProcedure.Parameters.AddWithValue("@login", login);
            storedProcedure.Parameters.AddWithValue("@password", password);

            ExecuteStoredProcedure();
        }

        private void SPEmployeeDelete(Int32 idEmployee) //Удаление сотрудника
        {
            ConfigurationProcedure("employee_delete");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);

            ExecuteStoredProcedure();
        }

        private void SPEmployeeLogicalDelete(Int32 idEmployee) //Логическое удаление сотрудника
        {
            ConfigurationProcedure("employee_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_employee", idEmployee);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Поезда
        public void SPTrainInsert(Int32 numTrain, Int32 kol_voWagon, Int32 machEmployee, Int32 stewardEmployee) //Добавление поезда
        {
            ConfigurationProcedure("train_insert");

            storedProcedure.Parameters.AddWithValue("@num_train", numTrain);
            storedProcedure.Parameters.AddWithValue("@kol_vo_wagon", kol_voWagon);
            storedProcedure.Parameters.AddWithValue("@mach_employee_id", machEmployee);
            storedProcedure.Parameters.AddWithValue("@steward_employee_id", stewardEmployee);

            ExecuteStoredProcedure();
        }

        public void SPTrainUpdate(Int32 idTrain, Int32 numTrain, Int32 kol_voWagon, Int32 machEmployee, Int32 stewardEmployee) //Обновление данный о поезде
        {
            ConfigurationProcedure("train_update");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);
            storedProcedure.Parameters.AddWithValue("@num_train", numTrain);
            storedProcedure.Parameters.AddWithValue("@kol_vo_wagon", kol_voWagon);
            storedProcedure.Parameters.AddWithValue("@mach_employee_id", machEmployee);
            storedProcedure.Parameters.AddWithValue("@steward_employee_id", stewardEmployee);

            ExecuteStoredProcedure();
        }

        private void SPTrainDelete(Int32 idTrain) //Удаление поезда
        {
            ConfigurationProcedure("train_delete");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);

            ExecuteStoredProcedure();
        }

        private void SPTrainLogicalDelete(Int32 idTrain) //Логическое удаление поезда
        {
            ConfigurationProcedure("train_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_train", idTrain);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Билет
        public void SPTicketInsert(Int32 numTicket, string timeRegisry, string timeDeparture, string dateDeparture, 
            Int32 price, Int32 place, Int32 passengerID, Int32 employeeID, Int32 routeID) //Добавление билета
        {
            ConfigurationProcedure("ticket_insert");

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

        public void SPTicketUpdate(Int32 idTicket, Int32 numTicket, string timeRegisry, string timeDeparture, string dateDeparture, 
            Int32 price, Int32 place, Int32 passengerID, Int32 employeeID, Int32 routeID) //Обновление данный о билетt
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

        private void SPTicketDelete(Int32 idTicket) //Удаление билета
        {
            ConfigurationProcedure("ticket_delete");

            storedProcedure.Parameters.AddWithValue("@ID_ticket", idTicket);

            ExecuteStoredProcedure();
        }

        private void SPTicketLogicalDelete(Int32 idTicket) //Логическое удаление билета
        {
            ConfigurationProcedure("ticket_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_ticket", idTicket);

            ExecuteStoredProcedure();
        }

        private void ExecuteStoredProcedure() //Выполнение процедуры
        {
            try
            {
                RegistryData.DBConnectionString.Open();
                RegistryData.DBConnectionString.InfoMessage += MessageInformation;
            }
            catch (SqlException ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }

        private void MessageInformation(object sender, SqlInfoMessageEventArgs e) //Сообщение об ошибке
        {
            RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() +" " + e.Message;
        }
    }
}
