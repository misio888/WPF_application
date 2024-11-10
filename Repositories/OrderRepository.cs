using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data;
using System.Windows.Markup;
using System.Collections;

namespace WpfApp1.Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        private static readonly string _dbFilePath = Path.Combine("C:\\Users\\Misio", "dbOrders.db");
        private static readonly string _connectionString = $"Data Source = {_dbFilePath}";
        public bool Create(Order entity)
        {
            bool isCreated = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = $"INSERT INTO Orders(Name, Price, Count, Image) VALUES('{entity.Name}', '{entity.Price}', '{entity.Count}', @Image)";
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
#pragma warning disable CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
                dbCommand.Parameters.Add("@Image", SqliteType.Blob, entity.Image.Length).Value = entity.Image;  
#pragma warning restore CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
                if (dbCommand.ExecuteNonQuery() == 1)
                    isCreated = true;
            }
            dbConnection.Close();
            return isCreated;
        }
        public List<Order> ReadAll()
        {
            List<Order> placeList = new List<Order>();
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = string.Format("SELECT * FROM Orders");
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                SqliteDataReader dbDataReader = dbCommand.ExecuteReader();
                while (dbDataReader.Read())
                {
                    Order place = new Order()
                    {
                        Id = Convert.ToInt32(dbDataReader["Id"]),
                        Name = dbDataReader["Name"].ToString(),
                        Price = dbDataReader["Price"].ToString(),
                        Count = dbDataReader["Count"].ToString(),
                        Image = (byte[])dbDataReader["Image"],
                    };
                    placeList.Add(place);
                }
            }
            dbConnection.Close();
            return placeList;
        }
        public Order Read(int Id)
        {
            Order place = new Order();
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = string.Format($"SELECT * FROM Orders Where Id = {Id}");
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                SqliteDataReader dbDataReader = dbCommand.ExecuteReader();
                while (dbDataReader.Read())
                {
                    place = new Order()
                    {
                        Id = Convert.ToInt32(dbDataReader["Id"]),
                        Price = dbDataReader["Price"].ToString(),
                        Count = dbDataReader["Count"].ToString(),
                        Image = (byte[])dbDataReader["Image"],
                    };
                }
            }
            dbConnection.Close();
            return place;
        }
        public bool Update(Order entity)
        {
            bool isUpdated = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = $"SELECT COUNT(Id) FROM Orders WHERE Id = {entity.Id}";
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                int result = Convert.ToInt32(dbCommand.ExecuteScalar());
                if (result == 1)
                {
                    dbQuery = $"UPDATE Orders SET Count = '{entity.Count}', Price = '{entity.Price}', Image = @Image WHERE Id = {entity.Id}";
                    dbCommand.CommandText = dbQuery;
#pragma warning disable CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
                    dbCommand.Parameters.Add("@Image", SqliteType.Blob, entity.Image.Length).Value = entity.Image;
#pragma warning restore CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
                    if (dbCommand.ExecuteNonQuery() == 1)
                    {
                        isUpdated = true;
                    }
                }
            }
            dbConnection.Close();
            return isUpdated;
        }
        public bool Delete(Order entity)
        {
            bool isDeleted = false;
            SqliteConnection dbConnection = new SqliteConnection(_connectionString);
            dbConnection.Open();
            if (dbConnection.State == ConnectionState.Open)
            {
                string dbQuery = $"SELECT COUNT(Id) FROM Orders WHERE Id = {entity.Id}";
                SqliteCommand dbCommand = new SqliteCommand(dbQuery, dbConnection);
                int result = Convert.ToInt32(dbCommand.ExecuteScalar());
                if (result == 1)
                {
                    dbQuery = $"DELETE FROM Orders WHERE Id = {entity.Id}";
                    dbCommand.CommandText = dbQuery;
                    if (dbCommand.ExecuteNonQuery() == 1)
                    {
                        isDeleted = true;
                    }
                }
            }
            dbConnection.Close();
            return isDeleted;
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
