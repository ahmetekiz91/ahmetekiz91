using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Kasalar : BaseEntity
    {

        public int? Kasa_ID { get; set; }
        public DateTime? CDate { get; set; }
        public DateTime? UDate { get; set; }
        public string Kasa_Kodu { get; set; }
        public string Kasa_Adi { get; set; }
        public string MuhKodu { get; set; }
        public int? Dov_ID { get; set; }
        public int? CUSR_ID { get; set; }
        public int? USR_ID { get; set; }


    }
}
