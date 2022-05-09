using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Duy_Detay : BaseEntity
    {

        public int? DDET_ID { get; set; }
        public DateTime? CDate { get; set; }
        public int? Alici_ID { get; set; }
        public int? Okundumu { get; set; }
        public int? Duy_ID { get; set; }


    }
}
