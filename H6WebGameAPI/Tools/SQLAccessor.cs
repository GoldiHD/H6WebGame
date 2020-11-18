using H6WebGameAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace H6WebGameAPI.Tools
{
    public class SQLAccessor
    {
        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            SqlConnection connection;
            if(OpenConnection(out connection))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT UserID, Username, Password FROM Account";
                SqlDataReader Reader = command.ExecuteReader();
                while(Reader.Read())
                {
                    users.Add(new User() { userID = Reader.GetString(0), username = Reader.GetString(1), password = Reader.GetString(2) });
                }
            }
            CloseConnection(connection);
            return users;
        }

        public void CreateAccount(User newAccount)
        {
            SqlConnection connection;
            if(OpenConnection(out connection))
            {
                //Create Account
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT into Account " + "(UserID, Username, Password) VALUES('" + Guid.NewGuid() + "','"+newAccount.username + "','" + SingleTon.GetCryptoHashing().HashPassword(newAccount.password)+"')";
                command.ExecuteNonQuery();

                //Create Player
                command = connection.CreateCommand();

                //Write in Chat new user


                //AddItems To player Inventory
                CloseConnection(connection);
            }
        }

        public void AddNewMessage(string UserID, string message)
        {
            SqlConnection connection;
            if (OpenConnection(out connection))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT into Chat " + "(UserID, MessageContent, MessageTime) VALUE('"+UserID+"','"+message+"','"+DateTime.Now+"')";
            }
        }

        public List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            SqlConnection connection;
            if(OpenConnection(out connection))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "";
            }
            CloseConnection(connection);
            return messages;
        }

        public Player GetPlayer(string userid)
        {
            Player player = new Player();
            SqlConnection connection;
            if(OpenConnection(out connection))
            {

            }
            return player;
        }

        private bool OpenConnection(out SqlConnection connection)
        {
            connection = null;
            try
            {
                connection = new SqlConnection(SingleTon.readSetting("DBConnectionString"));
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        private bool CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
