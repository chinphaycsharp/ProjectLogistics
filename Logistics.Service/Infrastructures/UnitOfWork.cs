using Logistics.Data.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Service.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IDbFactory dbFactory;
        private LogisticsContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public LogisticsContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = dbFactory.init());
            }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
