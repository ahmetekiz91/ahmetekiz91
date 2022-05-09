using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Ulkeler : BaseEntity {

public int? Ulke_ID{get;set;}
public string Ulke_Adi {get;set;}
public string Ulke_Kodu {get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public int? Cancelled{get;set;}

             
        }
}
