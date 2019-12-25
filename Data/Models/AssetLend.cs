using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Asset_Lend")]
    public class AssetLend : BaseModel
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Asset Asset { get; set; }
        public DateTime Lend_Date { get; set; }
        public DateTime End_Date { get; set; }
        public StatusApproval Manager_Status { get; set; }
        public Employee Manager { get; set; }
        public string Manager_Additional_Info { get; set; }
        public StatusApproval Procurement_Status { get; set; }
        public string Procurement_Additional_Info { get; set; }
    }
}
