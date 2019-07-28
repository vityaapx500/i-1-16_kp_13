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
        public DataTable DTEmployee = new DataTable("emplouee");
        public DataTable DTTrain = new DataTable("train");
        public DataTable DTRoute = new DataTable("route");
        public DataTable DTPlaceStatus = new DataTable("place_status");
        public DataTable DTTicket = new DataTable("ticket");
        public string QRPlaceStatus = "select * from [dbo].[place_status]";
        public string QRRoles = "select * from [dbo].[roles] where [role_logical_delete] = 0";
        public string QRUsers = "select * from [dbo].[users] where [user_logical_delete] = 0";
        public string QRDolj = "select * from [dbo].[dolj] where [dolj_logical_delete] = 0";
        public string QREmployee = "select [second_name] + ' ' + [first_name] + ' ' + [otchestvo] as [FIO_Employee], [date_birth], " +
            "[num_udostov], [name_uchilisha], [date_okonch], [login], [password], [dolj_id], [dolj_name] from [dbo].[employee] " +
            "inner join [dbo].[dolj] on [dbo].[employee].[dolj_id] = [dbo].[dolj].[ID_dolj] where [dbo].[dolj].[dolj_logical_delete] = 0";
        public string QRTrain = ""

    }
}
