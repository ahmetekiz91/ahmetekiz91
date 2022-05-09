using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BORDRO : BaseEntity
    {

        public int? BORD_ID { get; set; }
        public string BORDNO { get; set; }
        public string BELGENO { get; set; }
        public DateTime? TARIH { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CARI_ID { get; set; }
        public int? DOV_ID { get; set; }
        public int? TIG_ID { get; set; }
        public int? TUR_ID { get; set; }
        public string GUID { get; set; }
        public int? BNK_ID { get; set; }
        public int? HSP_ID { get; set; }


    }
}
