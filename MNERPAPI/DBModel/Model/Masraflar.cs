using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Masraflar : BaseEntity {

public int? Masraf_ID{get;set;}
public DateTime? CDate{get;set;}
public string Muh_Kod {get;set;}
public string Adi {get;set;}
public string Aciklama {get;set;}
public int? Fis_Tur{get;set;}

             
        }
}
