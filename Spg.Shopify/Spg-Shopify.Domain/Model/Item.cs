using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public int Weight { get; set; }
        public int Price { get; set; }
        public string Material { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public Category CategoryNavigation { get; set; } = default!;
    }
}
