using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.DTO
{
    [Table("members_private")]
    public class MembersPrivate
    {
        [Key]
        [Column("member_id")]
        [StringLength(50)]
        public string MemberId { get; set; }
        [Required]
        [Column("password")]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [Column("cfmpassword")]
        [StringLength(20)]
        public string Cfmpassword { get; set; }
        [Column("birthdate", TypeName = "date")]
        public DateTime Birthdate { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [Column("email")]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [Column("qualifycode")]
        [StringLength(30)]
        public string Qualifycode { get; set; }
        [Required]
        [Column("qualifystatus")]
        [StringLength(10)]
        public string Qualifystatus { get; set; }
    }
}
