using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{ 
    public class LeaveEffectModel   
    {
        public int Id { get; set; }
        public Nullable<int> Code { get; set; }
        public string description { get; set; }
    }
}