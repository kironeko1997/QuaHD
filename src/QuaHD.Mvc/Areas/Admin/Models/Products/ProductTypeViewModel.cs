namespace QuaHD.Mvc.Areas.Admin.Models.Products
{
    public class ProductTypeViewModel
    {
        public ProductTypeViewModel()
        {
            SearchModel = new ProductTypeSearchModel();
            ProductTypeModels = new Page<ProductTypeModel>();
        }

        public ProductTypeSearchModel SearchModel { get; set; }

        public Page<ProductTypeModel> ProductTypeModels { get; set; }
    }
}
