using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Depart_Gorevler : BaseEntity
    {

        public int? Gor_Dep_ID { get; set; }
        public DateTime? CDate { get; set; }
        public int? GRV_ID { get; set; }
        public int? Dep_Atayan_Per_ID { get; set; }
        public int? Dep_Atanan_Per_ID { get; set; }
        public int? Grv_Atayan_Dep_ID { get; set; }
        public int? Grv_Atanan_Dep_ID { get; set; }
        public int? Ust_Grv_Atayan_Dep_ID { get; set; }


    }
}
