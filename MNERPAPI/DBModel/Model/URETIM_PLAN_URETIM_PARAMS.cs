using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class URETIM_PLAN_URETIM_PARAMS : BaseEntity {

public int? URET_PLAN_URET_PAR_ID{get;set;}
public int? URET_PLAN_URET_ID{get;set;}
public int? PARAM_ID{get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public int? Uretilen_Malz_ID{get;set;}

             
        }
}
