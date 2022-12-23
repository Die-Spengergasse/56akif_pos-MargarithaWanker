using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class Category : EntityBase
    {
        protected Category() { }
        public Category(string name, Shop shop)
        {
            Name = name;
            ShopNavigation = shop;
        }

        public string Name { get; set; }


        public int ShopNavigationId { get; set; }
        public virtual Shop ShopNavigation { get; private set; } = null!;


        protected List<Item> _item = new();
        public virtual IReadOnlyList<Item> Products => _item;
    }
}
