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
        public static bool insertProfile(string email)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USER_PROFILE(email,name)VALUES(@email,@name)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", "New Comer");
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
        public static object[] queryProfile(string username)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from user_profile where email=\'" + username + "\'";
                MySqlDataReader reader = cmd.ExecuteReader();
                //return new string[1] { "succeeded" };
                object[] result = new object[5];
                if (reader.Read())
                {
                    for(int i = 0; i < 5; i++)
                    {
                        object temp = reader.GetValue(i);
                        if(temp == null)
                        {
                            result[i] = "Null";
                        }else
                        {
                            result[i] = temp;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new string[1] { "failed" };
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
        public static bool updateProfile(string username, string name, string phone, string carInfo)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from user_profile where email=\'" + username + "\'";
                //MySqlDataReader reader = cmd.ExecuteReader();
                //return new string[1] { "succeeded" };
                cmd.CommandText = "UPDATE user_profile SET name=\'"+name+"\',"+"phoneNumber=\'"+phone+"\',carInfo=\'"+carInfo
                    +"\' WHERE email=\'"+username+"\';";
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
        public static bool insertCarpool(string carpoolId, string username, string destination, DateTime dateTime, string carInfo, int capacity, string description)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO carpool(carpoolId,username,destination,dateTime,carInfo,capacity,description)VALUES(@carpoolId,@username,@destination,@dateTime,@carInfo,@capacity,@description)";
                cmd.Parameters.AddWithValue("@carpoolId", carpoolId);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@dateTime", dateTime);
                cmd.Parameters.AddWithValue("@carInfo",carInfo);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.Parameters.AddWithValue("@description", description);

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
    }
}
