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
    [Table("role_article")]
    [Index(nameof(AuthorizationId), Name = "authorization_id")]
    public class RoleArticle
    {
        [Key]
        [Column("rolearticle_id", TypeName = "int(11)")]
        public int RolearticleId { get; set; }
        [Column("authorization_id", TypeName = "int(11)")]
        public int AuthorizationId { get; set; }
        [Column("article_id", TypeName = "int(11)")]
        public int ArticleId { get; set; }

        [ForeignKey(nameof(AuthorizationId))]
        [InverseProperty("RoleArticles")]
        public virtual Authorization Authorization { get; set; }
    }
}
