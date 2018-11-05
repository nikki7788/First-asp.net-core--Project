using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Members
    {
        [Key]
        public int MEmberId { get; set; }

        [Display(Name = "نام کاربر")]
        [Required(ErrorMessage = "نام را وارد کنید")]
        public string MemberName { get; set; }

        [Display(Name = "نام خانوادیگی کاربر")]
        [Required(ErrorMessage = "نام خانوادگی را وارد کنید")]
        public string MemberFamily { get; set; }

        [Display(Name = "ایمیل کاربر")]
        [Required(ErrorMessage = "ایمیل را وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل درست را وارد نمایید")]

        //[DataType(DataType.EmailAddress,ErrorMessage = "لطفا ایمیل درست را وارد نمایید")]
        public string Email { get; set; }

        [Display(Name = "نام کاربری کاربر")]
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        public string UserName { get; set; }

        [Display(Name = "پسورد کاربر")]
        [Required(ErrorMessage = "پسورد را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }





    }
}
