using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Talep_Detay_Params : BaseEntity {

public int? TLP_DET_PAR_ID{get;set;}
public int? TLP_ID{get;set;}
public int? TLP_DET_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Param_ID{get;set;}
public int? Formul_ID{get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public string Sonuc {get;set;}
public int? Malz_ID{get;set;}

             
        }
}
