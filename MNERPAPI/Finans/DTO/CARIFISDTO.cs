using DBModel.Model;
using DBModel.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINANS
{
    public class CARIFISDTO : BaseEntity
    {
        public FISLER fisler { get; set; }
        public List<CARIHAREKET> chlist { get; set; }
    }
}
