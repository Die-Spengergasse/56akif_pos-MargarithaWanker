using Microsoft.EntityFrameworkCore;
using Spg.Shopify.Infrastructure;
using Spg_Shopify.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Shopify.Domain.Test
{
    public class ItemTest
    {
        private ShopifyContext GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=Shopify_Test.db");

            ShopifyContext db = new ShopifyContext(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        [Fact]
        public void SeedDb()
        {
            ShopifyContext db = GenerateDb();
            db.Seed();
            Assert.True(true);
        }

        [Fact]
        public void Product_Add_OneEntity_SuccessTest()
        {
            // AAA
            // 1. Arrange
            ShopifyContext db = GenerateDb();
            Item newItem = new Item("Testitem", 20, "1324567890123", "Material", DateTime.UtcNow.AddDays(14), null);

            // 2. Act
            db.Items.Add(newItem);
            db.SaveChanges();

            // 3. Assert
            Assert.Equal(1, db.Items.Count());
        }
    }
}
