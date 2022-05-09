using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;
using Newtonsoft.Json;

namespace DBModel.Model
{
    public class ANAROLLER : BaseEntity
    {
        [JsonProperty("ANA_ROL_ID")]
        public int? ANA_ROL_ID { get; set; }
        [JsonProperty("CDATE")]
        public DateTime? CDATE { get; set; }  
        [JsonProperty("UDATE")]
        public DateTime? UDATE { get; set; }
        [JsonProperty("ROL_ADI")]
        public string ROL_ADI { get; set; }


    }
}
