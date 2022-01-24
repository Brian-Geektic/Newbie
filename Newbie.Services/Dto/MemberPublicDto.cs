using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Dto
{
    public class MemberPublicDto
    {

        public string MemberId { get; set; }
        public string Accountname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; }
        public string Intro { get; set; }
        public DateTime Joindate { get; set; }
        public int MemberspublicId { get; set; }
    }
}
