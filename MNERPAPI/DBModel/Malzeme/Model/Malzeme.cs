using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Malzeme : BaseEntity
    {

        public int? MALZ_ID { get; set; }
        public string MALZ_KODU { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public string MALZ_ISIM { get; set; }
        public int? DEPO_ID { get; set; }
        public decimal? AGIRLIK { get; set; }
        public decimal? EN { get; set; }
        public decimal? BOY { get; set; }
        public decimal? YUKSEKLIK { get; set; }
        public int? SABLON_MU { get; set; }
        public string OZELKOD { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
        public string OZELKOD4 { get; set; }
        public string OZELKOD5 { get; set; }
        public int? ALIS_GRUBUMU { get; set; }
        public int? SATIS_GRUBUMU { get; set; }
        public int? MALZ_KAT_ID { get; set; }
        public string EAN { get; set; }
        public string FIRMA_KODU { get; set; }
        public int? BRM_ID { get; set; }
        public int? TEKLIF_GRUP_ID { get; set; }
        public int? PARENT_MI { get; set; }
        public string MALZ_ISIM_ENG { get; set; }
        public int? MARKA_ID { get; set; }
        public string GTIP { get; set; }
        public int? DOVIZ_ID { get; set; }
        public decimal? SATIS_FIYAT { get; set; }
        public decimal? ISKONTO { get; set; }
        public decimal? ISKONTO2 { get; set; }
        public decimal? ISKONTO3 { get; set; }
        public decimal? ISKONTO4 { get; set; }
        public int? RECETE_GRUP_ID { get; set; }
        public int? YMAMUL { get; set; }
        public int? SONURUN { get; set; }
        public int? SARF { get; set; }


    }
}
