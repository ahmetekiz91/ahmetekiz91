using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class BORDROHAREKET : BaseEntity {

public int? BORD_HAR_ID{get;set;}
public DateTime? CDATE{get;set;}
public DateTime? VADE_TAR{get;set;}
public int? CARI_ID{get;set;}
public int? DOV_ID{get;set;}
public decimal? TUTAR { get;set;}
public int? LDOV_ID{get;set;}
public decimal? KUR1 { get;set;}
public decimal? KUR2 { get;set;}
public int? BORD_ID{get;set;}
public int? TUR_ID{get;set;}
public DateTime? ISLEM_TAR{get;set;}
public int? CEKSEN_ID{get;set;}
public string GUID {get;set;}
public int? BNK_ID{get;set;}
public int? HSP_ID{get;set;}
public int? BORCLU_ID{get;set;}
public int? CEKSEN_DUR_ID{get;set;}
public int? UFIS_ID{get;set;}
public DateTime? UDATE{get;set;}
public int? UUSR_ID{get;set;}

             
        }
}
