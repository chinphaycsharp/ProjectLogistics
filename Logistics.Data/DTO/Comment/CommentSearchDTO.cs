using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Comment
{
    public class CommentSearchDTO
    {
        public string? SearchValue { get; set; }
        public int? PageNumber { get; set; }
        public int? PageIndex { get; set; }
    }
}
