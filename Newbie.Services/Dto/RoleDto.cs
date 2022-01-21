using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.DTO
{
    [Table("roles")]
    [Index(nameof(AuthorizationId), Name = "authorization_id")]
    [Index(nameof(MemberId), Name = "member_id")]
    public class Role
    {
        [Key]
        [Column("role_id", TypeName = "int(11)")]
        public int RoleId { get; set; }
        [Required]
        [Column("member_id")]
        [StringLength(50)]
        public string MemberId { get; set; }
        [Column("authorization_id", TypeName = "int(11)")]
        public int AuthorizationId { get; set; }

        [ForeignKey(nameof(AuthorizationId))]
        [InverseProperty("RolesNavigation")]
        public virtual Authorization Authorization { get; set; }
        [ForeignKey(nameof(MemberId))]
        [InverseProperty(nameof(MembersPublic.Roles))]
        public virtual MembersPublic Member { get; set; }
    }
}
