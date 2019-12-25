using Data.Models.Base;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Handphone_Number { get; set; }
        public string Email { get; set; }
        public DateTime Start_Working { get; set; }

        public Employee()
        {
        }

        public Employee(EmployeeVM employeeVM)
        {
            Name = employeeVM.Name;
            Address = employeeVM.Address;
            Handphone_Number = employeeVM.Handphone_Number;
            Email = employeeVM.Email;
            Start_Working = employeeVM.Start_Working;
            Create_Date = DateTime.Now;
            Is_Deleted = false;
        }

        public void Update(EmployeeVM employeeVM)
        {
            Name = employeeVM.Name;
            Address = employeeVM.Address;
            Handphone_Number = employeeVM.Handphone_Number;
            Email = employeeVM.Email;
            Start_Working = employeeVM.Start_Working;
            Update_Date = DateTime.Now;
        }

        public void Delete(int id)
        {
            Is_Deleted = true;
            Delete_Date = DateTime.Now;
        }
    }
}
