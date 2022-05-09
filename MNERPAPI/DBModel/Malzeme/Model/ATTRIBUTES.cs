using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class ATTRIBUTES : BaseEntity
    {

        public int? ATT_ID { get; set; }
        public string ATTCODE { get; set; }
        public string ATTDESCRIBTION { get; set; }
        public string VIEWNAME { get; set; }
        public string SYNTAX { get; set; }


    }
}
