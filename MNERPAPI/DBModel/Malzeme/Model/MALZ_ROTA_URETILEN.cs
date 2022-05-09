using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_ROTA_URETILEN : BaseEntity {

public int? URE_ID{get;set;}
public int? URTM_ID{get;set;}
public string LOTNO {get;set;}
public int? IST_ID{get;set;}
public int? YMAMUL_ID{get;set;}
public decimal? URMIKTAR { get;set;}
public int? MAMUL_BRM{get;set;}
public int? PER_ID{get;set;}
public decimal? FIRE { get;set;}
public int? FRBRM{get;set;}
public int? VAR_ID{get;set;}
public int? VAR_DET_ID{get;set;}
public int? OPE_ID{get;set;}
public int? SIRA{get;set;}
public decimal? HAZ_SURE { get;set;}
public int? HAZ_BRM{get;set;}
public int? URE_BRM{get;set;}
public decimal? URE_SURE { get;set;}
public string ACIKLAMA {get;set;}
public DateTime? CDATE{get;set;}
public DateTime? UBas{get;set;}
public DateTime? UBit{get;set;}
public DateTime? HBas{get;set;}
public DateTime? HBit{get;set;}
public int? URE_ID_REF{get;set;}
public int? URT_PLAN_URE_ID{get;set;}

             
        }
}
