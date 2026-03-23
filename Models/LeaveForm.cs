
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
     
    public class LeaveForm
    {
        string DBCon = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
        public System.Guid MainGuid { get; set; }
        public int seq_no { get; set; }
        public Nullable<System.Guid> ParentGuid { get; set; }
        public Nullable<System.DateTime> reg_date { get; set; }
        public Nullable<int> leave_event { get; set; }
        public Nullable<int> leave_effect { get; set; }
        public Nullable<System.DateTime> from_date { get; set; }
        public Nullable<System.DateTime> to_date { get; set; }
        public Nullable<int> net_duration { get; set; }
        public Nullable<int> balance { get; set; }
        public string remark { get; set; }
        public Nullable<int> budget_year { get; set; }
        public Nullable<bool> isTransfered { get; set; }
        public string TransferedBy { get; set; }
        public Nullable<int> TransferedFrom { get; set; }
        public Nullable<int> IsApproved { get; set; }
        public Nullable<int> DateRange { get; set; }
        public string MedicalInistitute { get; set; }
        public string LetterNo { get; set; }
        public Nullable<System.DateTime> LetterDate { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<System.Guid> LeaveRequestGUID { get; set; }

        public LMSDashboardModels DashboardStatsOfLMS()
        {
            LMSDashboardModels _DashboardModels = new LMSDashboardModels();

            using (SqlConnection conn = new SqlConnection(DBCon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DashboardStatsLMS", conn);//call Stored Procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _DashboardModels.ApprovedList = reader["ApprovedList"].ToString();
                    _DashboardModels.WaitingList = reader["WaitingList"].ToString();
                    _DashboardModels.NotAprovedList = reader["NotAprovedList"].ToString();
                    //_DashboardModels.ArchivedUsers = reader["ArchivedUsers"].ToString();
                }

                return _DashboardModels;

            }
        }
    }
}