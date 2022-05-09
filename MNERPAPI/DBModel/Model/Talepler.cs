using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Talepler : BaseEntity {

public int? Talep_ID{get;set;}
public DateTime? Talep_Tarihi{get;set;}
public int? CUSR_ID{get;set;}
public int? Dep_ID{get;set;}
public int? Donustumu{get;set;}
public string Aciklama {get;set;}

             
        }
}
