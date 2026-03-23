using LMSN.DATA.Models;
using LMSN.DATA;
using LMSN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSN.DATA.ViewModels
{
    public class LeaveDetailFormViewModel //: ViewModelBase  
    {
        //public LeaveDetailFormViewModel()
        //{
        //    Init();
        //}


        public string EventCommand { get; set; }
        public string EventArgument { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }
        public bool IsDetailAreVisible { get; set; }
        public bool IsListAreVisible { get; set; }
        public bool IsSearchAreVisible { get; set; }
        public bool IsPersonVisible { get; set; }



        public IEnumerable<LMSN.DATA.tbl_LeaveType> leaveType { get; set; }
        //public IEnumerable<LMSN.DATA.tblLeaveEffect> LeaveEffect { get; set; }
        public LMSN.DATA.tbl_LeaveDetails LeaveDetails { get; set; }
        public LMSN.DATA.User Users { get; set; }
        public MargedTables MargedTables { get; set; }
        public LMSN.DATA.tblLeave leaves { get; set; }
        public LMSN.DATA.Person People { get; set; }  
        public MargedTables MargedTable { get; set; }
        public LMSN.DATA.tblLeave Searchleaves { get; set; }
        public List<LMSN.DATA.tblLeave> tblLeavese { get; set; }

        //protected override void Init()
        //{
        //    tblLeavese = new List<tblLeave>();
        //    Searchleaves = new tblLeave();
        //    leaves = new tblLeave();
        //    base.Init();
        //}

        //public override void HandleRequest()
        //{
        //    base.HandleRequest();
        //}
        //protected override void Add()
        //{
        //    IsValid = true;
        //    leaves = new tblLeave();
        //    //Person = new tblPerson();
        //    //Person.BirthDate = DateTime.Now;
        //    //Person.Code = "";
        //    //Person.FullName = "";
        //    //Person.GenderID = 0;

        //    base.Add();
        //}

        //protected override void Edit()
        //{
        //    LeaveManager mgr = new LeaveManager();
        //    //Person = mgr.Get(Convert.ToInt32(EventArgument));
        //    leaves = mgr.Get(new Guid(EventArgument));

        //    base.Edit();
        //}
        //protected override void Delete()
        //{
        //    LeaveManager mgr = new LeaveManager();
        //    leaves = new tblLeave();
        //    //Person.unit_id = Convert.ToInt32(EventArgument);
        //    leaves.MainGuid = new Guid(EventArgument);
        //    mgr.Delete(leaves);
        //    Get();

        //    base.Delete();
        //}

        //protected override void Save()
        //{
        //    LeaveManager mgr = new LeaveManager();
        //    if (Mode == "Add")
        //    {
        //        mgr.Insert(leaves);
        //    }
        //    else
        //    {
        //        mgr.Update(leaves);
        //    }

        //    ValidationErrors = mgr.ValidationErrors;

        //    base.Save();
        //}
        //protected override void ResetSearch()
        //{
        //    Searchleaves = new tblLeave();

        //    base.ResetSearch();
        //}
        //protected override void Get()
        //{
        //    LeaveManager mgr = new LeaveManager();

        //    tblLeavese = mgr.Get(Searchleaves);
        //    base.Get();
        //}
    }
}