using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklif_Revizyon_Kalem : BaseEntity {

public int? Teklif_Rev_Kal_ID{get;set;}
public int? Doviz_ID{get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public int? Revizyon_ID{get;set;}
public int? Malz_Id{get;set;}
public int? Brm_ID{get;set;}
public decimal? Miktar { get;set;}
public decimal? Brm_Fyt { get;set;}
public int? TLP_ID{get;set;}
public string Aciklama {get;set;}
public int? Satis_Fis_Ref_ID{get;set;}

             
        }
}
