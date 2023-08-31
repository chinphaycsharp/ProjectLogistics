using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(string id);
    }
}
