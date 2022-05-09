using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Gorev_Notlari : BaseEntity {

public int? Grv_Not_Id{get;set;}
public DateTime? CDate{get;set;}
public DateTime? UDate{get;set;}
public int? Gor_Ata_Dep_ID{get;set;}
public int? Dep_Gorev_ID{get;set;}
public string Aciklama {get;set;}

             
        }
}
