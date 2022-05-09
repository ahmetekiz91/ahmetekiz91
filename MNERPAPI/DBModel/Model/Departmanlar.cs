using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Departmanlar : BaseEntity
    {

        public int? Depart_ID { get; set; }
        public string Depart_Adi { get; set; }
        public DateTime? CDate { get; set; }


    }
}
