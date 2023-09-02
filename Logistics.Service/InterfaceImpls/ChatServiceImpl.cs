using Logistics.Data.DTO.Chat;
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
    public class ChatServiceImpl : IChatService
    {
        IChatRepository _IChatRepository;
        IUnitOfWork _unitOfWork;

        public ChatServiceImpl(IChatRepository IChatRepository, IUnitOfWork unitOfWork)
        {
            this._IChatRepository = IChatRepository;
            this._unitOfWork = unitOfWork;
        }

        public List<VMessage> GetVMessages()
        {
            var messages = _IChatRepository.GetAll().OrderBy(x=>x.CreatedDate);
            return messages.ToList();
        }
    }
}
