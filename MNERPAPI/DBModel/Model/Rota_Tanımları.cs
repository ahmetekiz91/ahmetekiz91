using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Rota_Tanımları : BaseEntity {

public int? Rota_Tanim_ID{get;set;}
public string Asama_Adi {get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}

             
        }
}
