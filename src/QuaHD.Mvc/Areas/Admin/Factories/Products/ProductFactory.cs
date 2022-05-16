using AutoMapper;
using QuaHD.Application.Products;
using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Products;

namespace QuaHD.Mvc.Areas.Admin.Factories.Products
{
    public class ProductFactory : IProductFactory
    {
        private readonly IProductsAppService _productsAppService;
        private readonly IMapper _mapper;

        public ProductFactory(IProductsAppService productsAppService, IMapper mapper)
        {
            _productsAppService = productsAppService;
            _mapper = mapper;
        }

        public ProductViewModel PrepareProductViewModel(ProductSearchModel searchModel)
        {
            var products = _productsAppService.GetAll(_mapper.Map<GetAllProductInput>(searchModel));

            return new ProductViewModel
            {
                SearchModel = searchModel,
                ProductModels = new Page<ProductModel>(_mapper.Map<List<ProductModel>>(products), searchModel)
            };
        }

        public ProductModel PrepareProductModel(Product? product)
        {
            var model = new ProductModel();
            if (product != null)
            {
                model = _mapper.Map<ProductModel>(product);
            }

            return model;
        }
    }
}
