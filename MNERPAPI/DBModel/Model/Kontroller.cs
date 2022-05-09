using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Kontroller : BaseEntity {

public int? Kont_ID{get;set;}
public DateTime? CDate{get;set;}
public string Isim {get;set;}
public string Soyisim {get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? USR_ID{get;set;}
public int? CUSR_ID{get;set;}
public int? FIS_ID{get;set;}
public int? Cancelled{get;set;}

             
        }
}
