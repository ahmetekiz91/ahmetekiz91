using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklif_Revizyon_Kalem_Params : BaseEntity {

public int? Teklif_Rev_Kal_Par_ID{get;set;}
public int? Malz_ID{get;set;}
public int? Teklif_Rev_Kal_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Param_ID{get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public string Formul {get;set;}
public int? Revizyon_ID{get;set;}

             
        }
}
