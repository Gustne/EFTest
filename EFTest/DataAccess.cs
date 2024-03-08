
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFTest
{
    internal class DataAccess
    {
    }

    public class Item
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return $"Navn: {this.Name} Beskrivelse: {this.Description} Lagerstatus: {this.Stock} Pris: {this.Price}";
        }
    }
    public class VareDbContext : DbContext
    {

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstring = ConfigurationManager.ConnectionStrings["BojeSql"].ConnectionString;
            optionsBuilder.UseSqlServer(connstring);
        }
    }
}
