using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Depolar : BaseEntity
    {

        public int? Depo_ID { get; set; }
        public int? Bolge_ID { get; set; }
        public DateTime? CDate { get; set; }
        public string Depo_Adi { get; set; }
        public int? USR_ID { get; set; }
        public DateTime? FDate { get; set; }
        public DateTime? UDate { get; set; }
        public int? Cancelled { get; set; }


    }
}
