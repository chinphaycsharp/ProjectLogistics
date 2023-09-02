using Logistics.Data.Dbcontext;
using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.WebAppAdmin.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System;
using System.Threading.Tasks;

namespace Logistics.WebAppAdmin.HubConfig
{
    public class RealTimeHub : Hub
    {
        private LogisticsContext _context;
        public RealTimeHub(LogisticsContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string body)
        {
            try
            {
                ItemMessage model = JsonConvert.DeserializeObject<ItemMessage>(body);
                Chat chat = new Chat();
                chat.AccountId = model.account_id;
                chat.Isdeleted = false;
                chat.CreatedDate = DateTime.Now;
                chat.UpdatedDate = DateTime.Now;
                chat.Message = model.message;
                chat.CustomerName = model.customer_name;
                chat.Alias = model.alias;
                chat.IsAdmin = model.isAdmin;
                _context.Chats.Add(chat);
                _context.SaveChanges();
                // Xử lý tin nhắn ở đây
                await Clients.All.SendAsync("ReceiveMessage", model.account_id, model.message, model.customer_name,model.isAdmin,model.alias,chat.CreatedDate);
            }
            catch (Exception ex)
            {
                // Gửi thông báo lỗi về máy khách
                await Clients.Caller.SendAsync("ErrorMessage", ex.Message);
            }
        }
    }

    public class ItemMessage 
    {
        public string? account_id { get; set; }
        public string? message { get; set; }
        public string? customer_name { get; set; }
        public bool? isAdmin{ get; set; }
        public string? alias { get; set; }
    }
}
