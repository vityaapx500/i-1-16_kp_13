using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace i_1_16_dotsu_kp
{
    class DBConnection1
    {
        public event Action<DataTable> DataTableServers;
        public event Action<DataTable> DataTableDataBases;
        public event Action<bool> ConnectionState;
        public string ConnectionDS, ConnectionUID, ConnectionPassword;
        public static bool LogConnection;
        RegistryData registryData = new RegistryData();

        public void GetServers()
        {
            SqlDataSourceEnumerator sqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance;
            DataTableServers(sqlDataSourceEnumerator.GetDataSources());
        }
        public void GetDataBases()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = " + ConnectionDS + "; Initial Catalog = sa; Persist Security Info = true; " +
                "User ID = " + ConnectionUID + "; Password = \"" + ConnectionPassword + "\"");
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select name from sys.databases where name not in ('master', 'tempdb', 'model', 'msdb')", sqlConnection);
                DataTable dataTable = new DataTable();

                sqlConnection.Open();
                dataTable.Load(sqlCommand.ExecuteReader());
                DataTableDataBases(dataTable);
            }
            catch(Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            } 
        }
        public void CheckConnection()
        {
            registryData.GetRegistry();
            try
            {
                RegistryData.DBConnectionString.Open();
                ConnectionState(true);
                LogConnection = true;
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
                ConnectionState(false);
                LogConnection = false;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }
    }
}
