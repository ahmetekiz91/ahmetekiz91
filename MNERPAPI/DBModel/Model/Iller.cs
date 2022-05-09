using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Iller : BaseEntity {

public int? Sehir_ID{get;set;}
public string Sehir_Adi {get;set;}
public DateTime? CDate{get;set;}
public int? Ulke_ID{get;set;}

             
        }
}
