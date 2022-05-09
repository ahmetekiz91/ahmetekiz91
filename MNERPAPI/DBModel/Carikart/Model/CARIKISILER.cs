using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class CARIKISILER : BaseEntity
    {

        public int? Kisi_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public DateTime? UDATE { get; set; }
        public int? USR_ID { get; set; }
        public int? CUSR_ID { get; set; }
        public int? CARI_ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string TELEFON1 { get; set; }
        public string TELEFON2 { get; set; }
        public string TELEFON3 { get; set; }
        public string EMALIL { get; set; }
        public string POZISYON { get; set; }


    }
}
