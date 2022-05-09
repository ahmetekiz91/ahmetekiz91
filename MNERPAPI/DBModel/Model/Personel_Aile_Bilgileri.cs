using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Personel_Aile_Bilgileri : BaseEntity {

public int? Per_Aile_Bilg_ID{get;set;}
public int? Per_ID{get;set;}
public DateTime? CDate{get;set;}
public int? USR_ID{get;set;}
public string Adi {get;set;}
public string Soyadi {get;set;}
public string Dogum_Yeri {get;set;}
public DateTime? Dogum_Tarihi{get;set;}
public string Yakınlık_Derecesi {get;set;}
public string Okul_Seviyesi {get;set;}

             
        }
}
