using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class FIS_HAREKET : BaseEntity
    {

        public int? FIS_LINE_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? MALZ_ID { get; set; }
        public decimal? MIKTAR { get; set; }
        public int? BRM_ID { get; set; }
        public int? SATIR_NO { get; set; }
        public int? FIS_ID { get; set; }
        public int? FIS_REF_ID { get; set; }
        public int? FIS_TUR_ID { get; set; }
        public decimal? BRM_FYT { get; set; }
        public decimal? KDV_ORAN { get; set; }
        public decimal? KDV { get; set; }
        public decimal? TUTAR { get; set; }
        public int? DOV_ID { get; set; }
        public int? SOZ_ID { get; set; }
        public int? FATURALANDI { get; set; }
        public string SIP_NO { get; set; }
        public string TURU { get; set; }
        public string ACIKLAMA { get; set; }
        public string ACIKLAMA1 { get; set; }
        public string ACIKLAMA2 { get; set; }
        public string ACIKLAMA3 { get; set; }
        public string ACIKLAMA5 { get; set; }
        public string ACIKLAMA6 { get; set; }
        public int? HZM_ID { get; set; }
        public int? LDOV_ID { get; set; }
        public decimal? KUR1 { get; set; }
        public decimal? KUR2 { get; set; }
        public string MAS_KODU { get; set; }
        public int? MAS_ID { get; set; }
        public string MALZMUHKODU { get; set; }
        public DateTime? UDATE { get; set; }
        public int? UUSR_ID { get; set; }
        public string STATUS { get; set; }


    }
}
