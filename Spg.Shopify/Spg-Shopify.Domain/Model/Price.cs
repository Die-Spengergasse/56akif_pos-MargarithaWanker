using Spg_Shopify.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg_Shopify.Domain.Model
{
    public class Price : EntityBase
    {
        public decimal Nett { get; set; }
        public int Tax { get; set; }
        public decimal Gross { get { return Nett * ((Tax / 100) + 1); } }


        public virtual Item ItemNavigation { get; private set; } = null!;
        public int CatPriceTypeNavigationId { get; set; }
        public virtual CatPriceType CatPriceTypeNavigation { get; private set; } = null!;

        protected Price() { }
        public Price(decimal nett, int tax, Item itemNavigation, CatPriceType catPriceType)
        {
            Nett = nett;
            Tax = tax;
            ItemNavigation = itemNavigation;
            CatPriceTypeNavigation = catPriceType;
        }
    }
}