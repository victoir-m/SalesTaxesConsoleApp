using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesDal.Models
{
    public class ItemsModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public bool IsImported { get; set;}
        public bool IsTaxable { get; set;}
    }
}
