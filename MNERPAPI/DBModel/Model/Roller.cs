using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Roller : BaseEntity {

public int? Rol_ID{get;set;}
public string Rol_Adi {get;set;}
public DateTime? CDate{get;set;}
public int? Ana_Rol_ID{get;set;}
public string Checkeds {get;set;}

             
        }
}
