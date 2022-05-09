using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class CARIKART : BaseEntity
    {

        public int? CARI_ID { get; set; }
        public string CARI_KODU { get; set; }
        public string CARI_UNVAN { get; set; }
        public int? ALICI { get; set; }
        public int? SATICI { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public string SPECODE1 { get; set; }
        public string SPECODE2 { get; set; }
        public string SPECODE3 { get; set; }
        public string SPECODE4 { get; set; }
        public string SPECODE5 { get; set; }
        public string SPECODE6 { get; set; }
        public string SPECODE7 { get; set; }
        public string TEL1 { get; set; }
        public string TEL2 { get; set; }
        public string TEL3 { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string FAX2 { get; set; }
        public int? ULKE_ID { get; set; }
        public int? PLASIYER_ID { get; set; }
        public string VERGINO { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string WEB  { get; set; }
        public int? GRUPID { get; set; }
        public int? ACTIVE { get; set; }
  

    }
}
