using Logistics.Data.DTO.Chat;
using Logistics.Data.DTO.Order;
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
    public interface IChatRepository : IRepository<VMessage>
    {
        Task<PaginatedList<VMessage>> GetAllChats(ChatSearchDTO dto);
    }

    public class ChatRepository : RepositoryBase<VMessage>, IChatRepository
    {
        public ChatRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public async Task<PaginatedList<VMessage>> GetAllChats(ChatSearchDTO dto)
        {

            var accounts = from s in DbContext.VMessages
                           where s.IsAdmin ==  null
                           select s;

            int pageSize = dto.PageNumber ?? 5;
            var result = await PaginatedList<VMessage>.CreateAsync(accounts.AsQueryable().AsNoTracking(), dto.PageIndex ?? 1, pageSize);
            return result;
        }
    }
}
