using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", DBConnection.sqlConnection);
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
        public string QRPlaceStatusFormCB = "select [ID_place_status], [name_status] from [dbo].[place_status]";
        public string QRRoles = "select * from [dbo].[roles] where [role_logical_delete] = 0";
        public string QRRolesForComboBox = "select R.[ID_role], [role_name] from [dbo].[roles] R where [role_logical_delete] = 0";
        public string QRUsers = "select * from [dbo].[users] where [user_logical_delete] = 0";
        public string QRDolj = "select * from [dbo].[dolj] where [dolj_logical_delete] = 0";
        public string QRDoljForComboBox = "select D.[ID_dolj], D.[dolj_name] from [dbo].[dolj] D where D.[dolj_logical_delete] = 0";
        public string QREmployee = "select E.[ID_employee], E.[surname], E.[name], E.[pantronymic], [date_birth], " +
            "[num_udostov], [name_uchilisha], [date_okonch], [login], [password], [dolj_id], D.[dolj_name] from [dbo].[employee] E " +
            "inner join [dbo].[dolj] D on E.[dolj_id] = D.[ID_dolj] where D.[dolj_logical_delete] = 0";
        public string QRTrainDriver = "select [ID_employee], [surname] +' '+ [name] +' '+ [pantronymic] as 'Name_Driver' from [dbo].[employee] where dolj_id = 6 and employee.employee_logical_delete = 0";
        public string QRCashier = "select [ID_employee], [surname] +' '+ [name] +' '+ [pantronymic] from [dbo].[employee] where [employee_logical_delete] = 0 and [dolj_id] = 2";
        public string QRRoute = "select R.[ID_route], R.[num_route], R.[naznach_station], CONVERT([varchar] (5), R.[time_arrival]), CONVERT([varchar] (5), [R].[time_departure])," +
            "T.[ID_train], T.[num_train], T.[train_driver_id]," +
            "E.[surname] +' '+ E.[name] +' '+ E.[pantronymic] as 'Train driver', R.[price] from [train] T" +
            "inner join[route] R on R.[ID_route] = R.[ID_route]" +
            "inner join [employee] E on t.[train_driver_id] = E.[ID_employee]" +
            "where R.[route_logical_delete] = 0";
        public string QRRouteR = "select R.[ID_route], R.[num_route], R.[naznach_station], CONVERT([varchar] (5), R.[time_arrival]), CONVERT([varchar] (5), [R].[time_departure])," +
            " T.[ID_train], T.[num_train], T.[kol_vo_wagon], T.[train_driver_id], E.[surname] +' '+ E.[name] +' '+ E.[pantronymic] as 'Train driver', " +
            "R.[price] from[train] T inner join[route] R on R.[ID_route] = R.[ID_route] inner join [employee] E on t.[train_driver_id] = E.[ID_employee] " +
            "where R.[route_logical_delete] = 0";
        public string QRRouteForComboBox = "select [ID_route], [naznach_station] from [dbo].[route] where [route].route_logical_delete = 0";
        public string QRTicket = "select T.[ID_ticket], T.[num_ticket], T.[time_registry], T.[time_departure], T.[date_departure], T.[price], T.[place], T.[place_status_id], " +
            "PS.[name_status], T.[passenger_id], P.[name] +' '+P.[surname]+' '+P.[pantronymic], T.[route_id], R.[num_route], T.[employee_id], E.[surname] +' '+ E.[name] +' '+ E.[pantronymic] from[dbo].[ticket] T " +
            "inner join [dbo].[place_status] PS on T.[place_status_id] = PS.[ID_place_status] inner join [dbo].[passenger] P on T.[passenger_id] = P.[ID_passenger] " +
            "inner join [dbo].[employee] E on T.[employee_id] = E.[ID_employee] inner join [dbo].[route] R on  T.[route_id] = R.[ID_route] " +
            "where T.[ticket_logical_delete] = 0 and [employee_logical_delete] = 0 and [dolj_id] = 2";
        public string QRPassenger = "select * from [dbo].[passenger] where [passenger_logical_delete] = 0";
        public string QRPassengerForComboBox = "select [ID_passenger], [name] +' '+ [surname] +' '+ [pantronymic] from [dbo].[passenger] where [passenger_logical_delete] = 0";
        public string QRTrain = "select T.[ID_train], T.[num_train], T.[kol_vo_wagon], T.[train_driver_id]," +
            "E.[surname] +' '+ E.[name] +' '+ E.[pantronymic] as 'Train driver' from [dbo].[train] T " +
            "inner join[dbo].[employee] E on T.[train_driver_id] = E.[ID_employee] where T.[train_logical_delete] = 0";
        public string QRTrainForCombioBox = "select ID_train, num_train from dbo.train where train_logical_delete = 0";
        public SqlDependency dependency = new SqlDependency();

        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(DBConnection.sqlConnection.ConnectionString);
                DBConnection.sqlConnection.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }
        public void DTPlaceStatusFill()
        {
            DataTableFill(DTPlaceStatus, QRPlaceStatus);
        }
        public void DTPlaceStatusForCB()
        {
            DataTableFill(DTPlaceStatus, QRPlaceStatusFormCB);
        }
        public void DTRolesFill()
        {
            DataTableFill(DTRoles, QRRoles);
        }
        public void DTRolesForComboBoxFill()
        {
            DataTableFill(DTRoles, QRRolesForComboBox);
        }
        public void DTUsersFill()
        {
            DataTableFill(DTUsers, QRUsers);
        }
        public void DTPassengerFill()
        {
            DataTableFill(DTPassenger, QRPassenger);
        }
        public void DTPassengerForComboBoxFill()
        {
            DataTableFill(DTPassenger, QRPassengerForComboBox);
        }
        public void DTDoljFill()
        {
            DataTableFill(DTDolj, QRDolj);
        }
        public void DTDoljForComboBoxFill()
        {
            DataTableFill(DTDolj, QRDoljForComboBox);
        }
        public void DTEmployeeFill()
        {
            DataTableFill(DTEmployee, QREmployee);
        }
        public void DTTrainDriverFill()
        {
            DataTableFill(DTEmployee, QRTrainDriver);
        }
        public void DTCashierFill()
        {
            DataTableFill(DTEmployee, QRCashier);
        }
        public void DTRouteFill()
        {
            DataTableFill(DTRoute, QRRouteR);
        }
        public void DTRouteForComboBoxFill()
        {
            DataTableFill(DTRoute, QRRouteForComboBox);
        }
        public void DTTicketFill()
        {
            DataTableFill(DTTicket, QRTicket);
        }
        public void DTTrainFill()
        {
            DataTableFill(DTTrain, QRTrain);
        }
        public void DTTrainForComboBoxFill()
        {
            DataTableFill(DTTrain, QRTrainForCombioBox);
        }
    }
}