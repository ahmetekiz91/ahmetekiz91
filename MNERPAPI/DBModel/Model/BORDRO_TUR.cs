using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BORDRO_TUR : BaseEntity
    {

        public int? BORD_TUR_ID { get; set; }
        public DateTime? CDATE { get; set; }
        public string TUR_ADI { get; set; }


    }
}
