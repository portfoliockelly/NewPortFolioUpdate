using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Services
{
   
    public class ShopDAO : IShopDataService
    {

        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=PortFolioDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      
        
        public int Delete(shopModel product)
        {
            int newIdNumber = -1;
            string sqlStatemant = "DELETE FROM dbo.Shop WHERE Id = @Id";
            //right click quick actions and install sqlconnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatemant, connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                try
                {
                    connection.Open();
                    newIdNumber = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex) //exeption value is needed to be passed in as ex.
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return newIdNumber;
        }

        public List<shopModel> GetAllProducts()
        {
            List<shopModel> foundProducts = new List<shopModel>();
            string sqlStatemant = "SELECT * From dbo.shop";
            //right click quick actions and install sqlconnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatemant, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new shopModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex) //exeption value is needed to be passed in as ex.
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundProducts;
        }

        public shopModel GetProductById(int id)//get appointments
        {
            shopModel foundProduct = null;
            string sqlStatement = "SELECT * FROM dbo.Shop WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProduct = new shopModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return foundProduct;
        }
        
        

        public int Insert(shopModel product)
        {
            string sqlQuery = "INSERT INTO dbo.Shop VALUES (@Name,  @Price, @Description);select SCOPE_IDENTITY();";
            //right click quick actions and install sqlconnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //command.Parameters.AddWithValue("@Id",product.Id);
                // command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = product.Id;
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = product.Name;
                command.Parameters.Add("@Price", System.Data.SqlDbType.Decimal, 2).Value = product.Price;
                command.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 50).Value = product.Description;

                connection.Open();

                int newId = command.ExecuteNonQuery();

                return product.Id;
            }
        }

        public List<shopModel> SearchProducts(string searchTerm)
        {
            List<shopModel> foundProducts = new List<shopModel>();
            string sqlStatemant = "SELECT * From dbo.Shop WHERE Name LIKE @Name";
            //right click quick actions and install sqlconnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatemant, connection);
                command.Parameters.AddWithValue("@Name", '%' + searchTerm + '%');
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new shopModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex) //exeption value is needed to be passed in as ex.
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundProducts;
        }

        public int Update(shopModel product)
        {
            int newIdNumber = -1;
            string sqlStatemant = "UPDATE dbo.Shop SET Name = @name, Price = @Price, Description = @Description WHERE Id = @Id";
            //right click quick actions and install sqlconnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatemant, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Id", product.Id);
                try
                {
                    connection.Open();
                    newIdNumber = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex) //exeption value is needed to be passed in as ex.
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return newIdNumber;
        }

        List<shopModel> IShopDataService.GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        List<shopModel> IShopDataService.GetProductByUnique(string unique)
        {
            throw new NotImplementedException();
        }
    }
}
