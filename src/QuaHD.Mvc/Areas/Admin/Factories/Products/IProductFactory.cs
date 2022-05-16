using QuaHD.Core.Entities.Products;
using QuaHD.Mvc.Areas.Admin.Models.Products;

namespace QuaHD.Mvc.Areas.Admin.Factories.Products
{
    public interface IProductFactory
    {
        ProductViewModel PrepareProductViewModel(ProductSearchModel searchModel);

        ProductModel PrepareProductModel(Product? product);
    }
}
