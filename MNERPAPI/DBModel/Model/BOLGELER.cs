using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{
    public class BOLGELER : BaseEntity
    {

        public int? Bolge_ID { get; set; }
        public DateTime? CDate { get; set; }
        public string Bolge_Adi { get; set; }
        public int? Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }


    }
}
