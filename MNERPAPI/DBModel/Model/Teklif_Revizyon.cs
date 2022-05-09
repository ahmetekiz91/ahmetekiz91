using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Teklif_Revizyon : BaseEntity {

public int? Tek_Rev_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Teklif_ID{get;set;}
public int? Revizyon_No{get;set;}
public DateTime? Teklif_Tarihi{get;set;}
public DateTime? Termin_Tarihi{get;set;}
public int? Tes_Tur_ID{get;set;}
public int? Ode_Tur_ID{get;set;}
public int? CUSR_ID{get;set;}
public string Aciklama {get;set;}

             
        }
}
