using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductById(string id);
        List<OrderItem> GetAllProductsByOrderId(string id);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public List<OrderItem> GetAllProductsByOrderId(string id)
        {
            var products = from p in DbContext.Products
                           join od in DbContext.OrderDetails
                           on p.Id equals od.ProductId
                           where od.OrderId == id
                           select new OrderItem
                           {
                                Id = od.Id,
                                OrderId = od.OrderId,
                                Price = p.Price.Value,
                                ProductId = od.ProductId,
                                ProductName = p.Name,
                                Quantity = od.Quantity.Value,
                                TotalPrice = od.TotalPrice.Value
                           };
            return products.ToList();   
        }

        public Product GetProductById(string id)
        {
            var query = from p in DbContext.Products
                        where p.Id == id
                        select p;

            return query.FirstOrDefault();
        }
    }
}
