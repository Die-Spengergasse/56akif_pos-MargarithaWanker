using Microsoft.EntityFrameworkCore;
using Spg_Shopify.Domain.Model;
using Spg.Shopify.Infrastructure;

DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
optionsBuilder.UseSqlite("Data Source=SpengerShop_Test.db");

ShopifyContext db = new ShopifyContext(optionsBuilder.Options);
db.Database.EnsureDeleted();
db.Database.EnsureCreated();
db.Seed();

// Alle Customer deren Vorname mit t'M' beginnt
List<Customer> result01 = db.Customers
    .Where(c => c.FirstName.StartsWith("A")).ToList();

// Gib den Customer mit der ID 12 zurück
var result02 = db.Customers
    .SingleOrDefault(c => c.Id == 12);

// Gib alle Customers zurück, die noch kein LastChangeDate haben.
var result03 = db.Customers
    .Count(c => !c.LastChangeDate.HasValue);

// Gib alle Customers zurück, deren Vorname mit 'H' beginnt und die nach '01.01.2000' geboren wurden.
var result04 = db.Customers.Where(c =>
    c.FirstName.StartsWith("H") && c.BirthDate > new DateTime(2000, 01, 01));

// Liste alle Products auf, mit dem PriceType ShortName='Normal'
var result05 = db.Items
    .Where(p => p.Prices
        .Any(p => p.CatPriceTypeNavigation.ShortName == "Normal"));

// Liste aller Customers, die das Produckt 'Awesome Cotton Shoes' gekauft haben.
var result06 = db.Customers
    .Include(c => c.ShoppingCarts
        .Where(s => s.ShoppingCartItems
            .Any(i => i.ItemNavigation.Name == "Awesome Cotton Shoes")));

Console.Read();