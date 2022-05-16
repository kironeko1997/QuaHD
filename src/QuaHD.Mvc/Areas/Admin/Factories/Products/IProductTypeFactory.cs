using QuaHD.Core.Entities.Products;
using QuaHD.Mvc.Areas.Admin.Models.Products;

namespace QuaHD.Mvc.Areas.Admin.Factories.Products
{
    public interface IProductTypeFactory
    {
        ProductTypeViewModel PrepareProductTypeViewModel(ProductTypeSearchModel searchModel);

        ProductTypeModel PrepareProductTypeModel(ProductType? productType);
    }
}
