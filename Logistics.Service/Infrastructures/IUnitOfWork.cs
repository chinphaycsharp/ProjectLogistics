using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Service.Infrastructures
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
