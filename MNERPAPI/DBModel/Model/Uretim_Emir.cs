using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Uretim_Emir : BaseEntity {

public int? Ure_Emri_Id{get;set;}
public int? Uretim_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Malz_ID{get;set;}
public DateTime? Tarih{get;set;}
public int? SIP_ID{get;set;}
public int? FIS_ID{get;set;}
public int? Uret_Onay{get;set;}
public int? CUSR_ID{get;set;}
public int? OUSR_ID{get;set;}
public int? SIP_KAL_ID{get;set;}
public DateTime? Onay_Date{get;set;}
public decimal? Miktar { get;set;}
public int? BRM_ID{get;set;}

             
        }
}
