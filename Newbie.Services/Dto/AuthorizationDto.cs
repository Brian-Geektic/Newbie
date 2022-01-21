﻿using Newbie.Repositories.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.DTO
{
    [Table("authorization")]
    public partial class Authorization
    {
        public Authorization()
        {
            RoleArticles = new HashSet<RoleArticle>();
            RolesNavigation = new HashSet<Role>();
        }

        [Key]
        [Column("authorization_id", TypeName = "int(11)")]
        public int AuthorizationId { get; set; }
        [Required]
        [Column("roles")]
        [StringLength(20)]
        public string Roles { get; set; }
        [Required]
        [Column("createact")]
        [StringLength(1)]
        public string Createact { get; set; }
        [Required]
        [Column("readact")]
        [StringLength(1)]
        public string Readact { get; set; }
        [Required]
        [Column("updateact")]
        [StringLength(1)]
        public string Updateact { get; set; }
        [Required]
        [Column("deleteact")]
        [StringLength(1)]
        public string Deleteact { get; set; }

        [InverseProperty(nameof(RoleArticle.Authorization))]
        public virtual ICollection<RoleArticle> RoleArticles { get; set; }
        [InverseProperty(nameof(Role.Authorization))]
        public virtual ICollection<Role> RolesNavigation { get; set; }
    }
}
