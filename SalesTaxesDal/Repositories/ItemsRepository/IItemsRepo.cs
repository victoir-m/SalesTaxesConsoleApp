using SalesTaxesDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesDal.Repositories.ItemsRepository
{
    public interface IItemsRepo
    {
        List<ItemsModel> GetItems();
        ItemsModel? GetItem(int Id);

    }
}
