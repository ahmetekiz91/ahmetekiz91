using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class CARIGRUPLAR : BaseEntity
    {

        public int? CARI_GRUP_ID { get; set; }
        public string ADI { get; set; }
        public string KODU { get; set; }
        public DateTime? CDATE { get; set; }
        public int? CUSR_ID { get; set; }
        public DateTime? UDATE { get; set; }
        public int? UUSR_ID { get; set; }


    }
}
