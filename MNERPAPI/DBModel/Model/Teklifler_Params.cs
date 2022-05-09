using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklifler_Params : BaseEntity {

public int? Teklif_Param_ID{get;set;}
public string Tipi {get;set;}
public int? Formul{get;set;}
public string Deger {get;set;}
public int? Param_ID{get;set;}
public int? Teklif_ID{get;set;}
public DateTime? CDate{get;set;}

             
        }
}
