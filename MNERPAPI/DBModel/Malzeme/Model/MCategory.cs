using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MCategory : BaseEntity {

public int? CAT_ID{get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}
public int? PAR_ID{get;set;}
public string CAT_ADI {get;set;}

             
        }
}
