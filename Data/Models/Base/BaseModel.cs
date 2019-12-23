using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Base
{
    public class BaseModel
    {   
        public DateTime Create_Date { get; set; }
        public Nullable<DateTime> Update_Date { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        public bool Is_Deleted { get; set; }
    }
}
