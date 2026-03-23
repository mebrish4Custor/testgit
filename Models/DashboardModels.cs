using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSN.DATA.Models
{
   public class DashboardModels
    {
        public string UsersList { get; set; }
        public string ActiveUsers { get; set; }
        public string InActiveUsers { get; set; }
        public string ArchivedUsers { get; set; }
        public bool RememberMe { get; set; }
    }
}
