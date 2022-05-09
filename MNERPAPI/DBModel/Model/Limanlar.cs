using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Limanlar : BaseEntity {

public int? Liman_ID{get;set;}
public DateTime? CDate{get;set;}
public string Liman_Adi {get;set;}
public int? CUSR_ID{get;set;}
public int? Cancelled{get;set;}
public string Aciklama {get;set;}

             
        }
}
