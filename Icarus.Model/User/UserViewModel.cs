﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus.Model.User
{
    // Kullanıcıların giriş haricindeki işlemlerinde kullanacağı ViewModel
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad 3 iler 50 karakter arasında olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadı boş bırakılamaz!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyadı 2 iler 50 karakter arasında olmalıdır.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Soyadı 6 iler 50 karakter arasında olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-Mail alanı zorunludur.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Şifre 6 ile 50 karakter arasında olmalıdır.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-mail adresi!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Şifre 3 ile 50 karakter arasında olmalıdır.")]
        public string Password { get; set; }
    }
}
