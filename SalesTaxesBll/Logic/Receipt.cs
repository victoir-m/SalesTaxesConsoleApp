using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Logic
{
    public class Receipt : IReceipt
    {
        public string GenerateReceipt(List<ReceiptDto> receipt)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine("");
            sb.AppendLine("Sales Receipt: ");
            sb.AppendLine("");
            foreach (ReceiptDto item in receipt)
            {
                sb.AppendLine($"{item.Quantity} {item.ItemName}: {item.Price}");
            }
            sb.AppendLine("");
            sb.AppendLine($"Sales Taxes: {Math.Round(receipt.Sum(x => x.SalesTaxes), 2)}");
            sb.AppendLine($"Sales Total: {Math.Round(receipt.Sum(x => x.Price),2)}");
            sb.AppendLine("");
            sb.AppendLine("--------------------------------------------------");
           
            return sb.ToString();
        }
    }
}
