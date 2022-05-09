using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Muhasebe_Hesaplari : BaseEntity {

public int? MUH_HSP_ID{get;set;}
public string MUH_KODU {get;set;}
public DateTime? CDATE{get;set;}
public string HSP_ADI {get;set;}

             
        }
}
