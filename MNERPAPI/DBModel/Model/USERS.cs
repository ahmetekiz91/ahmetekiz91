using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class USERS : BaseEntity
    {

        public int? USR_ID { get; set; }
        public DateTime? CDate { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASS { get; set; }
        public string Hash { get; set; }
        public string USERN { get; set; }


    }
}