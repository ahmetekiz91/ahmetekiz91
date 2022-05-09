using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class DestekTalep : BaseEntity
    {

        public int? ID { get; set; }
        public string Gorev_aciklama { get; set; }
        public string Dokuman { get; set; }
        public string Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public string Durumu { get; set; }
        public DateTime? Bitis_Tarihi { get; set; }
        public DateTime? CDate { get; set; }


    }
}
