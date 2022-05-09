using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Utility;

namespace DBModel.Model
{ public class Kasa_Hareket : BaseEntity {

public int? Kasa_Har_ID{get;set;}
public int? CARI_ID{get;set;}
public int? BANKA_ID{get;set;}
public int? CEK_ID{get;set;}
public DateTime? Tarihi{get;set;}
public string Tah_No {get;set;}
public decimal? Tutar { get;set;}
public int? Doviz_ID{get;set;}
public int? Girismi{get;set;}
public int? Cikismi{get;set;}
public int? Borc{get;set;}
public int? Alacak{get;set;}
public int? Masraf_ID{get;set;}
public int? Kasa_ID{get;set;}
public int? CUSR_ID{get;set;}
public int? Fis_ID{get;set;}
public int? Kdv_Dahil{get;set;}
public decimal? Kdv_Oran { get;set;}
public decimal? KDVTutar { get;set;}
public string Proje_Kodu {get;set;}
public string Plasiyer_Kodu {get;set;}
public int? Tur_ID{get;set;}
public int? Fis_Id_Ref{get;set;}
public string Aciklama {get;set;}
public string Islem_Turu {get;set;}
public DateTime? Vade_Tar{get;set;}
public int? BORCLU_ID{get;set;}
public int? LDOV_ID{get;set;}
public decimal? KUR1 { get;set;}
public decimal? KUR2 { get;set;}
public int? HZM_ID{get;set;}
public int? MALZ_ID{get;set;}
public int? BRM_ID{get;set;}
public decimal? BRM_FYT { get;set;}
public decimal? MIKTAR { get;set;}
public int? HSP_ID{get;set;}
public int? SIRANO{get;set;}
public string IslemMasMerKodu {get;set;}
public string IslemMuhKodu {get;set;}
public string StopajMasKodu {get;set;}
public string StopajMuhKodu {get;set;}
public decimal? StopajOran { get;set;}
public decimal? StopajTutar { get;set;}
public string FonPayiMuhKodu {get;set;}
public string FonPayiMasKodu {get;set;}
public decimal? FonPayiOran { get;set;}
public decimal? FonPayiTutar { get;set;}
public decimal? BR_KDVOran { get;set;}
public decimal? BR_KDVToplam { get;set;}
public string KasaMuhKodu {get;set;}
public string KasaMasKodu {get;set;}
public string BrutKDVMuhKodu {get;set;}
public string BrutKDVMasKodu {get;set;}
public string TevfhMuhKodu1 {get;set;}
public string TevfhMasKodu1 {get;set;}
public string TevfhMuhKodu2 {get;set;}
public string TevfhMasKodu2 {get;set;}
public string SozNo {get;set;}
public string Adres {get;set;}
public string Plaka {get;set;}
public string Ad {get;set;}
public string Soyad {get;set;}
public decimal? NET { get;set;}
public decimal? BRUT { get;set;}
public decimal? KESTUTAR { get;set;}
public decimal? TOPLAM { get;set;}
public decimal? TEVFIKAT_ORAN { get;set;}
public decimal? TEVFIKAT_TUTAR { get;set;}

             
        }
}
