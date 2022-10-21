using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public List<ShoppingCart> ShoppingCarts { get; set; } = new();
        public Customer CustomerNavigation { get; set; } = default!;
        public Item Item { get; set; } = default!;

    }

}
