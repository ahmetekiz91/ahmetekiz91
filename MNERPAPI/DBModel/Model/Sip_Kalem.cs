using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sip_Kalem : BaseEntity {

public int? Sip_Kal_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Sip_ID{get;set;}
public int? Malz_ID{get;set;}
public decimal? Miktar { get;set;}
public decimal? BrFiyat { get;set;}
public string Aciklama {get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? Sip_Kal_Id_Ref{get;set;}
public int? Brm_ID{get;set;}
public int? Sip_Kal_Id_Ref2{get;set;}
public int? Doviz_ID{get;set;}
public int? Sip_Kal_Id_Ref3{get;set;}
public decimal? Satir_Toplam { get;set;}

             
        }
}
