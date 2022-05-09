using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class BAKIM : BaseEntity {

public int? BAK_ID{get;set;}
public DateTime? CDATE{get;set;}
public string ACIKLAMA {get;set;}
public int? ISTASYON_ID{get;set;}
public string TURU {get;set;}
public DateTime? BAS{get;set;}
public DateTime? BIT{get;set;}
public int? ISOK{get;set;}

             
        }
}
