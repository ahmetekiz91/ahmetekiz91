using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Vardiya_Kisiler : BaseEntity {

public int? Vardiya_Kisi_ID{get;set;}
public int? Vardiya_ID{get;set;}
public int? Vard_Det_ID{get;set;}
public int? Pers_ID{get;set;}
public string Aciklama {get;set;}
public int? Gorev_ID{get;set;}
public DateTime? CAL_BAS{get;set;}
public DateTime? CAL_BIT{get;set;}
public int? IST_ID{get;set;}

             
        }
}
