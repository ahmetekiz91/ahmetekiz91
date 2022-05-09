using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class CARIHAREKET : BaseEntity
    {

        public int? CARI_HAR_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? BORC { get; set; }
        public int? ALACAK { get; set; }
        public int? GIRISMI { get; set; }
        public int? CIKISMI { get; set; }
        public int? FTUR_ID { get; set; }
        public int? FIS_ID { get; set; }
        public decimal? TUTAR { get; set; }
        public int? DOV_ID { get; set; }
        public string CEKSENNO { get; set; }
        public string TAHNO { get; set; }
        public string TRANSACTION_ID { get; set; }
        public DateTime? ISLEMTARIHI { get; set; }
        public int? CARI_ID { get; set; }
        public int? FISIDREF { get; set; }
        public int? FISIDREF2 { get; set; }
        public int? FISIDREF3 { get; set; }
        public string ACIKLAMA { get; set; }
        public int? LDOV_ID { get; set; }
        public decimal? KUR1 { get; set; }
        public decimal? KUR2 { get; set; }
        public decimal? STOPAJORAN { get; set; }
        public decimal? STOPAJTUTAR { get; set; }
        public decimal? FONPAYIORAN { get; set; }
        public decimal? FONPAYITUTAR { get; set; }
        public decimal? BRKDVORAN { get; set; }
        public decimal? BRKDVTUTAR { get; set; }
        public decimal? NET { get; set; }
        public decimal? BRUT { get; set; }
        public decimal? KESTUTAR { get; set; }
        public decimal? TOPLAM { get; set; }
        public int? BNK_ID { get; set; }


    }
}
