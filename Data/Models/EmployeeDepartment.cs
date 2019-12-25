using Data.Models.Base;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Employee_Department")]
    public class EmployeeDepartment : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeDepartment()
        {
        }

        public EmployeeDepartment(DepartmentVM departmentVM)
        {
            Id = departmentVM.Id;
            Name = departmentVM.Name;
            Create_Date = DateTime.Now;
            Is_Deleted = false;
        }

        public void Update(DepartmentVM departmentVM)
        {
            Id = departmentVM.Id;
            Name = departmentVM.Name;
            Update_Date = DateTime.Now;
        }

        public void Delete(int id)
        {
            Is_Deleted = true;
            Delete_Date = DateTime.Now;
        }
    }
}
