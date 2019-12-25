using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Damage_Classification")]
    public class DamageClassification : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
