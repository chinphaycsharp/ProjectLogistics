using Logistics.Data.Entities;
using Logistics.Service.Commons;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Repositories
{
    public interface IVTopOrderMaxPriceRepository : IRepository<VTopOrderMaxPrice>
    {
        List<VTopOrderMaxPrice> GetVTopOrderMaxPrices();
    }

    public class VTopOrderMaxPriceRepository : RepositoryBase<VTopOrderMaxPrice>, IVTopOrderMaxPriceRepository
    {
        public VTopOrderMaxPriceRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public List<VTopOrderMaxPrice> GetVTopOrderMaxPrices()
        {
            return DbContext.VTopOrderMaxPrices.Take(5).OrderByDescending(x => x.TotalPrice).ToList();
        }
    }
}
