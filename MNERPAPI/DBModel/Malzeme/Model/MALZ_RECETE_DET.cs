using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_RECETE_DET : BaseEntity {

public int? MALZ_REC_DET_ID{get;set;}
public DateTime? CDATE{get;set;}
public int? TUK_MALZ_ID{get;set;}
public decimal? TUK_MALZ_MIKTAR { get;set;}
public int? TUK_MALZ_BIRIM{get;set;}
public decimal? TUK_MALZ_FIRE_MIKTAR { get;set;}
public int? TUK_MALZ_FIRE_BIRIM{get;set;}
public int? KLON_REC_ID{get;set;}
public int? SABLON_ID{get;set;}
public int? OPE_ID{get;set;}
public int? YMAL_ID{get;set;}
public decimal? YMAL_MIKTAR { get;set;}
public int? YMAL_BRM{get;set;}
public decimal? YMAL_FIRE_MIKTAR { get;set;}
public int? YMAL_FIRE_BIRIM{get;set;}
public string TURU {get;set;}
public int? REV_ID{get;set;}

             
        }
}
