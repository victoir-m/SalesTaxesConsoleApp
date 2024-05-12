
namespace SalesTaxesBll.Dtos
{
    public class ItemsDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public bool IsImported { get; set; }
        public bool IsTaxable { get; set; }
    }
}
