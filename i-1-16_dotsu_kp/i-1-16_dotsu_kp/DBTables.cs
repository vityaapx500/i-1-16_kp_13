using System;
using System.Data;
using System.Data.SqlClient;

namespace i_1_16_dotsu_kp
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", RegistryData.DBConnectionString);
        public DataTable DTPassenger = new DataTable("passenger");
        public DataTable DTRoles = new DataTable("roles");
        public DataTable DTUsers = new DataTable("users");
        public DataTable DTDolj = new DataTable("dolj");
        public DataTable DTEmployee = new DataTable("employee");
        public DataTable DTTrain = new DataTable("train");
        public DataTable DTRoute = new DataTable("route");
        public DataTable DTPlaceStatus = new DataTable("place_status");
        public DataTable DTTicket = new DataTable("ticket");
        public string QRPlaceStatus = "select * from [dbo].[place_status]";
        public string QRRoles = "select * from [dbo].[roles] where [role_logical_delete] = 0";
        public string QRUsers = "select * from [dbo].[users] where [user_logical_delete] = 0";
        public string QRDolj = "select * from [dbo].[dolj] where [dolj_logical_delete] = 0";
        public string QRDoljForComboBox = "select D.[ID_dolj], D.[dolj_name] from [dbo].[dolj] D where D.[dolj_logical_delete] = 0";
        public string QREmployee = "select E.[second_name] + ' ' + E.[first_name] + ' ' + E.[otchestvo] as \"Employee FIO\", [date_birth], [num_udostov], [name_uchilisha]" +
            "[date_okonch], [login], [password], [dolj_id], D.[dolj_name] from[dbo].[employeeE" +
            "inner join[dbo].[dolj] D on E.[dolj_id] = D.[ID_dolj] where D.[dolj_logical_delete] = 0" +
            "E.[ID_employee], E.[second_name] +' '+ E.first_name +' '+ E.otchestvo as \"Train driver\" from [train] T " +
            "inner join [employee] E on t.train_driver_id = E.ID_employee where [dbo].[train].[train_logical_delete] = 0";
        public string QRRoute = "select R.[ID_route], R.[num_route], R.[naznach_station], CONVERT([varchar] (5), R.[time_arrival]), CONVERT([varchar] (5), [R].[time_departure])," +
            "T.[ID_train], T.[num_train], T.[kol_vo_wagon], T.[train_driver_id]," +
            "E.[second_name] +' '+ E.[first_name] +' '+ E.[otchestvo] as 'Train driver', R.[price] from[train] T" +
            "inner join[route] R on R.[ID_route] = R.[ID_route]" +
            "inner join [employee] E on t.[train_driver_id] = E.[ID_employee]" +
            "where R.[route_logical_delete] = 0";
        public string QRRouteForComboBox = "select [ID_route], [naznach_station] from [dbo].[route] where [route].route_logical_delete = 0";
        public string QRTicket = "select T.[ID_ticket], T.[num_ticket], T.[time_registry], T.[date_departure], T.[place], T.[place_status_id]," +
            "PS.[name_status], T.[passenger_id], P.[second_name] +' '+P.[first_name]+' '+P.[otchestvo] as \"passenger name\" from[dbo].[ticket] T" +
            "inner join [dbo].[place_status] PS on T.[place_status_id] = PS.[ID_place_status]" +
            "inner join [dbo].[passenger] P on T.[passenger_id] = P.[ID_passenger]" +
            "inner join [dbo].[route] R on  T.[route_id] = R.[ID_route] where T.[ticket_logical_delete] = 0";
        public string QRPassenger = "select * from [dbo].[passenger] where [passenger_logical_delete] = 0";
        public string QRTrain = "select T.[ID_train], T.[num_train], T.[kol_vo_wagon], T.[train_driver_id]," +
            "E.[second_name] +' '+ E.[first_name] +' '+ E.[otchestvo] as 'Train driver' from[dbo].[train] T " +
            "inner join[dbo].[employee] E on T.[train_driver_id] = E.[ID_employee] where T.[train_logical_delete] = 0";

        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                //SqlDependency.AddCommandDependency(command);
                //SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                RegistryData.DBConnectionString.Open();
                //CommandOpenKey.ExecuteNonQuery();// Отрытие ключа шифрования
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }
        public void DTPlaceStatusFill()
        {
            DataTableFill(DTPlaceStatus, QRPlaceStatus);
        }
        public void DTRolesFill()
        {
            DataTableFill(DTRoles, QRRoles);
        }
        public void UsersFill()
        {
            DataTableFill(DTUsers, QRUsers);
        }
        public void DTPassengerFill()
        {
            DataTableFill(DTPassenger, QRPassenger);
        }
        public void DTDoljFill()
        {
            DataTableFill(DTDolj, QRDolj);
        }
        public void DTEmployeeFill()
        {
            DataTableFill(DTEmployee, QREmployee);
        }
        public void DTRouteFill()
        {
            DataTableFill(DTRoute, QREmployee);
        }
        public void DTTicketFill()
        {
            DataTableFill(DTTicket, QRTicket);
        }
        public void DTTrainFill()
        {
            DataTableFill(DTTrain, QRTrain);
        }
    }
}
