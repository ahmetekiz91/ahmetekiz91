using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Fiili_Uretim : BaseEntity
    {

        public int? Fiil_Uret_ID { get; set; }
        public DateTime? CDate { get; set; }
        public DateTime? Bas_Tar { get; set; }
        public DateTime? Bit_Tar { get; set; }
        public int? CUSR_ID { get; set; }
        public int? Mak_ID { get; set; }
        public DateTime? UDate { get; set; }
        public DateTime? FDate { get; set; }
        public int? Malz_ID { get; set; }
        public decimal? Uret_Miktar { get; set; }
        public int? Uret_Emir_Id { get; set; }
        public int? FIS_ID { get; set; }
        public int? SIP_ID { get; set; }
        public int? Depoya_Aktarildimi { get; set; }
        public int? Satis_FIS_ID { get; set; }
        public decimal? Nem { get; set; }
        public decimal? Sicaklik { get; set; }
        public decimal? Gramaj { get; set; }
        public int? Cancelled { get; set; }


    }
}
