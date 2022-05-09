using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malzeme_Recete_Grup : BaseEntity {

public int? Mal_Rec_Grup_ID{get;set;}
public string Grup_Isim {get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public DateTime? FDate{get;set;}
public DateTime? UDate{get;set;}
public int? Cancelled{get;set;}

             
        }
}
