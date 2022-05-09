using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class TRK_Malz_Attributes : BaseEntity {

public int? ID{get;set;}
public int? TRK_ID{get;set;}
public int? ATT_ID{get;set;}
public string Value {get;set;}
public DateTime? CDate{get;set;}

             
        }
}
