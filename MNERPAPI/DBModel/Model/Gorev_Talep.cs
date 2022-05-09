using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Gorev_Talep : BaseEntity {

public int? Gorev_ID{get;set;}
public DateTime? CDate{get;set;}
public DateTime? Tarih{get;set;}
public DateTime? Son_Tarih{get;set;}
public int? Gor_Dur_Id{get;set;}
public int? Tlp_Edil_Per_ID{get;set;}
public int? Dep_ID{get;set;}
public int? Tlp_Edil_Dep_ID{get;set;}
public int? Talep_eden_Per_ID{get;set;}
public int? CUSR_ID{get;set;}
public string Aciklama {get;set;}

             
        }
}
