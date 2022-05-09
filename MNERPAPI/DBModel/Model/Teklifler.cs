using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklifler : BaseEntity {

public int? Teklif_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Cari_ID{get;set;}
public int? Satismi{get;set;}
public int? Satinalmami{get;set;}
public int? Sip_Donusen_ID{get;set;}
public int? Sip_Donustumu{get;set;}
public int? CUSR_ID{get;set;}
public string Aciklama {get;set;}
public int? Doviz_ID{get;set;}
public int? Talep_ID{get;set;}
public string Turu {get;set;}

             
        }
}
