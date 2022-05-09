using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BANKALAR : BaseEntity
    {

        public int? ID { get; set; }
        public string BANKAKODU { get; set; }
        public DateTime? CDATE { get; set; }
        public string BANKAADI { get; set; }
        public string SUBE { get; set; }
        public string SEHIR { get; set; }
        public string ULKE { get; set; }
        public int? CUSR_ID { get; set; }
        public int? UUSR_ID { get; set; }
        public int? DOVIZ_ID { get; set; }
        public DateTime? UDATE { get; set; }


    }
}
