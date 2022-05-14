using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Products
{
    public class ProductsAppService : IProductsAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll(GetAllProductInput input)
        {
            var products = _productRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                products = products.Where(x => x.Name.ToLower().Trim().Contains(input.Filter.ToLower().Trim()) || x.Code.ToLower().Trim().Contains(input.Filter.ToLower().Trim()) || x.Description.ToLower().Trim().Contains(input.Filter.ToLower().Trim()));
            }

            if (input.ProductTypeId.HasValue)
            {
                products = products.Where(x => x.ProductTypeId == input.ProductTypeId);
            }

            if (input.CourseLink.HasValue)
            {
                products = products.Where(x => x.CourseId.HasValue == input.CourseLink);

                if (input.CourseId.HasValue)
                {
                    products = products.Where(x => x.CourseId == input.CourseId);
                }
            }

            if (input.IsPublished.HasValue)
            {
                products = products.Where(x => x.IsPublished == input.IsPublished);
            }

            return products.ToList();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
