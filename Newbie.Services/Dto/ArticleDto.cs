using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.DTO
{
    [Table("article")]
    public class Article
    {
        [Key]
        [Column("article_id", TypeName = "int(11)")]
        public int ArticleId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("content")]
        [StringLength(4000)]
        public string Content { get; set; }
        [Column("author")]
        [StringLength(50)]
        public string Author { get; set; }
    }
}
