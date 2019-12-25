using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Notebook_Request")]
    public class NotebookRequest : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Serial_Number { get; set; }
        public int Price { get; set; }
        public int Pay_Cash { get; set; }
        public Employee Employee { get; set; }
        public Employee Manager { get; set; }
        public Employee Division_HeadId { get; set; }
        public Employee BodId { get; set; }
        public StatusApproval Manager_Status { get; set; }
        public StatusApproval Divisio_Head_Status { get; set; }
        public StatusApproval Bod_Status { get; set; }
    }
}
