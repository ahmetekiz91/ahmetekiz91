using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevkiyat_Params : BaseEntity {

public int? Sevkiyat_Params_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Param_ID{get;set;}
public int? Sevkiyat_ID{get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public string Formul {get;set;}

             
        }
}
