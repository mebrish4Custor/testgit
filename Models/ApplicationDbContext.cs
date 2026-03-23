using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ABPS.Models;
using LMS.Models;

namespace ABPS.Models  
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<LMSN.DATA.tbl_LeaveType> LeaveType { get; set; }

        public ApplicationDbContext()
            : base("LMSEntities", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}