using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Masraf_Hareket : BaseEntity {

public int? Masraf_Har_ID{get;set;}
public string Adi {get;set;}
public DateTime? Tarih{get;set;}
public int? Doviz_ID{get;set;}
public int? Masraf_ID{get;set;}
public decimal? Tutar { get;set;}
public int? Girismi{get;set;}
public int? Cikismi{get;set;}
public int? Fis_ID{get;set;}
public DateTime? CDate{get;set;}
public string Hizmet_Aciklama {get;set;}
public int? Personel_ID{get;set;}
public int? Turu{get;set;}
public int? Cari_ID{get;set;}
public int? Borc{get;set;}
public int? Alacak{get;set;}

             
        }
}
