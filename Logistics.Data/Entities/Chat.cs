using System;
using System.Collections.Generic;

#nullable disable

namespace Logistics.Data.Entities
{
    public partial class Chat
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string CustomerName { get; set; }
        public string Message { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Isdeleted { get; set; }
        public string Alias { get; set; }

        public virtual Account Account { get; set; }
    }
}
