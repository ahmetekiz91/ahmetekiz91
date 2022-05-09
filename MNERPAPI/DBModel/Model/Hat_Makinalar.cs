using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Hat_Makinalar : BaseEntity {

public int? Hat_Mak_ID{get;set;}
public int? Hat_ID{get;set;}
public int? Bolge_ID{get;set;}
public string Hat_Mak_Kodu {get;set;}
public string İşlevi {get;set;}

             
        }
}
