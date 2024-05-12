using SalesTaxesBll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Interfaces
{
    public interface IReceipt
    {
        string GenerateReceipt(List<ReceiptDto> receipt);
    }
}
