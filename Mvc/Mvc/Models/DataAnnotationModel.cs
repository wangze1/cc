using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class DataAnnotationModel
    {
        [Required]
        [Display(Name = "登录名")]
        //[StringLength(10,MinimumLength =2,ErrorMessage ="{0}，小{2}，大{1}")]
        [DataType(DataType.PhoneNumber)]
        public string LoginName
        {
            get; set;
        }
    }
}