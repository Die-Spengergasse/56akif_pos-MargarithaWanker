using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class ShoppingCartItem : EntityBase
    {
        public int ShoppingCartNavigationId { get; set; }
        public virtual ShoppingCart ShoppingCartNavigation { get; set; } = default!;
        public int ItemNavigationId { get; set; }
        public virtual Item ItemNavigation { get; set; } = default!;

        protected ShoppingCartItem()
        { }
    }

}
