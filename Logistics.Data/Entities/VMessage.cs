using System;
using System.Collections.Generic;

#nullable disable

namespace Logistics.Data.Entities
{
    public partial class VMessage
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsAdmin { get; set; }
        public string Alias { get; set; }
    }
}
