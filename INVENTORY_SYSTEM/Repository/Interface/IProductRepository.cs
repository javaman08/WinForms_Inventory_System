using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INVENTORY_SYSTEM.Model;

namespace INVENTORY_SYSTEM.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product AddProduct(Product request);
    }
}
