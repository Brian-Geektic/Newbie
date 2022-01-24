using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Dto
{
    public class RoleDto
    {

        public int RoleId { get; set; }
        public string MemberId { get; set; }
        public int AuthorizationId { get; set; }
    }
}
