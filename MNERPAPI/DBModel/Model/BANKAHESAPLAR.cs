using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BANKAHESAPLAR : BaseEntity
    {

        public int? HESAP_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public int? BNK_ID { get; set; }
        public string HESAPKODU { get; set; }
        public string SWIFT { get; set; }
        public int? DVZ_ID { get; set; }
        public string HESAPNO { get; set; }
        public string IBAN { get; set; }
        public string BATCHNO { get; set; }
        public string POSTERMINALNO { get; set; }
        public string HESAPTURU { get; set; }
        public string HESAPADI { get; set; }


    }
}
