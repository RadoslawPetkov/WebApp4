using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Contracts
{
    public interface IProductService
    {
        bool Create(string name, int brandId, int categoruId, string picture, int quantity, decimal price, decimal discount);
        bool Update(int productId, string name, int brandId, int categoruId, string picture, int quantity, decimal price, decimal discount);
        List<Product> GetProducts();
        Product GetPRoductById(int productId);
        bool RemoveById(int dogproductId);
        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);
    }
}
