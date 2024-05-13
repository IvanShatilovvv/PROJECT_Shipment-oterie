using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows;

namespace ShipmentСoterie.Tables
{
    public class CoterieContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Shop> shop { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Profile> profile { get; set; }
        public DbSet<ProductType> productType { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<PayMethod> payMethod { get; set; }
        public DbSet<OrderStatus> orderStatus { get; set; }
        public DbSet<OrderList> orderList { get; set; }
        public DbSet<Order> order { get; set; }

        public CoterieContext()
        {
            try
            {
                Database.EnsureCreated();
                WeNeedMoreData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WeNeedMoreData()
        {
            if((this.productType.Where(x=>x.name== "restore type 1").ToList().Count > 0) &
                (this.role.Where(x=>x.name=="admin").ToList().Count ) > 0 &
                this.orderStatus.Where(x=>x.name=="Создан").ToList().Count > 0 &
                this.payMethod.Where(x=>x.name == "Наличными при получении").ToList().Count > 0 &
                this.profile.Where(x=>x.firstName=="admin").ToList().Count > 0 &
                this.user.Where(x=>x.login == "1").ToList().Count > 0)
            {

            }
            else
            {
                this.productType.AddRange(
                    new ProductType() { name="restore type 1" },
                    new ProductType() { name="restore type 2" },
                    new ProductType() { name="restore type 3" },
                    new ProductType() { name="restore type 4" }
                    );
                this.role.AddRange(
                    new Role() { name="admin" },
                    new Role() { name="manager" },
                    new Role() { name="client" }
                    );
                this.orderStatus.AddRange(
                    new OrderStatus() { name= "Создан" },
                    new OrderStatus() { name= "Оплачен" },
                    new OrderStatus() { name= "Завершен" }
                    );
                this.payMethod.AddRange(
                    new PayMethod() { name= "Наличными при получении" },
                    new PayMethod() { name= "Картой при получении" },
                    new PayMethod() { name= "Картой онлайн" }
                    );

                this.SaveChanges();

                var tempProf = new Profile() { adres = "city, street,", age = 0, firstName = "admin" };
                this.profile.AddRange(
                    tempProf
                    );

                this.SaveChanges();

                this.user.AddRange(
                    new User() { login="1", password="1", email="", roleId=1, profile=tempProf }
                    );

                this.SaveChanges();
            }

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                SqlConnectionStringBuilder str = new() { DataSource = "localhost", UserID = "", Password = "", InitialCatalog = "coterie", TrustServerCertificate = true };
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetConnectionString()
        {
            //  default connectiong string:
            string defStr = "Data Source=localhost;Initial Catalog=coterie;Integrated Security=True;User ID=;Password=;Trust Server Certificate=True";
            string fileName = "connectionString.txt";
            string result = "";
            try
            {
                if (File.Exists(fileName))
                {
                    result = ReadString(fileName);
                }
                else
                {
                    FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(defStr);
                    sw.Close();

                    StreamReader sr = new StreamReader(fs);
                    result = sr.ReadToEnd();

                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return result;
        }

        string ReadString(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            return sr.ReadToEnd();
        }
    }
}
