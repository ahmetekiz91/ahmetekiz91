using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sip_Kalem_Params : BaseEntity {

public int? Sip_Kalem_Par_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Param_ID{get;set;}
public int? Sip_Kalem_ID{get;set;}
public string Deger {get;set;}
public string Tipi {get;set;}
public string Formul {get;set;}
public int? Malz_ID{get;set;}
public int? SIP_ID{get;set;}
public string Sonuc {get;set;}

             
        }
}
