using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class CARISUBELER : BaseEntity
    {

        public int? CARI_ADR_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public string KODU { get; set; }
        public string ADI { get; set; }
        public int? CARI_REF_NO { get; set; }
        public string ADRES { get; set; }
        public string SEHIR { get; set; }
        public string ILCE { get; set; }
        public string IL { get; set; }
        public string POSTAKODU { get; set; }
        public int? CUSR_ID { get; set; }
        public int? UUSR_ID { get; set; }
        public DateTime? UDATE { get; set; }
        public string ENLEM { get; set; }
        public string BOYLAM { get; set; }


    }
}
