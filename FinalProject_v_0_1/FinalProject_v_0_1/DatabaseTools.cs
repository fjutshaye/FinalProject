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
            connectionString = "server="+server+";user id="+username+";pwd="+pwd+";database="+database+";";
            //DatabaseTools.database = database;
        }
        public static bool singUptUser(string host, string username, string password)
        {
            setConnection("localhost", "admin", "12345678", "finalproject");
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //create user
                cmd.CommandText = "INSERT INTO mysql.user (Host, User, Password) VALUES( @Host, @User, password(@Password))";
                cmd.Parameters.AddWithValue("@Host", host);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@password", password);
                //cmd.Parameters.AddWithValue("@Select_priv", "Y");
                cmd.ExecuteNonQuery();
                //grant
                cmd.CommandText = "GRANT SELECT, UPDATE ON finalproject.* TO '"+username+"'@'"+host+"' identified by '" + password + "'";
                cmd.ExecuteNonQuery();
                //flush
                cmd.CommandText = "flush privileges";
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
            setConnection("localhost", username, pwd, "finalproject");
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
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
        public static bool insertProfile(string username)
        {
            setConnection("localhost", "admin", "12345678", "finalproject");
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USER_PROFILE(username,name)VALUES(@username,@name)";
                cmd.Parameters.AddWithValue("@username", username);
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
                cmd.CommandText = "select * from user_profile where username=\'" + username + "\'";
                MySqlDataReader reader = cmd.ExecuteReader();
                //return new string[1] { "succeeded" };
                object[] result = new object[6];
                if (reader.Read())
                {
                    for(int i = 0; i < result.Length; i++)
                    {
                        object temp = reader.GetValue(i);
                        result[i] = temp;
                        //if(temp == null)
                        //{
                        //    result[i] = "Null";
                        //}else
                        //{
                        //    result[i] = temp;
                        //}
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
        public static bool updateProfile(string username, string email, string name, string phone, string carInfo)
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
                cmd.CommandText = "UPDATE user_profile SET email=\'"+email+"\',name=\'"+name+"\',phoneNumber=\'"+phone+"\',carInfo=\'"+carInfo
                    +"\' WHERE username=\'"+username+"\';";
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
        public static bool insertRequest(string requestId, string username, string destination, DateTime dateTime, int numberOfPassenger, string description)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connected");
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO request(requestId,username,destination,dateTime,numberOfPassenger,description)VALUES(@requestId,@username,@destination,@dateTime,@numberOfPassenger,@description)";
                cmd.Parameters.AddWithValue("@requestId", requestId);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@dateTime", dateTime);
                cmd.Parameters.AddWithValue("@numberOfPassenger", numberOfPassenger);
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