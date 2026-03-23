using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public class GradeModel 
    {
        public System.Guid MainGuid { get; set; }
        public string grade { get; set; }
        public string LeaveEntitlement { get; set; }
    }
}