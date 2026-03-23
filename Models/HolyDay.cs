using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public class HolyDay
    {
        public System.Guid HolidayMainGuid { get; set; }
        public System.DateTime HolidayDate { get; set; }
        public int FisicalYear { get; set; }
        public int Type { get; set; }
    }
}