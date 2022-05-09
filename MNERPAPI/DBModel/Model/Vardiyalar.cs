using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Vardiyalar : BaseEntity {

public int? Var_ID{get;set;}
public DateTime? CDate{get;set;}
public string Gun_Adi {get;set;}
public DateTime? Tarih{get;set;}

             
        }
}
