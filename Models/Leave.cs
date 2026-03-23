
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSN.DATA.Models 
{
    public class LeaveModel   
    {
        public System.Guid MainGuid { get; set; }
        public int seq_no { get; set; }
        public Nullable<System.Guid> ParentGuid { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> reg_date { get; set; }
        [Display(Name = "Leave Event")]
        public Nullable<int> leave_event { get; set; }
        public Nullable<int> leave_effect { get; set; }
        [Display(Name = "From Date")]
        [DataType(DataType.DateTime), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime from_date { get; set; }
       
        [DataType(DataType.DateTime), Required]
        [Display(Name = "To date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Remote("IsnetdurationExists", "LeaveForm", HttpMethod = "POST", ErrorMessage = "Salary update need aproval!")]
        public System.DateTime to_date { get; set; }
        [Display(Name = "Net Duration")]
        public double net_duration { get; set; }
          [Display(Name = "Leave Entitlment")]
        public Nullable<int> balance { get; set; }
        [Display(Name = "Remark")]
        public string remark { get; set; }
         [Display(Name = "Budget Year")]
        public Nullable<int> budget_year { get; set; }
        public Nullable<bool> isTransfered { get; set; }
        public string TransferedBy { get; set; }
        public Nullable<int> TransferedFrom { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<int> status { get; set; }
        public System.DateTime postingDate { get; set; }
        public string adminRemark { get; set; }
        public Nullable<System.DateTime> adminRemarkDate { get; set; }
        public string leave_event_text { get; set; }
        public string leave_effect_text { get; set; }
         [Display(Name = "leave Taken")]
        public Nullable<double> leaveTaken { get; set; }
        [Display(Name = "Current Balance")]
        public Nullable<double> currentbalance { get; set; }
        [Display(Name = "Accrued Leave")]
        public Nullable<double> accruedLeave { get; set; }
        public Nullable<double> salary { get; set; }

     
    }
}