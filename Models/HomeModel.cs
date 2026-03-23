//using LMSN.Common;
using LMSN.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.Configuration;
//using System.Data;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Configuration;
//using System.Data;
using System.Linq;
using System.Web;

namespace LMSN.DATA.Models
{
    public class HomeModel
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

        SystemTools _SystemTools = new SystemTools();
        public bool Update(LoginModel objUsers)  
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string strUpdate = @"UPDATE [dbo].[Users] SET [Password] =@Password  WHERE [UserID]=@UserID";     
                               
            SqlCommand command = new SqlCommand() { CommandText = strUpdate, CommandType = CommandType.Text };
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UserID", objUsers.UserID));
                //command.Parameters.Add(new SqlParameter("@Email", objUsers.UserName));
                command.Parameters.Add(new SqlParameter("@Password", _SystemTools.EncryptPass(objUsers.Password)));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Users::Update::Error!" + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
    }
    public class LoginModel
    {
        public string UserID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }  

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string NewPassword { get; set; } 
        public bool RememberMe { get; set; }

        public int IsArchived { get; set; }
        public int IsActive { get; set; }
        public int UnitId { get; set; }
        
    }

    public class LoginResultModel
    {
        public int UserID { get; set; }
         [Display(Name = "User Name")]
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Position { get; set; }
        public byte[] Image { get; set; }
        public bool RememberMe { get; set; }
        public string Password { get; set; }
        public int UnitID { get; set; }
    }

    public class DashboardModels
    {
        public string UsersList { get; set; }
        public string ActiveUsers { get; set; }
        public string InActiveUsers { get; set; }
        public string ArchivedUsers { get; set; }
        public bool RememberMe { get; set; }
    }
    public class LMSDashboardModels 
    {
        public string ApprovedList { get; set; }
        public string WaitingList { get; set; } 
        public string NotAprovedList { get; set; }
        //public string ArchivedUsers { get; set; }
        public bool RememberMe { get; set; }
    }
}