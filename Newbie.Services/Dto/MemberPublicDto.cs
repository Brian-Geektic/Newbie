using Newbie.Repositories.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.DTO
{
    [Table("members_public")]
    public class MembersPublic
    {
        public MembersPublic()
        {
            Roles = new HashSet<Role>();
        }

        [Key]
        [Column("member_id")]
        [StringLength(50)]
        public string MemberId { get; set; }
        [Required]
        [Column("accountname")]
        [StringLength(50)]
        public string Accountname { get; set; }
        [Required]
        [Column("firstname")]
        [StringLength(20)]
        public string Firstname { get; set; }
        [Required]
        [Column("lastname")]
        [StringLength(20)]
        public string Lastname { get; set; }
        [Column("nickname")]
        [StringLength(20)]
        public string Nickname { get; set; }
        [Column("intro")]
        [StringLength(200)]
        public string Intro { get; set; }
        [Column("joindate", TypeName = "date")]
        public DateTime Joindate { get; set; }

        [InverseProperty(nameof(Role.Member))]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
