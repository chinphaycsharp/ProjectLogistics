using System;
using System.Collections.Generic;

#nullable disable

namespace Logistics.Data.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Content { get; set; }
        public int? CountStars { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
