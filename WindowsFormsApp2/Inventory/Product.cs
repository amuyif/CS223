using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory
{
    internal class Product
    {
        private static List<Product> products = new List<Product>();
        public string itemName { get; set; }
        public int number { get; set; }
        public DateTime date { get; set; }
        public int inventoryNumber { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public void save()
        {
            try
            {
                string query = "INSERT INTO Product values('" +this.itemName + "', " + this.number + ", '" + this.date + "', " + this.inventoryNumber + "," + this.count + ", " + this.price + ")";
                SqlCommand cmd = new SqlCommand(query, Conn());
                int rowaff = cmd.ExecuteNonQuery();
                Conn().Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            products.Add(this);

        }
        public static List<Product> getAll()
        {
            string query = "SELECT * FROM Product";
            try
            {
                products.Clear();
                SqlCommand cmd = new SqlCommand(query, Conn());
                var result = cmd.ExecuteReader();
                while(result.Read())
                {
                    Product p = new Product();
                    p.itemName = result[0].ToString();
                    p.number = int.Parse(result[1].ToString());
                    p.date = DateTime.Parse(result[2].ToString());
                    p.inventoryNumber = int.Parse(result[3].ToString());
                    p.count = int.Parse(result[4].ToString());
                    p.price = double.Parse(result[5].ToString());
                    products.Add(p);
                }
                Conn().Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return products;
        }
        public bool isAvail { get; set; }
        public static Product findOne (string name)
        {
            return products.Find(p => p.itemName == name);
        }
        public static Product findInvent(int id)
        {
            return products.Find(p => p.inventoryNumber == id);
        }
        public static SqlConnection Conn()
        {
            string path = @"Data Source = LAPTOP-NS88HFGR\SQLEXPRESS; Initial Catalog = Inventory; Integrated Security = true";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            return con;
        }
    
    }
}
