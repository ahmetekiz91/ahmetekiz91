using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malz_Docs : BaseEntity {

public int? Malz_Dok_ID{get;set;}
public DateTime? CDate{get;set;}
public string DocName {get;set;}
public int? Malz_ID{get;set;}
public int? Cancelled{get;set;}

             
        }
}
