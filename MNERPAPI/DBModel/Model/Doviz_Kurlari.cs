using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Doviz_Kurlari : BaseEntity
    {

        public int? Doviz_Kur_ID { get; set; }
        public int? Doviz1_ID { get; set; }
        public decimal? Doviz1_Deger { get; set; }
        public DateTime? CDate { get; set; }
        public int? Doviz2_ID { get; set; }
        public decimal? Doviz2_Deger { get; set; }


    }
}
