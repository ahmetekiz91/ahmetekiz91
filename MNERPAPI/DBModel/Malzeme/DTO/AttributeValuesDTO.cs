using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.DTO
{
    public class AttributeValuesDTO
    {
        public int ID { get; set; }
        public int ATT_ID { get; set; }
        public string VIEWNAME { get; set; }
        public string VALUE { get; set; }
        public bool ACTIVE { get; set; }
        public int BIRIM_ID { get; set; }
        public string BIRIM_ADI { get; set; }

    }
}
