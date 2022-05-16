namespace QuaHD.Mvc.Areas.Admin.Models.Products
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            SearchModel = new ProductSearchModel();
            ProductModels = new Page<ProductModel>();
        }

        public ProductSearchModel SearchModel { get; set; }

        public Page<ProductModel> ProductModels { get; set; }
    }
}
