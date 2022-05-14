using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Products
{
    public interface IProductsAppService
    {
        List<Product> GetAll(GetAllProductInput input);

        Product GetById(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
