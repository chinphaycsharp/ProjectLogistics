using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using Logistics.Service.Interfaces;
using Logistics.Service.Repositories;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Logistics.Service.InterfaceImpls
{
    public class ProductServiceImpl : IProductService
    {
        IProductRepository _IProductRepository;
        IUnitOfWork _unitOfWork;

        public ProductServiceImpl(IProductRepository IProductRepository, IUnitOfWork unitOfWork)
        {
            this._IProductRepository = IProductRepository;
            this._unitOfWork = unitOfWork;
        }

        public List<Product> GetProducts()
        {
            return _IProductRepository.GetAll().ToList();
        }

        public Product GetProductById(string id)
        {
            return _IProductRepository.GetProductById(id);
        }
    }
}
