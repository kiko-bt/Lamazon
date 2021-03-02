using SEDC.Lamazon.WebModels.Enum;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public CategoryTypeViewModel Category { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }
}
