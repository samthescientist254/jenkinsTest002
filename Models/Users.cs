using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string LoadData { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public int? Roles { get; set; }
        public string Status { get; set; }
        public DateTime? Lastlogin { get; set; }
        public string Menucode { get; set; }
        public string Homepage { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Mobile { get; set; }
        public string Lastloginapp { get; set; }
        public string Lastloginmachine { get; set; }
        public int? Loginfailures { get; set; }
        public int? Priority { get; set; }
        public string Authcode { get; set; }
        public string Authcodestatus { get; set; }
        public string Authcodeissuer { get; set; }
        public DateTime? Authcodeissdt { get; set; }
        public DateTime? Authcodeusdt { get; set; }
    }
}
