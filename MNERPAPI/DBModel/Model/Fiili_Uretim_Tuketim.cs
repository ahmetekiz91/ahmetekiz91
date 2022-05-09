using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Fiili_Uretim_Tuketim : BaseEntity
    {

        public int? Fil_Uret_Tuk_ID { get; set; }
        public DateTime? CDate { get; set; }
        public int? Uretim_ID { get; set; }
        public int? Tuk_Malz_ID { get; set; }
        public decimal? Miktar { get; set; }
        public int? CUSR_ID { get; set; }
        public DateTime? UDate { get; set; }
        public DateTime? FDate { get; set; }
        public int? FIS_ID { get; set; }
        public int? SIP_ID { get; set; }
        public int? Cancelled { get; set; }


    }
}
