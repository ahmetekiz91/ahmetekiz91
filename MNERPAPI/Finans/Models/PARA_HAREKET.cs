using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace FINANS.Model
{
    public class PARA_HAREKET : BaseEntity
    {

        public int? TRA_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public DateTime? TARIH { get; set; }
        public decimal? TUTAR { get; set; }
        public int? DOV_ID { get; set; }
        public int? LDOV_ID { get; set; }
        public int? BORC { get; set; }
        public int? ALACAK { get; set; }
        public int? GIRIS { get; set; }
        public int? CIKIS { get; set; }
        public decimal? KUR1 { get; set; }
        public decimal? KUR2 { get; set; }
        public int? CKSN_ID { get; set; }
        public int? BNK_ID { get; set; }
        public int? HSP_ID { get; set; }
        public int? CARI_ID { get; set; }
        public int? KASA_ID { get; set; }
        public int? MSF_ID { get; set; }
        public int? FIS_ID { get; set; }
        public int? BORD_ID { get; set; }
        public int? TUR_ID { get; set; }
        public string  TRANSACTION_ID { get; set; }


    }
}
