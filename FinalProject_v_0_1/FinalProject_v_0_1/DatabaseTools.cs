using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest1
{
    static class DatabaseTools
    {
        private static string connectionString;
        private static MySqlConnection connection;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adapter;
        private static DataSet dataSet;
        //private static string database;

        public static void setConnection(string server, string username, string pwd, string database)
        {
            connectionString = "server="+server+";user id="+username+";database="+database+";";
            //DatabaseTools.database = database;
        }

        /// <summary>
        /// This method creates an account in the table "account".
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userId"></param>
        public static bool insertUser(string username, string password)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ACCOUNT(username,password)VALUES(@username,@password)";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database Disconnected");
                }
            }
        }
        public static bool validateAccount(string username, string pwd)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from account where username=\'"+username+"\' and password=\'"+pwd+"\'";
                //int result = cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("valid username and password");
                    return true;
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database Disconnected");
                }
            }
        }
        public static void insertProfile()
        {

        }
    }
}
