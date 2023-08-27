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
    public class AccountServiceImpl : IAccountService
    {
        IAccountRepository _accountRepository;
        IUnitOfWork _unitOfWork;

        public AccountServiceImpl(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            this._accountRepository = accountRepository;
            this._unitOfWork = unitOfWork;
        }

        public Account GetAccountByUserNameAndPassword(string username, string password)
        {
            return _accountRepository.GetAccountByUserNameAndPassword(username, password);
        }
    }
}
