using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetGui.sql.entities
{
    public class Commodity
    {
        public int itemId { get; set; }
        public int sellerId { get; set; }
        public int? buyerId { get; set; }
        public DateTime? postDate { get; set; }
        public DateTime? purchaseDate { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal itemPrice { get; set; }
        public string photoUrl { get; set; }
        public decimal? rating { get; set; }
        public string currencyType { get; set; }
        public decimal? amount { get; set; }
    }
  
}
