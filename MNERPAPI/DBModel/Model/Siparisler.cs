using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Siparisler : BaseEntity {

public int? Sip_ID{get;set;}
public DateTime? CDate{get;set;}
public int? FIS_ID{get;set;}
public int? Teklif_ID{get;set;}
public DateTime? Sip_Tarihi{get;set;}
public int? Cari_ID{get;set;}
public int? Alismi{get;set;}
public int? Satismi{get;set;}
public int? CUSR_ID{get;set;}
public int? Doviz_ID{get;set;}
public int? Kapalimi{get;set;}
public string Turu {get;set;}

             
        }
}
