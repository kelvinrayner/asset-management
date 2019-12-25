using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Asset_Return")]
    public class AssetReturn : BaseModel
    {
        public int Id { get; set; }
        public AssetLend AssetLend { get; set; }
        public DateTime Return_Date { get; set; }
        public string Condition { get; set; }
        public int Charge { get; set; }
    }
}
