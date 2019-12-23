using Data.Models.Base;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_User")]
    public class User : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User()
        {
        }

        public User(UserVM userVM)
        {
            Name = userVM.Name;
            Email = userVM.Email;
            Create_Date = DateTime.Now;
            Is_Deleted = false;
        }   

        public void Update(UserVM userVM)
        {
            Name = userVM.Name;
            Email = userVM.Email;
            Update_Date = DateTime.Now;
        }

        public void Delete(int id)
        {
            Is_Deleted = true;
            Delete_Date = DateTime.Now;
        }
    }
}
