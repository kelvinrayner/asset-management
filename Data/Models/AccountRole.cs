using Data.Models.Base;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Account_Role")]
    public class AccountRole : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public AccountRole()
        {
        }

        public AccountRole(RoleVM roleVM)
        {
            Id = roleVM.Id;
            Name = roleVM.Name;
            Create_Date = DateTime.Now;
            Is_Deleted = false;
        }

        public void Update(RoleVM roleVM)
        {
            Id = roleVM.Id;
            Name = roleVM.Name;
            Update_Date = DateTime.Now;
        }

        public void Delete(int id)
        {
            Is_Deleted = true;
            Delete_Date = DateTime.Now;
        }
    }
}
