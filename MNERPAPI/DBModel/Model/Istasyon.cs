using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Istasyon : BaseEntity {

public int? Istasyon_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Hat_ID{get;set;}
public string Istasyon_Adi {get;set;}
public int? Bolge_ID{get;set;}

             
        }
}
