﻿using System.Data;
using System.Data.SqlClient;

namespace i_1_16_dotsu_kp
{
    class DB
    {
        private const string dataSource = @"ВИКТОР-ПК\VICTOR_SQL",  //Имя сервера
                     initialCatalog = "vokzal_v1",   //Имя базы данных
                     userID = "sa",         //Имя входа
                     password = "123"; //Пароль входа
        private const bool checkSecurity = true; //Проверка подлинности SQl

        public SqlConnection DatabaseSQL()
        {
            SqlConnection sqlConnection = new SqlConnection($"Data Source = {dataSource}; Initial Catalog = {initialCatalog};" +
            $"Persist Security Info = {checkSecurity}; User ID = {userID}; password = \"{password}\"");
            return sqlConnection;
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
