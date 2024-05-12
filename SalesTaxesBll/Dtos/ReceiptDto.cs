using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Dtos
{
    public class ReceiptDto
    {
        public int Quantity { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal SalesTaxes { get; set; }
    }
}
