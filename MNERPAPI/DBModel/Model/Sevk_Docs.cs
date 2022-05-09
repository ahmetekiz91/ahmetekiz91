using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevk_Docs : BaseEntity {

public int? Doc_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Sevk_ID{get;set;}
public string FPath {get;set;}
public int? Ruhsat_mi{get;set;}
public int? Ehliyet_mi{get;set;}
public int? Konsimento_mu{get;set;}
public int? CUSR_ID{get;set;}
public string test {get;set;}
public int? Cancelled{get;set;}

             
        }
}
