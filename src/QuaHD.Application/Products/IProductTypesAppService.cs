using QuaHD.Application.Shared.Products;
using QuaHD.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Products
{
    public interface IProductTypesAppService
    {
        List<ProductType> GetAll(GetAllProductTypeInput input);

        ProductType GetById(int id);

        void Insert(ProductType productType);

        void Update(ProductType productType);

        void Delete(ProductType productType);
    }
}
