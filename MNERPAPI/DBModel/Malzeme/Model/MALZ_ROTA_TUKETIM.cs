using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_ROTA_TUKETIM : BaseEntity {

public int? MRU_TUK_ID{get;set;}
public string LOTNO {get;set;}
public int? URTM_ID{get;set;}
public int? URTLN_ID{get;set;}
public int? TUK_MALZ_ID{get;set;}
public decimal? TUK_MIKTAR { get;set;}
public int? TUK_BRM_ID{get;set;}
public decimal? FIRE { get;set;}
public int? FRBRM{get;set;}
public decimal? ONMIKTAR { get;set;}
public int? ONMIKTAR_BRM{get;set;}
public DateTime? CDATE{get;set;}

             
        }
}
