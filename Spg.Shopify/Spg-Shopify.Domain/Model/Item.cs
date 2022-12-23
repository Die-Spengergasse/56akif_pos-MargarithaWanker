using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class Item
    {
        public string Name { get; private set; } = string.Empty;
        public int Tax { get; set; }
        public string Ean { get; set; } = string.Empty;
        public string? Material { get; set; } = string.Empty;
        public DateTime? ExpiryDate { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public int Weight { get; set; }
        public string Brand { get; set; } = string.Empty;

        private List<ShoppingCartItem> _shoppingCartItems = new();
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;

        protected List<Price> _prices = new();
        public virtual IReadOnlyList<Price> Prices => _prices;

        public int CategoryId { get; set; }
        public virtual Category CategoryNavigation { get; private set; } = default!;

        protected Item() { }
        public Item(string name, int tax, string ean, string? material, DateTime? expiryDate, Category category)
        {
            Name = name;
            Tax = tax;
            Ean = ean;
            Material = material;
            ExpiryDate = expiryDate;
            CategoryNavigation = category;
        }
    }
}
