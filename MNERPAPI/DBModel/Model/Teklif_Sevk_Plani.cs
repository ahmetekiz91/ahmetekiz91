using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklif_Sevk_Plani : BaseEntity {

public int? Sevk_Plan_ID{get;set;}
public int? Teklif_ID{get;set;}
public string Gonderim_Turu {get;set;}
public int? Teslimat_Turu{get;set;}
public string Teslimat_Yeri {get;set;}
public int? Tas_Fir_ID{get;set;}
public decimal? Fiyat { get;set;}
public string Container_No {get;set;}
public string Aciklama {get;set;}
public string IMO_NO {get;set;}
public string Plaka_No {get;set;}
public string Asama_No {get;set;}
public string Bas_Nok {get;set;}
public string Bit_Nok {get;set;}
public DateTime? CDate{get;set;}
public DateTime? Tarih{get;set;}
public int? Doviz_ID{get;set;}

             
        }
}
