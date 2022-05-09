using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Depart_Gorev_Params : BaseEntity
    {

        public int? Depart_Gorev_Params_ID { get; set; }
        public DateTime? CDate { get; set; }
        public int? Param_ID { get; set; }
        public string Deger { get; set; }
        public string Tipi { get; set; }
        public int? Depart_Gorev_ID { get; set; }
        public string Formul { get; set; }


    }
}
