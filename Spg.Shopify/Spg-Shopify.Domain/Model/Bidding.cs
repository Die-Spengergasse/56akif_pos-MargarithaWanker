using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class Bidding
    {
        //public int Id { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; } = string.Empty;
        public Customer CustomerNavigation { get; set; } = default!;

    }
}
