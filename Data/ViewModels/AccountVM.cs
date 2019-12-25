using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class AccountVM
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Employee_Id { get; set; }
        public int Role_Id { get; set; }
    }
}
