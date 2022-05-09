using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Uretim_Planlama_Uretim : BaseEntity {

public int? Uret_Plan_Uret_ID{get;set;}
public DateTime? Tarih{get;set;}
public int? Uretim_Emir_ID{get;set;}
public int? Istasyon_ID{get;set;}
public int? Malz_ID{get;set;}
public int? Vardiya_Bas_ID{get;set;}
public int? Var_Bas_Det_ID{get;set;}
public int? Uret_Malz_ID{get;set;}
public decimal? Uret_Miktar { get;set;}
public int? Uret_Malz_Birim_ID{get;set;}
public int? Operasyon_ID{get;set;}
public int? Bolge_ID{get;set;}
public int? Pers_ID{get;set;}
public int? Hat_ID{get;set;}
public DateTime? UBas{get;set;}
public DateTime? UBit{get;set;}
public int? Vardiya_Bit_ID{get;set;}
public int? Var_Bit_Det_ID{get;set;}
public int? MALZ_ROT_ID{get;set;}
public int? MALZ_ROT_IST_ID{get;set;}
public int? SIRA{get;set;}
public decimal? HAZ_SURE { get;set;}
public int? HAZ_BIR{get;set;}
public decimal? URE_SURE { get;set;}
public int? URE_BIR{get;set;}

             
        }
}
