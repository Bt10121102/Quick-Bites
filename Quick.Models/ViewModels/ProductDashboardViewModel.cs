
namespace Quick.Models
{
    public class ProductDashboardViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public List<Product> ProductsStarters { get; set; }
        public List<Product> ProductsBevereges { get; set; }
        public List<Product> ProductsSalads { get; set; }
        public List<Product> ProductsSandwiches { get; set; }
        public List<Product> ProductsBurgers { get; set; }
        public List<Product> ProductsPasta { get; set; }
        public List<Product> ProductsDessert { get; set; }



        public int? SelectedCategoryId { get; set; }
    }

}

