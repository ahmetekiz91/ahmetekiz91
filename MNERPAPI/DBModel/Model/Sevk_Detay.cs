using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevk_Detay : BaseEntity {

public int? Sevk_Detay_ID{get;set;}
public int? SIP_ID{get;set;}
public int? SIP_FIS_ID{get;set;}
public int? Malz_ID{get;set;}
public decimal? Miktar { get;set;}
public string Turu {get;set;}
public int? Birim_ID{get;set;}
public int? Onaylimi{get;set;}
public int? Sevk_ID{get;set;}
public string Aciklama {get;set;}
public int? SIP_DET_ID_REF{get;set;}

             
        }
}
