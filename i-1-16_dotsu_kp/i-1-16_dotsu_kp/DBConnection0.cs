using System;
using System.Data;
using System.Data.SqlClient;

namespace i_1_16_dotsu_kp
{
    class DBConnection0
    {
        public static SqlConnection DBConnectionString = new SqlConnection();


        public SqlConnection GetSqlConnection(string dataSource, string initialCatalog, string userID, string password, bool checkSecurity)
        {
            string sqlconnection = $"Data Source = {dataSource}; Initial Catalog = {initialCatalog};" +
                $" Persist Security Info = {checkSecurity};" +
                $"User ID = {userID}; Password = {password}";
            SqlConnection connection = new SqlConnection(sqlconnection);
            return connection;
        }
        public DataSet TableFill(string query, SqlConnection sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}