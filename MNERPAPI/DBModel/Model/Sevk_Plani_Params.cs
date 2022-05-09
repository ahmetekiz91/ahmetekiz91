using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevk_Plani_Params : BaseEntity {

public int? Sevk_Plani_Params_ID{get;set;}
public int? Sevk_Plani_ID{get;set;}
public int? Params_ID{get;set;}
public string Formul {get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public string Sonuc {get;set;}
public DateTime? CDate{get;set;}

             
        }
}
