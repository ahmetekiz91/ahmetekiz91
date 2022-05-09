using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Talepler_Params : BaseEntity {

public int? Tlp_Param_ID{get;set;}
public int? TLP_ID{get;set;}
public int? Param_ID{get;set;}
public DateTime? CDate{get;set;}
public string Tipi {get;set;}
public string Deger {get;set;}
public string Formul {get;set;}

             
        }
}
