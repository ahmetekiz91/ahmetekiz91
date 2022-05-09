using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Mesajlar : BaseEntity {

public int? MSJ_ID{get;set;}
public DateTime? CDate{get;set;}
public string Mesaj {get;set;}
public int? Gon_ID{get;set;}
public int? Alici_ID{get;set;}
public int? Okundumu{get;set;}
public int? Gonderildimi{get;set;}
public int? Reply_ID{get;set;}
public string Konu {get;set;}

             
        }
}
