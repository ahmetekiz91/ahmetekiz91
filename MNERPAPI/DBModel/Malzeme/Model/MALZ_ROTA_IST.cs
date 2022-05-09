using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_ROTA_IST : BaseEntity {

public int? MALZ_ROT_IST_ID{get;set;}
public int? MALZ_ROT_ID{get;set;}
public int? IST_ID{get;set;}
public decimal? HAZ_SURE { get;set;}
public int? HAZ_BIR{get;set;}
public decimal? URE_SURE { get;set;}
public int? URE_BIR{get;set;}

             
        }
}
