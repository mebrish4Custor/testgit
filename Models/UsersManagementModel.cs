using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace LMSN.DATA.Models
{
    public class UsersManagementModel
    {
        public List<EditUserModel> FillRole()
        {
            List<EditUserModel> RecordsList = new List<EditUserModel>();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString);
            SqlDataReader dr = null;
            string strGetAllRecords = @"SELECT RoleId,RoleName  From Roles";
            SqlCommand command = new SqlCommand() { CommandText = strGetAllRecords, CommandType = CommandType.Text };
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();//
                while (dr.Read())
                {
                    EditUserModel objRoles = new EditUserModel();
                    objRoles.RoleId = (int)dr["RoleId"];
                    if (dr["RoleName"].Equals(DBNull.Value))
                        objRoles.RoleName = string.Empty;
                    else
                        objRoles.RoleName = (string)dr["RoleName"];
                    RecordsList.Add(objRoles);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("ProjectExpense::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
            return RecordsList;
        }
    }
    public class AddUserModel
    {
        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }
        public string UserID { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        [Required]
        [Display(Name = "User Name")]
        //Using Remote validation attribute
        [Remote("IsUserExists", "UsersManagement", HttpMethod = "POST", ErrorMessage = "User Name already exists!")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name = "User Role")]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password confirmation must match password.")]
        public string CPassword { get; set; }
        public int IsArchived { get; set; }
        public int IsActive { get; set; }
        public byte[] Image { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<GenderModelTWO> SEX { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<int> unit_id { get; set; }
        public string grade { get; set; }
    }

    public class GenderModelTWO
    {
        public string GenderID { get; set; }
        public string Description { get; set; }
    }

    public class UsersListModel
    {
        public string UserID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public byte[] Image { get; set; }
        public string DateCreated { get; set; }
        public int IsActive { get; set; }
        public int IsArchived { get; set; }

        public string Operation { get; set; }
        public DateTime Reg_Date { get; set; }
        public int unit_id { get; set; }
        public string grade { get; set; }
    }

    public class EditUserModel
    {
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Genderr { get; set; }  
        [Required]
        [Display(Name = "User Name")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name = "User Role")]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password confirmation must match password.")]
        public string CPassword { get; set; }
        public byte[] Image { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime Reg_Date { get; set; }
        public int unit_id { get; set; }
        public string grade { get; set; }

        public IEnumerable<GenderModelTWO> SEX { get; set; }
    }
}