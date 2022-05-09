using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class Gorev_Durumlar : BaseEntity
    {

        public int? Gorev_Dur_ID { get; set; }
        public string Aciklama { get; set; }
        public DateTime? CDate { get; set; }


    }
}
