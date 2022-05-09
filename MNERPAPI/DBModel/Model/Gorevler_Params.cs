using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Gorevler_Params : BaseEntity {

public int? Gorev_Params_ID{get;set;}
public int? Gorev_ID{get;set;}
public int? CUSR_ID{get;set;}
public string Tipi {get;set;}
public string Deger {get;set;}
public int? Param_ID{get;set;}

             
        }
}
