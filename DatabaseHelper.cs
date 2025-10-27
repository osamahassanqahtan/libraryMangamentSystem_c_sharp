using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagementSystem
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=library_db;User ID=root;Password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // تنفيذ استعلام SELECT وإرجاع DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("خطأ في تنفيذ الاستعلام: " + ex.Message);
                }
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("خطأ في تنفيذ الأمر: " + ex.Message);
                }
            }
            return rowsAffected;
        }

        // الحصول على قيمة واحدة من قاعدة البيانات
        public object ExecuteScalar(string query)
        {
            object result = null;
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    result = command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("خطأ في الحصول على القيمة: " + ex.Message);
                }
            }
            return result;
        }
       
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

       

    }
}