using System.Collections.Generic;

namespace QuanLySinhVien.WebApp.Commons
{
    public class UserStorage
    {
        public string id { get; set; }
        public string token { get; set; }
        public List<string> roles { get; set; }
        public string username { get; set; }
    }
}
