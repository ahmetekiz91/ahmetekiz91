using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_ROTA : BaseEntity {

public int? MALZ_ROT_ID{get;set;}
public int? MALZ_ID{get;set;}
public int? OPE_ID{get;set;}
public int? SIRA{get;set;}
public DateTime? CDATE{get;set;}
public int? TUK_MALZ_ID{get;set;}
public int? BRM_ID{get;set;}
public decimal? MIKTAR { get;set;}

             
        }
}
