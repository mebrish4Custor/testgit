
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using LMSN.DATA.Models;



namespace LMSN.DATA.Models
{
    public class MargedTables
    {
        [Display(Name = "leave Taken")]
        public Nullable<double> leaveTaken { get; set; }
        public Nullable<double> currentbalance { get; set; }
        [Display(Name = "Net Duration")]
        public Nullable<double> net_duration { get; set; }
        public int Id { get; set; }
        [Display(Name = "Leave Type:")]
        public Nullable<int> leaveTypeId { get; set; }
        public int ID { get; set; }
        public Guid MainGuid { get; set; }
        public string LeaveDesc { get; set; }
        [Display(Name = "Employe Name :")]
        public string FullName { get; set; }
        [Display(Name = "Leave Date To :")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime toDate { get; set; }
        //public System.DateTime HiredDate { get; set; }
        public string HiredDate { get; set; }

        [Display(Name = "Leave Date From:")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime fromDate { get; set; }
        [Display(Name = "Employe Leave Description:")]
        public string description { get; set; }
        [Display(Name = "Posting Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime postingDate { get; set; }
        [Display(Name = "Admin Remark:")]
        public string adminRemark { get; set; }

        [Display(Name = "Admin Action taken date:")]
        public System.DateTime? adminRemarkDate { get; set; }
        public Nullable<int> budget_year { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> isRead { get; set; }
        public LMSN.DATA.tbl_LeaveType LeaveTyp { get; set; }
        [Display(Name = "Emp Id:")]
        public int empId { get; set; }
        [Display(Name = "Emp Id:")]
        public string UserID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int Seq_No { get; set; }
        [Display(Name = "Gender:")]
        public string Gender { get; set; }
        public int Genderr { get; set; } 
        public IEnumerable<GenderModelTWO> SEX { get; set; } 
        public string Email { get; set; }
        [Display(Name = "Emp Contact No.:")]
        public string Phone { get; set; }
        [Display(Name = "Leave Entitlment")]
        public Nullable<int> Balance { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<int> IsArchived { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> DateCreated { get; set; }
        [Display(Name = "leave Status:")]
        public Nullable<int> EmployeeStatus { get; set; }
        public string EmployeestutusDescription { get; set; }
        public string Sal_Acc_No { get; set; }
          [Display(Name = "Accrued Leave")]
        public Nullable<double> accruedLeave { get; set; }
        public Nullable<double> salary { get; set; }
        //public Nullable<System.DateTime> reg_date { get; set; }
        public string reg_date { get; set; }
        public Nullable<int> leave_event { get; set; }
        public bool IsApproved { get; set; }
        public string leave_event_text { get; set; }
        public string unit_id { get; set; }
        public string Unit_Text { get; set; }
        public string remark { get; set; }

        public int ApprovedList { get; set; }
        public int WaitingList { get; set; }
        public int NotAprovedList { get; set; }

    }
}