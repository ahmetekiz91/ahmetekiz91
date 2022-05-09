using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Fis_Turleri : BaseEntity
    {

        public int? Tur_Id { get; set; }
        public DateTime? CDate { get; set; }
        public string Tur_Adi { get; set; }
        public int? GirisCikis { get; set; }
        public int? CUSR_ID { get; set; }
        public string Kodu { get; set; }
        public int? Cancelled { get; set; }


    }
}
