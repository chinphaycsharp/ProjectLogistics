using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.Service.Repositories;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.InterfaceImpls
{
    public class VTopOrderMaxPriceImpl : IVTopOrderMaxPriceService
    {
        IVTopOrderMaxPriceRepository _vTopOrderMaxPriceRepository;
        IUnitOfWork _unitOfWork;

        public VTopOrderMaxPriceImpl(IVTopOrderMaxPriceRepository vTopOrderMaxPriceRepository, IUnitOfWork unitOfWork)
        {
            _vTopOrderMaxPriceRepository = vTopOrderMaxPriceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<VTopOrderMaxPrice> GetVTopOrderMaxPrices()
        {
            return _vTopOrderMaxPriceRepository.GetVTopOrderMaxPrices();
        }
    }
}
