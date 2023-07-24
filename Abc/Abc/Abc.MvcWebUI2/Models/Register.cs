using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI2.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage ="Eposta adresiniz uyuşmuyor")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage="Şifreleriniz uyuşmuyır.")]
        public string RePassword { get; set; }
    }
}