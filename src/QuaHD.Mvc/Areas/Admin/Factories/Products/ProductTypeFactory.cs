using AutoMapper;
using QuaHD.Application.Products;
using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Products;

namespace QuaHD.Mvc.Areas.Admin.Factories.Products
{
    public class ProductTypeFactory : IProductTypeFactory
    {
        private readonly IProductTypesAppService _productTypesAppService;
        private readonly IMapper _mapper;

        public ProductTypeFactory(IProductTypesAppService productTypesAppService, IMapper mapper)
        {
            _productTypesAppService = productTypesAppService;
            _mapper = mapper;
        }

        public ProductTypeViewModel PrepareProductTypeViewModel(ProductTypeSearchModel searchModel)
        {
            var productTypes = _productTypesAppService.GetAll(_mapper.Map<GetAllProductTypeInput>(searchModel));

            return new ProductTypeViewModel
            {
                SearchModel = searchModel,
                ProductTypeModels = new Page<ProductTypeModel>(_mapper.Map<List<ProductTypeModel>>(productTypes), searchModel)
            };
        }

        public ProductTypeModel PrepareProductTypeModel(ProductType? productType)
        {
            var model = new ProductTypeModel();
            if (productType != null)
            {
                model = _mapper.Map<ProductTypeModel>(productType);
            }

            return model;
        }
    }
}
