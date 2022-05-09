using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Operasyonlar : BaseEntity {

public int? Operasyon_ID{get;set;}
public string Operasyon_Adi {get;set;}
public DateTime? CDate{get;set;}
public int? Istasyon_ID{get;set;}

             
        }
}
