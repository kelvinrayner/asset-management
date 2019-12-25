using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Employee_Details")]
    public class EmployeeDetails : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public EmployeeDepartment Department { get; set; }
        public EmployeePosition Position { get; set; }
        public Employee Manager { get; set; }
        public Employee Division_Head { get; set; }
        public Employee Bod { get; set; }
    }
}
