using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Makinalar : BaseEntity {

public int? Mak_ID{get;set;}
public string Mak_Kodu {get;set;}
public string Aciklama {get;set;}
public int? CUSR_ID{get;set;}
public DateTime? CDate{get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? Cancelled{get;set;}

             
        }
}
