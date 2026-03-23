using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Globalization;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Configuration;
//using ABPS.Models;
using LMSN.DATA.ViewModels;

namespace LMSN.DATA.Models
{
    public class LeaveManager
    {
        string DBCon = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
        private LMSN.DATA.LMSEntities Dbcontext;
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        static string _connectionString = string.Empty;
        public bool Validate(LMSN.DATA.tblLeave entity)
        {
            ValidationErrors.Clear();

            if ((entity.MainGuid != Guid.Empty))
            {
                if (entity.MainGuid == entity.MainGuid)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("Code", "Code must not be all lower case."));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Delete(LMSN.DATA.tblLeave entity)
        {
            LMSN.DATA.tblLeave Origin = new LMSN.DATA.tblLeave();

            Origin = Dbcontext.tblLeaves.Find(entity.MainGuid);
            if (Origin != null)
            {
                Dbcontext.tblLeaves.Remove(Origin);
                Dbcontext.SaveChanges();
            }
            //TODO
            return true;
        }
        public LMSN.DATA.tblLeave Get(Guid productId)
        {
            List<LMSN.DATA.tblLeave> list = new List<LMSN.DATA.tblLeave>();
            LMSN.DATA.tblLeave result = new LMSN.DATA.tblLeave();

            //TODO
            list = CreateMockDataPerson();

            result = list.Find(p => p.MainGuid == productId);

            return result;
        }
        public bool Update(LMSN.DATA.tblLeave entity)
        {
            bool result = false;

            result = Validate(entity);

            if (result)
            {
                LMSN.DATA.tblLeave Origin = Dbcontext.tblLeaves.Find(entity.MainGuid);
                if (Origin != null)
                {
                    //entity.date_Hire = DateTime.Now;
                    //entity.dateOfBirth = DateTime.Now;
                    //entity.event_date = DateTime.Now;
                    //entity.IDExpiryDate = DateTime.Now;
                    //entity.updated_event_date = DateTime.Now;
                    //entity.employeeId = 
                    Dbcontext.Entry(Origin).CurrentValues.SetValues(entity);
                    Dbcontext.SaveChanges();
                }
                //TODO
            }

            return result;
        }
        public bool Insert(LMSN.DATA.tblLeave m) 
        {
            bool result = false;

            result = Validate(m);
            if (result)
            {
                try
                {
                    m.MainGuid = Guid.NewGuid();
                    m.reg_date = Convert.ToString( DateTime.Now);
                    m.ApprovedDate = DateTime.Now;
                    m.status = 1;
                    m.postingDate = DateTime.Now;
                    Dbcontext.tblLeaves.Add(m); 
                    Dbcontext.SaveChanges();
                }
                catch (Exception x)
                {

                    throw;
                }

            }

            return result;
        }
        public LeaveManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<LMSN.DATA.tblLeave> Get(LMSN.DATA.tblLeave entity)
        {
            List<LMSN.DATA.tblLeave> result = new List<LMSN.DATA.tblLeave>();

            result = CreateMockDataPerson();

            if ((entity.MainGuid != Guid.Empty))
            {
                result = result.FindAll(p => p.MainGuid == entity.MainGuid);
                //result = result.FindAll(p => p.MainGuid.ToLower().StartsWith(entity.employeeId, StringComparison.CurrentCultureIgnoreCase));
            }

            return result;
        }
        //public List<tblLeave> Getpersonview(PersonViewModel entity)  
        //{
        //    List<PersonViewModel> result = new List<PersonViewModel>();

        //    result = CreateMockDataPersonview();

        //    if (!string.IsNullOrEmpty(entity.Person.employeeId))
        //    {
        //        result = result.FindAll(p => p.Person.employeeId.ToLower().StartsWith(entity.Person.employeeId, StringComparison.CurrentCultureIgnoreCase));
        //    }

        //    return result;
        //}
        private LeaveDetailFormViewModel CreateMockDataPersonn() 
        {
            List<LMSN.DATA.tblLeave> result = new List<LMSN.DATA.tblLeave>();
            result = Dbcontext.tblLeaves.ToList();

            var membershipTypes = Dbcontext.tbl_LeaveType.ToList();
            //var Leavefect = Dbcontext.tblLeaveEffects.ToList();
            var viewModel = new LeaveDetailFormViewModel
            {
                leaves = new LMSN.DATA.tblLeave(),
                leaveType = membershipTypes,
                //LeaveEffect = Leavefect
            };

            //return View("CustomerForm", viewModel);

            return viewModel;
        }
        private List<LMSN.DATA.tblLeave> CreateMockDataPerson() 
        {
            List<LMSN.DATA.tblLeave> result = new List<LMSN.DATA.tblLeave>();
            result = Dbcontext.tblLeaves.ToList();

            return result;
        }
    }
}
