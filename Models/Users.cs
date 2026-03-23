using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public class UsersModel 
    {
        public long UserID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<int> IsArchived { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> Status { get; set; }
        public string Sal_Acc_No { get; set; }
        public string grade { get; set; }
        public Nullable<System.DateTime> Reg_Date { get; set; }
        public Nullable<int> unit_id { get; set; }
    }
}