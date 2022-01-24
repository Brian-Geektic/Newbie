using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Dto
{
    public class MemberPrivateDto
    {
        public string MemberId { get; set; }
        public string Password { get; set; }
        public string Cfmpassword { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Qualifycode { get; set; }
        public string Qualifystatus { get; set; }
        public int MembersprivateId { get; set; }
    }
}
