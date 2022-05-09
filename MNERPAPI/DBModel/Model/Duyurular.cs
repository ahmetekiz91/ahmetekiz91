using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Duyurular : BaseEntity
    {

        public int? Duy_ID { get; set; }
        public DateTime? CDate { get; set; }
        public string Mesaj { get; set; }
        public int? Yay_ID { get; set; }
        public string Baslik { get; set; }


    }
}
