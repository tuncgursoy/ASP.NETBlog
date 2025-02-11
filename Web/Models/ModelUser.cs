﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class ModelUser
    {
        [Required]
        public string isim { get; set; }
        [Required]
        public string soyisim { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string sifre { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public int isyazar { get; set; }
        public bool isitexits { get; set; }
        //------

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("sifre", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }



    }
}
