//using LMSN.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public partial class LeaveDetailModel   
    {
        public int Id { get; set; }
        public Nullable<int> leaveTypeId { get; set; }
        public string leave_event_text { get; set; }
        public string leave_effect_text { get; set; }
        public string LeaveDesc { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime toDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime fromDate { get; set; }
        public string description { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime postingDate { get; set; }
        public string adminRemark { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> adminRemarkDate { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> isRead { get; set; }
        public int empId { get; set; }
        public Nullable<int> leave_effect { get; set; }
        public Nullable<int> net_duration { get; set; }
    }
}