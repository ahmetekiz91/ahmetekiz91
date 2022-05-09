using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malz_Hareket : BaseEntity {

public int? Malz_Har_ID{get;set;}
public DateTime? CDate{get;set;}
public int? FIS_ID{get;set;}
public int? Malz_ID{get;set;}
public int? Satinalmami{get;set;}
public int? Satismi{get;set;}
public int? Girismi{get;set;}
public int? Cikismi{get;set;}
public int? Turu{get;set;}
public decimal? Miktar { get;set;}
public int? Birim_ID{get;set;}
public int? Depo_ID{get;set;}
public int? CUSR_ID{get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? Fis_Id_Ref{get;set;}
public int? Fis_Id_Ref_2{get;set;}
public int? Fis_Id_Ref_3{get;set;}
public string Aciklama {get;set;}
public string GUID1 {get;set;}
public string GUID2 {get;set;}
public int? IST_ID{get;set;}

             
        }
}
