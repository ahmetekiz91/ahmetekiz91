using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_ROTA_URETIM : BaseEntity {

public int? MAL_ROT_URTM_ID{get;set;}
public int? SIP_ID{get;set;}
public int? SIP_KAL_ID{get;set;}
public string LOT_NO {get;set;}
public int? ISOK{get;set;}
public int? OUSR_ID{get;set;}
public DateTime? ODATE{get;set;}
public DateTime? CDATE{get;set;}
public int? PLAN_ID{get;set;}
public int? MALZ_ID{get;set;}
public decimal? URMIKTAR { get;set;}
public int? BRM_ID{get;set;}
public decimal? FIRE { get;set;}
public int? FRBRM{get;set;}
public string Aciklama {get;set;}
public int? URE_ID_REF{get;set;}

             
        }
}
