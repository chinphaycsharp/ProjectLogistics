using Logistics.Data.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Service.Infrastructures
{
    public interface IDbFactory : IDisposable
    {
        //Tạo DbContext
        LogisticsContext init();
    }
}
