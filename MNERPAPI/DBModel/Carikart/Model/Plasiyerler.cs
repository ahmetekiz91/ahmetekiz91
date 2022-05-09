using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Plasiyerler : BaseEntity
    {

        public int? PLA_ID { get; set; }
        public int? USR_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public DateTime? UDATE { get; set; }
        public string PLADI { get; set; }
        public string PLSOYADI { get; set; }
        public string PLTEL { get; set; }
        public string PLEMAIL { get; set; }


    }
}
