using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Giderler : BaseEntity
    {

        public int? GID_ID { get; set; }
        public DateTime? CDate { get; set; }
        public string GID_ADI { get; set; }
        public string MUH_KODU { get; set; }


    }
}
