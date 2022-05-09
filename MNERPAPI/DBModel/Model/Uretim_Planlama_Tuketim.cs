using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Uretim_Planlama_Tuketim : BaseEntity {

public int? Uret_Plan_Tuk_ID{get;set;}
public int? Operasyon_ID{get;set;}
public int? Tuk_Malz_ID{get;set;}
public int? Uret_Plan_Uret_ID{get;set;}
public int? Uretilen_Malz_ID{get;set;}
public decimal? Tuk_Miktar { get;set;}
public int? Tuk_Brm_ID{get;set;}
public int? Istasyon_ID{get;set;}

             
        }
}
