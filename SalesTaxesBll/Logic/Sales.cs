using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Logic
{
    public class Sales : ISales
    {
        private readonly IReceipt _receipt;
        private readonly IGoods _goods;

        public Sales(IReceipt receipt, IGoods goods)
        {
            _receipt = receipt;
            _goods = goods;
        }

        public string Sale(List<BasketDto> items)
        {
            List<ReceiptDto> receiptItems = new List<ReceiptDto>();
            ReceiptTotalsDto totals = new ReceiptTotalsDto();

            foreach (var item in items)
            {
                var res = _goods.GetGood(item.Id);

                if(res != null)
                {
                    if (res.IsImported)
                    {
                        var receiptItem = ImportedItemsPriceCalculations(res, item.Quantity);
                        receiptItems.Add(receiptItem);
                    }

                    if (!res.IsImported)
                    {
                        var recItem = ItemsPriceCalculations(res, item.Quantity);
                        receiptItems.Add(recItem);
                    }
                }
            }

            return _receipt.GenerateReceipt(receiptItems);
        }

        private ReceiptDto ImportedItemsPriceCalculations(ItemsDto item, int quantity) 
        {
            ReceiptDto receipt = new ReceiptDto();

            receipt.Quantity = quantity;
            receipt.ItemName = item.ItemName;

            decimal taxPercentage = item.IsTaxable && item.IsImported ? 15M : 5M;

            var salesTax = (item.Price * quantity) * (taxPercentage / 100M);

            var price = (item.Price * quantity) + salesTax;

            receipt.Price = Math.Round(price,2);
            receipt.SalesTaxes = Math.Round(salesTax,2);

            return receipt;
            
        }

        private ReceiptDto ItemsPriceCalculations(ItemsDto item, int quantity)
        {
            ReceiptDto receipt = new ReceiptDto();

            receipt.Quantity = quantity;
            receipt.ItemName = item.ItemName;

            var salesTax = item.IsTaxable ? ((item.Price * quantity) * (10M / 100M)) : 0M;

            var price = (item.Price * quantity) + salesTax;

            receipt.Price = Math.Round(price,2);
            receipt.SalesTaxes = Math.Round(salesTax,2);

            return receipt;

        }
    }
}
