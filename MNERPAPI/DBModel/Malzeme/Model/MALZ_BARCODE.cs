using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class MALZ_BARCODE : BaseEntity {

public int? MALZ_BAR_ID{get;set;}
public int? MALZ_ID{get;set;}
public int? MBRM_ID{get;set;}
public string BARCODE {get;set;}
public DateTime? CDate{get;set;}
public int? CUSR_ID{get;set;}

             
        }
}
