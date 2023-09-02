using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Chat
{
    public class ChatSearchDTO
    {
        public string? accountId { get; set; }
        public bool? isAdmin { get; set; }
        public int? PageNumber { get; set; }
        public int? PageIndex { get; set; }
    }
}
