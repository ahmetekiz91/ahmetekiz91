using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BIRIMDONUSUMLERI : BaseEntity
    {

        public int? Birim_Don_ID { get; set; }
        public DateTime? CDate { get; set; }
        public int? Birim1_ID { get; set; }
        public decimal? Deger1 { get; set; }
        public int? Birim2_ID { get; set; }
        public decimal? Deger2 { get; set; }


    }
}
