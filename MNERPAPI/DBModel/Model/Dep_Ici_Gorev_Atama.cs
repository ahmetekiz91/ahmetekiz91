using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Dep_Ici_Gorev_Atama : BaseEntity
    {

        public int? Gorev_Atanan_Dep_ID { get; set; }
        public int? Birime_Atayan_Id { get; set; }
        public int? Birimden_Atayan_ID { get; set; }
        public int? Gorev_Atanan_ID { get; set; }
        public int? Gorev_ID { get; set; }
        public int? Gorevi_Atayan_Dep_ID { get; set; }
        public DateTime? CDate { get; set; }


    }
}
