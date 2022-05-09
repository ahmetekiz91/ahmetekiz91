using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Rota_Tanimlari_Params : BaseEntity {

public int? Rot_Tanim_Par_ID{get;set;}
public int? Rota_Tanim_ID{get;set;}
public int? Param_ID{get;set;}
public DateTime? CDate{get;set;}
public string Tipi {get;set;}
public string Deger {get;set;}
public string Formul {get;set;}
public string Sonuc {get;set;}

             
        }
}
