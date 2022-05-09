using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Talep_Detay : BaseEntity {

public int? TLP_DET_ID{get;set;}
public int? TLP_ID{get;set;}
public int? Stok_ID{get;set;}
public decimal? Miktar { get;set;}
public int? Birim_ID{get;set;}
public string Aciklama {get;set;}
public DateTime? CDate{get;set;}
public DateTime? UDate{get;set;}

             
        }
}
