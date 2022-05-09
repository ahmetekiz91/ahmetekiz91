using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.DTO
{
    public class CARIKARTDTO
    {

        public int? CARI_ID { get; set; }
        public string CARI_KODU { get; set; }
        public string CARI_UNVAN { get; set; }
        public bool ALICI { get; set; }
        public bool SATICI { get; set; }
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
        public string ULKE_ADI { get; set; }
        public int? PLASIYER_ID { get; set; }
        public string PLASIYER_ADI { get; set; }
        public string VERGINO { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string WEB { get; set; }
        public int? GRUPID { get; set; }
        public bool ACTIVE { get; set; }
        public string GRUPADI { get; set; }
    }
}
