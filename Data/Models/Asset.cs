using Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("TB_M_Asset")]
    public class Asset : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeAsset Type { get; set; }
        public string Condition { get; set; }
    }
}
