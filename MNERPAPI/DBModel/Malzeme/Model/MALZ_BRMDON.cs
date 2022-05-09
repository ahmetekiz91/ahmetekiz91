using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_BRMDON : BaseEntity {

public int? MALZ_BRMDON_ID{get;set;}
public int? MALZ_BIR_REF1{get;set;}
public int? MALZ_BIR_REF2{get;set;}
public decimal? MIKTAR1 { get;set;}
public decimal? MIKTAR2 { get;set;}
public DateTime? CDATE{get;set;}
public int? CUSR_ID{get;set;}
public int? MALZ_ID{get;set;}

             
        }
}
