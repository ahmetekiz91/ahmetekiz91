using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malz_Kategorileri : BaseEntity {

public int? Malz_Kat_ID{get;set;}
public DateTime? CDate{get;set;}
public string Malz_Kat_Adi {get;set;}
public int? CUSR_ID{get;set;}

             
        }
}
