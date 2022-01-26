using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newbie.Web.ViewModels
{
    public class RoleDetailsVM
    {
        public int RoleId { get; set; }
        public string MemberId { get; set; }
        public int AuthorizationId { get; set; }
    }
}
