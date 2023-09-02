using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Comment
{
    public class CommentCreateDTO
    {
        public string ClientName { get; set; }
        public string Content { get; set; }
        public int? CountStars { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
