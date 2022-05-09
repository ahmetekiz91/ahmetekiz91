using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Ilceler : BaseEntity {

public int? Ilce_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Sehir_ID{get;set;}
public string Ilce_Adi {get;set;}
public int? Cancelled{get;set;}

             
        }
}
