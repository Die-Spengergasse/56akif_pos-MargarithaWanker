using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class BiddingMetaData
    {
        public string LastModifiedBy { get; set; } = string.Empty;
        public DateTime LastModifiedWhen { get; set; } 
        public string Status { get; set; } = string.Empty;

        
    }
}
