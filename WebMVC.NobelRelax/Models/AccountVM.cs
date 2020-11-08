﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.NobelRelax.Models
{
    public class LoginVM
    {
        [Display(Name = "Електронна адреса")]
        [Required(ErrorMessage = "Вкажіть пошту")]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажіть пароль")]
        public string Password { get; set; }
    }

    public class RegistrationVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        [EmailAddress(ErrorMessage = "Не корекна пошта")]
        public string Email { get; set; }
        //
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        //[RegularExpression(@"^[+]380\d{9}$", ErrorMessage="Некоректний номер телефону")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Оберіть фото")]
        [Required(ErrorMessage = "Оберіть фото профілю")]
        [HiddenInput]
        public string PhotoBase64 { get; set; }
        //
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; }
    }
}
