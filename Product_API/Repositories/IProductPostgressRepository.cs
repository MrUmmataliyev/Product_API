using Npgsql;
using Product_API.Models;

namespace Product_API.Repositories
{

    public class ProductPostgressRepository : IProductRepository
    {
       public string connectionString = "Host=localhost;Port=5432;Database=postgres;User Id=postgres;Password=7257320;";

      

    public Product Add(Product product)
        {
            //using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            //{

            //    connection.Open();
            //    string query = @$"insert into products(Name,Description,PhotoPath) values ('{product.Name}','{product.Description}','{product.PhotoPath}');";
            //        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            //        var reader = cmd.ExecuteNonQuery();

            //}
            return product;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            //using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            //{

            //    connection.Open();
            //    string query = @$"select * from products ";
                 Product product = new Product();
            //        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            //        var reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            product.Name = reader.GetString(0);
            //            product.Description = reader.GetString(1);
            //            product.PhotoPath = reader.GetString(2);
            //            products.Add(product);
            //        }

              
               return products;
            //}
        }
    }
}
