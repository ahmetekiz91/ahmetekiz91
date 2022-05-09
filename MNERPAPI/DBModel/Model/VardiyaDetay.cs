using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class VardiyaDetay : BaseEntity {

public int? Var_Det_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Var_ID{get;set;}
public int? Istasyon_ID{get;set;}
public int? Operasyon_ID{get;set;}
public int? Bolge_ID{get;set;}
public int? Hat_ID{get;set;}
public DateTime? UBas{get;set;}
public DateTime? UBit{get;set;}

             
        }
}
