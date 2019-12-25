using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_T_Damage_Asset")]
    public class DamageAsset : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public AssetLend AssetLend { get; set; }
        public DamageClassification Damage { get; set; }
    }
}
