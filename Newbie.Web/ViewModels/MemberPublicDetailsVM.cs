using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Newbie.Web.ViewModels
{
    public class MemberPublicDetailsVM
    { 
        [Display(Name = "會員ID")] 
        public string MemberId { get; set; }

        [Display(Name = "帳號名稱")]
        [Required(ErrorMessage = "必要欄位")]
        public string Accountname { get; set; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "必要欄位")]
        public string Firstname { get; set; }

        [Display(Name = "姓氏")]
        [Required(ErrorMessage = "必要欄位")]
        public string Lastname { get; set; }

        [Display(Name = "暱稱")]
        public string Nickname { get; set; }

        [Display(Name = "自我介紹")]
        public string Intro { get; set; }
        
        [Display(Name = "加入會員日期")]
        public DateTime Joindate { get; set; }
        public int MemberspublicId { get; set; }
    }
}
