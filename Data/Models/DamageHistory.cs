using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Damage_History")]
    public class DamageHistory : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DamageAsset DamageAsset { get; set; }
        public DamageClassification DamageClassification { get; set; }
    }
}
