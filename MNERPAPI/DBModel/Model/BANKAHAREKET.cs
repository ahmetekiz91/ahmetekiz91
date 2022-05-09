using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BANKAHAREKET : BaseEntity
    {

        public int? BANKA_HAR_ID { get; set; }
        public DateTime? TARIH { get; set; }
        public DateTime? CDATE { get; set; }
        public string HESAPNO { get; set; }
        public string IBAN { get; set; }
        public decimal? TUTAR { get; set; }
        public int? GIREN { get; set; }
        public int? CIKAN { get; set; }
        public int? BORC { get; set; }
        public int? ALACAK { get; set; }
        public int? TUR { get; set; }
        public string BATCH_NO { get; set; }
        public string POS_TERMINALNO { get; set; }
        public int? BANKA_ID { get; set; }
        public int? CARI_ID { get; set; }
        public int? FIS_ID { get; set; }
        public int? HSP_ID { get; set; }
        public string ISLEM_TURU { get; set; }
        public string ACIKLAMA { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
        public string OZELKOD4 { get; set; }
        public string OZELKOD5 { get; set; }
        public string OZELKOD6 { get; set; }
        public int? LDOV_ID { get; set; }
        public int? DOV_ID { get; set; }
        public decimal? KUR1 { get; set; }
        public decimal? KUR2 { get; set; }
        public int? HZM_ID { get; set; }
        public int? FIS_ID_REF { get; set; }
        public int? FIS_ID_REF2 { get; set; }


    }
}
