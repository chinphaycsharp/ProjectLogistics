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
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetAccountByUserNameAndPassword(string username, string password);
    }

    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public Account GetAccountByUserNameAndPassword(string username, string password)
        {
            var query = from p in DbContext.Accounts
                        where p.Username == username && p.Password == password
                        select p;

            return query.FirstOrDefault();
        }
    }
}
