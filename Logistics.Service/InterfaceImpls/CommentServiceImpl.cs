using Logistics.Data.DTO.Comment;
using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
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
    public class CommentServiceImpl : ICommentService
    {
        ICommentRepository _commentRepository;
        IUnitOfWork _unitOfWork;

        public CommentServiceImpl(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            this._commentRepository = commentRepository;
            this._unitOfWork = unitOfWork;
        }
        public bool AddComment(CommentCreateDTO createDTO)
        {
            Comment comment = new Comment()
            {
                ClientName = createDTO.ClientName,
                Content = createDTO.Content,
                CountStars = createDTO.CountStars,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Isdeleted = false
            };
            try
            {
                _commentRepository.Add(comment);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteComment(Comment comment)
        {
            try
            {
                _commentRepository.Delete(comment);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Comment GetCommentById(int id)
        {
            return _commentRepository.GetCommentById(id);   
        }

        public Task<PaginatedList<Comment>> GetComments(CommentSearchDTO orderSearchDTO)
        {
            return _commentRepository.GetComments(orderSearchDTO);
        }

        public bool UpdateComment(Comment comment)
        {
            try
            {
                _commentRepository.Update(comment);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
