using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Dto
{
    public class AuthorizationDto
    {

        public int AuthorizationId { get; set; }
        public string Roles { get; set; }
        public string Createact { get; set; }
        public string Readact { get; set; }
        public string Updateact { get; set; }
        public string Deleteact { get; set; }

    }
}
