using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Dtos
{
    public class ReceiptTotalsDto
    {
        public decimal SalesTaxes { get; set; }
        public decimal Total { get; set; }
    }
}
