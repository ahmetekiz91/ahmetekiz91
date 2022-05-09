using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Mal_Alim : BaseEntity {

public int? Mal_Alim_ID{get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public int? FIS_ID{get;set;}
public string GUID1 {get;set;}
public string GUID2 {get;set;}
public DateTime? Giris_Tarihi{get;set;}

             
        }
}
