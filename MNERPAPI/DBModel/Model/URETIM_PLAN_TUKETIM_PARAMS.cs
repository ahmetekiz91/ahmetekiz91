using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class URETIM_PLAN_TUKETIM_PARAMS : BaseEntity {

public int? URET_PLAN_TUK_PAR_ID{get;set;}
public DateTime? CDATE{get;set;}
public string TIPI {get;set;}
public int? URET_PLAN_TUK_ID{get;set;}
public int? PARAM_ID{get;set;}
public string DEGER {get;set;}
public int? Tuketilen_Malz_ID{get;set;}
public int? Uret_Malz_ID{get;set;}

             
        }
}
