using Logistics.Data.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Service.Infrastructures
{
    public class DbFactory : Disposable, IDbFactory
    {
        LogisticsContext dbContext;
        public LogisticsContext init()
        {
            //Dependency injection
            return dbContext ?? (dbContext = new LogisticsContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
