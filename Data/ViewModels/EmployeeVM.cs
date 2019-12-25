using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Handphone_Number { get; set; }
        public string Email { get; set; }
        public DateTime Start_Working { get; set; }
        public int Department { get; set; }
        public int Manager_Id { get; set; }
        public int Div_Head_Id { get; set; }
        public int Bod_Id { get; set; }
    }
}
