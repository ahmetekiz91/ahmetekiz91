using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Malzeme_Attribute : BaseEntity {

public int? ID{get;set;}
public DateTime? CDate{get;set;}
public int? Att_ID{get;set;}
public int? Malz_ID{get;set;}
public string AttValue {get;set;}

             
        }
}
