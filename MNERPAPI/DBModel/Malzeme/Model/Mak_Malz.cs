using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Mak_Malz : BaseEntity {

public int? Malz_Mak_ID{get;set;}
public int? Malz_ID{get;set;}
public int? Mak_ID{get;set;}
public string Br_Uret_Sur {get;set;}
public DateTime? CDate{get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? Cancelled{get;set;}

             
        }
}
