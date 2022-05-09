using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Odeme_Hareket : BaseEntity {

public int? Odeme_Sekli_Har_ID{get;set;}
public int? Taksit_say{get;set;}
public string Gun {get;set;}
public string Vade {get;set;}
public string Odeme_Tarihi {get;set;}
public string Oran_Vade {get;set;}

             
        }
}
