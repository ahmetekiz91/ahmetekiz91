using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_RECETE : BaseEntity {

public int? REC_ID{get;set;}
public DateTime? CDATE{get;set;}
public int? MALZ_ID{get;set;}
public string RECETE_KODU {get;set;}
public int? AKT_REV_ID{get;set;}

             
        }
}
