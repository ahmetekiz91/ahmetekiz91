using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Hatlar : BaseEntity {

public int? Hat_ID{get;set;}
public DateTime? CDate{get;set;}
public DateTime? UDate{get;set;}
public string Hat_Kodu {get;set;}
public string Hat_Adi {get;set;}
public int? Bolge_ID{get;set;}

             
        }
}
