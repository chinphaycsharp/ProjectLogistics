using Logistics.Data.DTO.Comment;
using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Interfaces
{
    public interface ICommentService
    {
        Task<PaginatedList<Comment>> GetComments(CommentSearchDTO orderSearchDTO);
        Comment GetCommentById(int id);
        bool AddComment(CommentCreateDTO createDTO);
        bool UpdateComment(Comment comment);
        bool DeleteComment(Comment comment);
    }
}
