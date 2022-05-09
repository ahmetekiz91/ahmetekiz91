using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class ATTRIBUTESVALUE : BaseEntity
    {

        public int? ID { get; set; }
        public int? ATT_ID { get; set; }
        public string VALUE { get; set; }
        public DateTime? CDATE { get; set; }
        public int? ACTIVE { get; set; }
        public int? BIRIM_ID { get; set; }


    }
}
