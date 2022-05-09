using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MUH_HAREKET : BaseEntity {

public int? MUH_HAR_ID{get;set;}
public DateTime? CDATE{get;set;}
public string HSP_KOD {get;set;}
public int? DOV_ID{get;set;}
public int? TUR_ID{get;set;}
public decimal? KUR1 { get;set;}
public decimal? KUR2 { get;set;}
public int? LDOV_ID{get;set;}
public int? BORC{get;set;}
public int? ALACAK{get;set;}
public int? CARI_ID{get;set;}
public int? KASA_ID{get;set;}
public int? BANKA_ID{get;set;}
public int? MALZ_ID{get;set;}
public int? BRM_ID{get;set;}
public decimal? MIKTAR { get;set;}
public decimal? BRM_FYT { get;set;}
public decimal? TUTAR { get;set;}

             
        }
}
