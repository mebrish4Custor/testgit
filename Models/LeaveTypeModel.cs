using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public class LeaveTypeModel           
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type")]
        public string LeaveTyped { get; set; }     
        [Display(Name = "Description")]
        public string Description { get; set; }
         [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
        public string leave_event_text { get; set; }
        public string LeaveTypeText { get; set; }

        public string ReturnDateForDisplay
        {
            get
            {
                return this.CreationDate.ToString("d");
            }
        }
    }


}