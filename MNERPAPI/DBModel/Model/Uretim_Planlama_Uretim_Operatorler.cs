using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Uretim_Planlama_Uretim_Operatorler : BaseEntity {

public int? Uretim_Plan_Uret_ID{get;set;}
public int? Per_ID{get;set;}
public int? Vardiya_ID{get;set;}
public string Gorevi {get;set;}

             
        }
}
