using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Products
{
    public class ProductTypesAppService : IProductTypesAppService
    {
        private readonly IRepository<ProductType> _productTypeRepository;

        public ProductTypesAppService(IRepository<ProductType> productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }

        public List<ProductType> GetAll(GetAllProductTypeInput input)
        {
            var productTypes = _productTypeRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                productTypes = productTypes.Where(x => x.Name.ToLower().Trim().Contains(input.Filter) || x.Code.ToLower().Trim().Contains(input.Filter));
            }

            return productTypes.ToList();
        }

        public ProductType GetById(int id)
        {
            return _productTypeRepository.GetById(id);
        }

        public void Insert(ProductType productType)
        {
            _productTypeRepository.Insert(productType);
        }

        public void Update(ProductType productType)
        {
            _productTypeRepository.Update(productType);
        }

        public void Delete(ProductType productType)
        {
            _productTypeRepository.Delete(productType);
        }
    }
}
