using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BIRIMLER : BaseEntity
    {

        public int? BRM_ID { get; set; }
        public string BRM_ADI { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public string TURU { get; set; }
        public int? AGOLC_BRM { get; set; }
        public int? HAC_OLC_BRM { get; set; }


    }
}
