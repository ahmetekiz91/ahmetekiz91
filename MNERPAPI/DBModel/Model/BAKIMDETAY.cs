using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BAKIMDETAY : BaseEntity
    {
        public int? BAKD_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? BAK_ID { get; set; }
        public int? MALZ_ID { get; set; }
        public decimal? MIKTAR { get; set; }
        public int? BRM_ID { get; set; }


    }
}
