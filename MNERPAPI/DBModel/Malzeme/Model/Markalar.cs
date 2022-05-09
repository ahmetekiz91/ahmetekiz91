using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Markalar : BaseEntity {

public int? Marka_ID{get;set;}
public string Marka_Adi {get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public int? Cancelled{get;set;}
public int? Oncelik{get;set;}

             
        }
}
