﻿using Data.Models.Base;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Account")]
    public class Account : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
        public AccountRole Role { get; set; }

        public Account()
        {
        }

        public Account(AccountVM accountVM)
        {
            Id = accountVM.Id;
            Email = accountVM.Email;
            Password = accountVM.Password;
            Create_Date = DateTime.Now;
            Is_Deleted = false;
        }

        public void Update(AccountVM accountVM)
        {
            Id = accountVM.Id;
            Email = accountVM.Email;
            Password = accountVM.Password;
            Update_Date = DateTime.Now;
        }

        public void Delete(int id)
        {
            Is_Deleted = true;
            Delete_Date = DateTime.Now;
        }
    }
}
