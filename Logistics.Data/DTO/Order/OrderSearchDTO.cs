using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Order
{
    public class OrderSearchDTO
    {
        public string? SearchValue { get; set; }
        public DateTime? DateStart{ get; set; }
        public DateTime? DateEnd{ get; set; }
        public int? PageNumber { get;set; }
        public int? PageIndex { get;set; }
    }
}
