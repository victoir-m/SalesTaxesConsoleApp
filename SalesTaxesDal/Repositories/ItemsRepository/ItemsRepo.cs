using Newtonsoft.Json;
using SalesTaxesDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesDal.Repositories.ItemsRepository
{
    public class ItemsRepo : IItemsRepo
    {
        public List<ItemsModel> GetItems()
        {
            return Items();
        }

        public ItemsModel? GetItem(int Id)
        {
            return Items().FirstOrDefault(x => x.Id == Id);
        }

        private List<ItemsModel> Items()
        {
            try
            {
                string currentDir = Environment.CurrentDirectory;
                string filePath = Path.Combine(currentDir, "Items.json");

                // Read the entire JSON file as a string
                string jsonString = File.ReadAllText(filePath);

                // Deserialize the JSON string
                List<ItemsModel> data = JsonConvert.DeserializeObject<List<ItemsModel>>(jsonString);

                return data;
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
