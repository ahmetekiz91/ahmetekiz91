using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Sevk_Plani : BaseEntity {

public int? Sevk_Plan_ID{get;set;}
public string Gonderim_Turu {get;set;}
public int? Sevk_ID{get;set;}
public string Maliyeti {get;set;}
public int? Cari_Adr_ID{get;set;}
public DateTime? CDate{get;set;}
public int? Tas_Fir_ID{get;set;}
public string Vari_Yeri {get;set;}
public int? Teslimat_Turu_ID{get;set;}
public DateTime? Bas_Tar{get;set;}
public DateTime? Bit_Tar{get;set;}
public int? Asama_No{get;set;}

             
        }
}
