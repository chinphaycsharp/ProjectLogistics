using Logistics.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Interfaces
{
    public interface IVTopOrderMaxPriceService
    {
        List<VTopOrderMaxPrice> GetVTopOrderMaxPrices();
    }
}
