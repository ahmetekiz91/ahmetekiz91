using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Logs : BaseEntity {

public int? Log_ID{get;set;}
public string IP {get;set;}
public DateTime? CDate{get;set;}
public string Kim {get;set;}
public string Ne {get;set;}
public string Aciklama {get;set;}
public int? Cancelled{get;set;}

             
        }
}
