using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BORDRO_BORCLU_KISI : BaseEntity
    {

        public int? SEN_BORC_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public string ADRES { get; set; }
        public string SEMT { get; set; }
        public string POSTA_KODU { get; set; }
        public string TELEFON { get; set; }
        public string ILCE { get; set; }
        public string IL { get; set; }
        public string TELEFON2 { get; set; }
        public string GSM { get; set; }
        public string ULKR { get; set; }
        public string UNVAN { get; set; }


    }
}
