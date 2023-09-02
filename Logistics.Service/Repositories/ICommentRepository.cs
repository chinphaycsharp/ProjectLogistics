using Logistics.Data.DTO.Comment;
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
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<PaginatedList<Comment>> GetComments(CommentSearchDTO orderSearchDTO);
        Comment GetCommentById(int id);
    }

    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public Comment GetCommentById(int id)
        {
            var query = from p in DbContext.Comments
                        where p.Id == id
                        select p;

            return query.FirstOrDefault();
        }

        public async Task<PaginatedList<Comment>> GetComments(CommentSearchDTO orderSearchDTO)
        {
            if (orderSearchDTO.SearchValue != null)
            {
                orderSearchDTO.PageNumber = 1;
            }
            var accounts = from s in DbContext.Comments
                           select s;
            if (!String.IsNullOrEmpty(orderSearchDTO.SearchValue))
            {
                accounts = accounts.Where(s => s.ClientName.Contains(orderSearchDTO.SearchValue));
            }

            int pageSize = orderSearchDTO.PageNumber ?? 5;
            var result = await PaginatedList<Comment>.CreateAsync(accounts.AsQueryable().AsNoTracking(), orderSearchDTO.PageIndex ?? 1, pageSize);
            return result;
        }
    }
}
