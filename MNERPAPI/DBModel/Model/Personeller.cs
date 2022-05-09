using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Personeller : BaseEntity {

public int? Per_ID{get;set;}
public string Per_Adi {get;set;}
public string Per_Soyadi {get;set;}
public string TC {get;set;}
public DateTime? Dogum_Tarihi{get;set;}
public DateTime? CDate{get;set;}
public string DY_IL {get;set;}
public string DY_Ilce {get;set;}
public string DY_Mahalle_Koy {get;set;}
public string DY_Adres {get;set;}
public string Adres {get;set;}
public string Il {get;set;}
public string Ilce {get;set;}
public string Mah {get;set;}
public string Ulke {get;set;}
public int? DEP_ID{get;set;}
public decimal? Maas { get;set;}
public decimal? Birim_Maas { get;set;}
public int? DOVIZ_ID{get;set;}

             
        }
}
