using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class DovizTurleri : BaseEntity
    {

        public int? DOV_ID { get; set; }
        public string Adi { get; set; }
        public DateTime? CDate { get; set; }
        public string Aciklama { get; set; }


    }
}
