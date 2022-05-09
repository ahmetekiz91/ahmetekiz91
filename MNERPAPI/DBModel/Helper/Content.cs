using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public class Content
    {
       
        private readonly IHelper helper;
        public Content()
        {

        }
        public Content(IHelper helper) 
        {
            this.helper = helper;
        }

        IConfiguration configuration;
        public List<KeyValuePair<string, string>> ddl_Attributes()
        {
            DataTable dt = helper.sc(@"Select * from  ( Select 0 as [Att_ID],' Seçiniz' as [ViewName] union all Select [Att_ID],[ViewName]  FROM [Attributes]) as Tablo order by ViewName asc ", "ConnStr");
            var pla = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["Att_ID"] == DBNull.Value ? "" : dt.Rows[i]["Att_ID"].ToString();
                string name = dt.Rows[i]["ViewName"] == DBNull.Value ? "" : dt.Rows[i]["ViewName"].ToString();
                pla.Add(new KeyValuePair<string, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<string, string>> GiderHesaplari()
        {
            DataTable dt = helper.sc(@" Select * from  (Select '-' as [MUH_KODU], ' Seçiniz' as [HSP_ADI] union all Select [MUH_KODU],isnull(MUH_KODU,'')+'//'+isnull( HSP_ADI,'') 'HSP_ADI' FROM [Muhasebe_Hesaplari]) as Tablo order by HSP_ADI asc ", "ConnStr");
            var pla = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["MUH_KODU"] == DBNull.Value ? "" : dt.Rows[i]["MUH_KODU"].ToString();
                string name = dt.Rows[i]["MUH_KODU"] == DBNull.Value ? "" : dt.Rows[i]["HSP_ADI"].ToString();
                pla.Add(new KeyValuePair<string, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<string, string>> MasrafMerkezleri()
        {
            DataTable dt = helper.sc(@"   Select * from  (  Select '-'as [Muh_Kod],' Seçiniz' [Adi] union all Select [Muh_Kod], isnull(Muh_Kod,'')+'//'+isnull(Adi,'') as [Adi] from [Masraflar]) as Tablo 
               order by  Adi asc ", "ConnStr");
            var pla = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["Muh_Kod"] == DBNull.Value ? "" : dt.Rows[i]["Muh_Kod"].ToString();
                string name = dt.Rows[i]["Adi"] == DBNull.Value ? "" : dt.Rows[i]["Adi"].ToString();
                pla.Add(new KeyValuePair<string, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Bankalar()
        {
            DataTable dt = helper.sc(@"Select 0 as ID,' Seçiniz' as Banka_Adi union all Select ID,Banka_Adi from Bankalar order by Banka_Adi asc", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["ID"];
                string name = dt.Rows[i]["Banka_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Banka_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Kullanıcılar()
        {
            DataTable dt = helper.sc(@" Select 0 as USR_ID,' Seçiniz' as OName union all  Select USR_ID,
             (isnull(Name,'')+' '+isnull(Surname,'')) as OName from Kullanicilar", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["USR_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["USR_ID"];
                string name = dt.Rows[i]["OName"] == DBNull.Value ? "" : dt.Rows[i]["OName"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Departmanlar()
        {
            DataTable dt = helper.sc(@"Select 0 as Depart_ID,' Seçiniz' as Depart_Adi union all select Depart_ID,Depart_Adi from Departmanlar", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Depart_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Depart_ID"];
                string name = dt.Rows[i]["Depart_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Depart_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;

        }

        public List<KeyValuePair<int, string>> HIZMETLER()
        {
            DataTable dt = helper.sc(@" Select 0 as HZMT_ID, ' Seçiniz' as ACIKLAMA union all  Select HZMT_ID,ACIKLAMA from HIZMETLER", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["HZMT_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["HZMT_ID"];
                string name = dt.Rows[i]["ACIKLAMA"] == DBNull.Value ? "" : dt.Rows[i]["ACIKLAMA"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }

            return pla;

        }

        public List<KeyValuePair<int, string>> Plasiyerler()
        {
            DataTable dt = helper.sc(@"Select 0 as PLA_ID,' Seçiniz' as PLADI union all Select PLA_ID,(ISNULL(PLADI,'')+' '+ISNULL(PLSOYADI,'') )as PLADI   FROM [Plasiyerler]", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["PLA_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["PLA_ID"];
                string name = dt.Rows[i]["PLADI"] == DBNull.Value ? "" : dt.Rows[i]["PLADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Kategoriler()
        {
            DataTable dt = helper.sc("Select 0 as CAT_ID,' Seçiniz' as CAT_ADI union all   Select CAT_ID ,CAT_ADI  From MCategory ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["CAT_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["CAT_ID"];
                string name = dt.Rows[i]["CAT_ADI"] == DBNull.Value ? "" : dt.Rows[i]["CAT_ADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Kasalar()
        {
            // Select 0 as Kasa_ID,' Tümü' as Kasa_Adi union all Select Kasa_ID,Kasa_Adi from Kasalar
            DataTable dt = helper.sc("Select 0 as Kasa_ID,' Seçiniz' as Kasa_Adi union all   Select Kasa_ID ,Kasa_Adi  From Kasalar ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Kasa_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Kasa_ID"];
                string name = dt.Rows[i]["Kasa_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Kasa_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }
        public List<KeyValuePair<int, string>> CARIGRUPLAR()
        {
            // Select 0 as Kasa_ID,' Tümü' as Kasa_Adi union all Select Kasa_ID,Kasa_Adi from Kasalar
            DataTable dt = helper.sc("Select 0 as CARI_GRUP_ID,' Seçiniz' as ADI union all   Select CARI_GRUP_ID ,ADI  From CARIGRUPLAR ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["CARI_GRUP_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["CARI_GRUP_ID"];
                string name = dt.Rows[i]["ADI"] == DBNull.Value ? "" : dt.Rows[i]["ADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }
        public List<KeyValuePair<int, string>> Dovizler()
        {
            DataTable dt = helper.sc("Select 0 as DOV_ID,' Seçiniz' as Adi union all   Select DOV_ID ,Adi  From DovizTurleri ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["DOV_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["DOV_ID"];
                string name = dt.Rows[i]["Adi"] == DBNull.Value ? "" : dt.Rows[i]["Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Birimler()
        {
            DataTable dt = helper.sc(@"Select 0 as Brm_ID,' Seçiniz' as Brm_Adi union all Select [BRM_ID],[BRM_ADI] From [BIRIMLER] where Turu in ('Malz')", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Brm_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Brm_ID"];
                string name = dt.Rows[i]["Brm_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Brm_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        //Cari Hareket
        public List<KeyValuePair<int, string>> Kredi_Banka_Hesaplar()
        {
            DataTable dt = helper.sc(@"Select 0 as HESAP_ID, ' TÜMÜ' as HESAPADI union all  SELECT BH.HESAP_ID,BH.HESAPADI
            FROM Banka_Hesaplar BH 
            inner join Bankalar b on b.ID=BH.BNK_ID where bh.HESAPTURU='KKR'", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["HESAP_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["HESAP_ID"];
                string name = dt.Rows[i]["HESAPADI"] == DBNull.Value ? "" : dt.Rows[i]["HESAPADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Banka_Hesaplari(int BNK_ID)
        {
            DataTable dt = helper.sc(@"Select 0 as HESAP_ID, ' TÜMÜ' as HESAPADI union all  SELECT BH.HESAP_ID,BH.HESAPADI
            FROM Banka_Hesaplar BH 
            inner join Bankalar b on b.ID=BH.BNK_ID
            where BH.BNK_ID=" + BNK_ID, "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["HESAP_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["HESAP_ID"];
                string name = dt.Rows[i]["HESAPADI"] == DBNull.Value ? "" : dt.Rows[i]["HESAPADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Malz_Birimler(int Malz_ID)
        {
            DataTable dt = helper.sc(@"
            Select 0 as Brm_ID,' Seçiniz' as Brm_Adi union all  SELECT MALZ_BRM_ID as Brm_ID,bir.Brm_Adi  FROM MALZ_BIRIM mb
            inner join Birimler bir on bir.Brm_ID =mb.MBRM_ID
            where mb.MALZ_ID=" + Malz_ID, "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Brm_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Brm_ID"];
                string name = dt.Rows[i]["Brm_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Brm_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> HIZMET_BIRIMLER(int Malz_ID)
        {
            DataTable dt = helper.sc(@"
            Select 0 as BRM_ID,' Seçiniz' as Brm_Adi union all  
            SELECT  hb.BRM_ID,b.Brm_Adi   FROM [HIZMET_BIRIMLER] hb
            inner join  Birimler b on b.Brm_ID=hb.[BRM_ID]
            where hb.HZM_ID=" + Malz_ID, "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["BRM_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["BRM_ID"];
                string name = dt.Rows[i]["Brm_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Brm_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Malz_Har_Bir(int Malz_ID)
        {
            DataTable dt = helper.sc(@"
            Select 0 as Brm_ID,' Seçiniz' as Brm_Adi union all  SELECT bir.Brm_ID as Brm_ID,bir.Brm_Adi  FROM MALZ_BIRIM mb
            inner join Birimler bir on bir.Brm_ID =mb.MBRM_ID
            where mb.MALZ_ID=" + Malz_ID, "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Brm_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Brm_ID"];
                string name = dt.Rows[i]["Brm_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Brm_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Depolar()
        {
            DataTable dt = helper.sc(@"Select 0 as Depo_ID,' Seçiniz' as Depo_Adi union all Select Depo_ID,Depo_Adi From Depolar", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Depo_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Depo_ID"];
                string name = dt.Rows[i]["Depo_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Depo_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Markalar()
        {
            System.Data.DataTable dt = helper.sc(@" Select 0 as Marka_ID,' Seçiniz' as Marka_Adi union all Select Marka_ID,Marka_Adi From Markalar", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Marka_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Marka_ID"];
                string name = dt.Rows[i]["Marka_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Marka_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }


            return pla;
        }

        public List<KeyValuePair<int, string>> Malzemeler()
        {
            DataTable dt = helper.sc(@"Select 0 as Malz_ID,' Seçiniz' as Malz_Isim union all Select Malz_ID,Malz_Isim From Malzeme", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Malz_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Malz_ID"];
                string name = dt.Rows[i]["Malz_Isim"] == DBNull.Value ? "" : dt.Rows[i]["Malz_Isim"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Ulkeler()
        {
            DataTable dt = helper.sc(@"  select 0 as Ulke_ID,' Seçiniz' as Ulke_Adi union all select Ulke_ID,(Ulke_Kodu+'//'+Ulke_Adi) as Ulke_Adi From Ulkeler ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Ulke_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Ulke_ID"];
                string name = dt.Rows[i]["Ulke_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Ulke_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Istasyonlar()
        {
            DataTable dt = helper.sc(@"select 0 as Istasyon_ID,' Seçiniz' as Istasyon_Adi union all select Istasyon_ID, Istasyon_Adi From Istasyon ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Istasyon_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Istasyon_ID"];
                string name = dt.Rows[i]["Istasyon_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Istasyon_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Operasyonlar()
        {
            DataTable dt = helper.sc(@"  Select 0 as Operasyon_Id,' Seçiniz' as Operasyon_Adi union all   Select Operasyon_ID,Operasyon_Adi From Operasyonlar ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Operasyon_Id"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Operasyon_Id"];
                string name = dt.Rows[i]["Operasyon_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Operasyon_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Cariler()
        {
            DataTable dt = helper.sc(@"Select 0 as Cari_ID,' Seçiniz' as Cari_Unvan union all 
              Select Cari_ID,Cari_Unvan From Cari_Kart where Alicimi=1", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Cari_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Cari_ID"];
                string name = dt.Rows[i]["Cari_Unvan"] == DBNull.Value ? "" : dt.Rows[i]["Cari_Unvan"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Tedarikciler()
        {
            DataTable dt = helper.sc(@"  Select 0 as Cari_ID,' Seçiniz' as Cari_Unvan union all   Select Cari_ID,Cari_Unvan From Cari_Kart where Saticimi=1", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Cari_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Cari_ID"];
                string name = dt.Rows[i]["Cari_Unvan"] == DBNull.Value ? "" : dt.Rows[i]["Cari_Unvan"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Odeme_Turleri()
        {
            DataTable dt = helper.sc(@"  Select 0 as Ode_ID,' Seçiniz' as Odeme_Turu union all   Select Ode_ID,Odeme_Turu From Odemeler ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Ode_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Ode_ID"];
                string name = dt.Rows[i]["Odeme_Turu"] == DBNull.Value ? "" : dt.Rows[i]["Odeme_Turu"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Teslimat_Turu()
        {
            DataTable dt = helper.sc(@"  Select 0 as Tesl_ID,' Seçiniz' as Tesl_Tur union all   Select Tesl_ID,Tesl_Tur From Teslimat_Turu ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Tesl_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Tesl_ID"];
                string name = dt.Rows[i]["Tesl_Tur"] == DBNull.Value ? "" : dt.Rows[i]["Tesl_Tur"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Iller()
        {
            DataTable dt = helper.sc(@"  Select 0 as Sehir_ID,' Seçiniz' as Sehir_Adi union all   Select Sehir_ID,Sehir_Adi From Iller ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Sehir_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Sehir_ID"];
                string name = dt.Rows[i]["Sehir_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Sehir_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Bolgeler()
        {
            DataTable dt = helper.sc(@"Select 0 as Bolge_ID,' Seçiniz' as Bolge_Adi union all 
             Select Bolge_ID,Bolge_Adi From Bolgeler", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Bolge_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Bolge_ID"];
                string name = dt.Rows[i]["Bolge_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Bolge_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;

        }

        public List<KeyValuePair<int, string>> Hatlar()
        {
            DataTable dt = helper.sc(@"Select 0 as Hat_ID,' Seçiniz' as Hat_Adi 
             union all Select Hat_ID,Hat_Adi from Hatlar ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Hat_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Hat_ID"];
                string name = dt.Rows[i]["Hat_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Hat_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Vardiyalar()
        {
            DataTable dt = helper.sc(@"  Select 0 as Var_ID,' Seçiniz' as Var_Adi union  all Select Var_ID,
             (isnull(convert(nvarchar,Gun_Adi),'')+'=>'+isnull(convert(nvarchar,Bas,108),'')+'-'+
             isnull(convert(nvarchar,[Bit],108),'')) as Var_Adi From Vardiyalar_View", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Var_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Var_ID"];
                string name = dt.Rows[i]["Var_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Var_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> VardiyalarDetay(int ist_id)
        {
            DataTable dt = helper.sc(@"   Select 0 as Var_Det_ID,' Seçiniz' as Var_Adi union  all Select Var_Det_ID,
            (isnull(convert(nvarchar,UBas,104),'')+'=>'+isnull(convert(nvarchar,UBas,108),'')+'-'+
             isnull(convert(nvarchar,[UBit],108),'')) as Var_Adi From VadiyaDetay_View where Istasyon_ID=" + ist_id, "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Var_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Var_ID"];
                string name = dt.Rows[i]["Var_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Var_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Banka_Fis_Turleri()
        {
            DataTable dt = helper.sc(@"Select Tur_Id,Tur_Adi from (Select 0 as Tur_Id,' Seçiniz' as Tur_Adi union 
            all Select Tur_Id,Tur_Adi from Fis_Turleri where Tur_Id in (8,9,57,58,59,60,61,62,63,64,65,66)) as A order by  Tur_Adi asc", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Tur_Id"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Tur_Id"];
                string name = dt.Rows[i]["Tur_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Tur_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;

        }

        public List<KeyValuePair<int, string>> Masraf_Fis_Turleri()
        {

            DataTable dt = helper.sc(@"  SELECT Tur_Id
      
      ,Tur_Adi
      
      
      ,Kodu
      
  FROM Fis_Turleri where Kodu in ('GDF','AHF','VHF','GEF','MO')", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Tur_Id"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Tur_Id"];
                string name = dt.Rows[i]["Tur_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Tur_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Masraflar()
        {

            DataTable dt = helper.sc(@"Select 0 as Masraf_ID, ' Seçiniz' as Adi union all
           Select Masraf_ID,Adi from Masraflar  order by Adi asc", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Masraf_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Masraf_ID"];
                string name = dt.Rows[i]["Adi"] == DBNull.Value ? "" : dt.Rows[i]["Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Personeller()
        {

            DataTable dt = helper.sc(@"Select 0 as Per_ID, ' Seçiniz' as Per_Adi union all
           Select Per_ID,Per_Adi from Personeller_View  order by Per_Adi asc", "ConnStr");
            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Per_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Per_ID"];
                string name = dt.Rows[i]["Per_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Per_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> VardiyaDetay()
        {
            DataTable dt = helper.sc(@"     Select 0 as Var_Det_ID,' Seçiniz' as Var_Adi union  all Select Var_Det_ID,
            (isnull(convert(nvarchar,Tarih,104),'')+'=>'+isnull(convert(nvarchar,UBas,108),'')+'-'+
             isnull(convert(nvarchar,[UBit],108),'')) as Var_Adi From VadiyaDetay_View ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Var_Det_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Var_Det_ID"];
                string name = dt.Rows[i]["Var_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Var_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> BANKAISLEMTURLERI()
        {

            DataTable dt = helper.sc(@"Select 0 as BNK_ISL_ID,' Seçiniz' as [ACIKLAMA] union all  
             SELECT BNK_ISL_ID,ACIKLAMA  FROM BANKAISLEMTURLERI", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["BNK_ISL_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["BNK_ISL_ID"];
                string name = dt.Rows[i]["ACIKLAMA"] == DBNull.Value ? "" : dt.Rows[i]["ACIKLAMA"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> CekSenetFisTurleri()
        {

            DataTable dt = helper.sc(@"
              Select 0 as Tur_Id,' Seçiniz' as Tur_Adi union all select Tur_Id, Tur_Adi from Fis_Turleri
             where Tur_Id in (67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82) ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Tur_Id"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Tur_Id"];
                string name = dt.Rows[i]["Tur_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Tur_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> KasaÇekSenetFisTurleri()
        {
            DataTable dt = helper.sc(@"
              Select 0 as Tur_Id,' Seçiniz' as Tur_Adi union all select Tur_Id, Tur_Adi from Fis_Turleri
             where Tur_Id in (84,85,86,87) ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["Tur_Id"] == DBNull.Value ? 0 : (int)dt.Rows[i]["Tur_Id"];
                string name = dt.Rows[i]["Tur_Adi"] == DBNull.Value ? "" : dt.Rows[i]["Tur_Adi"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> CekSenetTurleri()
        {

            DataTable dt = helper.sc(@"
            SELECT 0 as  BORD_TUR_ID,' Seçiniz' as TUR_ADI union all 
            select BORD_TUR_ID, TUR_ADI from [BORDRO_TUR]  where BORD_TUR_ID in (23,24,25,26,27,28,29,30,31,32,33,34) ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["BORD_TUR_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["BORD_TUR_ID"];
                string name = dt.Rows[i]["TUR_ADI"] == DBNull.Value ? "" : dt.Rows[i]["TUR_ADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> Banka_Hesaplar(int TUR_ID)
        {

            string s = "";

            if (TUR_ID == 73 || TUR_ID == 74)
            {
                s = " and HESAPTURU='KRD'";
            }
            if (TUR_ID == 75 || TUR_ID == 71 || TUR_ID == 79)
            {
                s = " and HESAPTURU='TKS'";
            }
            if (TUR_ID == 76 || TUR_ID == 72 || TUR_ID == 80)
            {
                s = " and HESAPTURU='THS'";
            }

            DataTable dt = helper.sc(@"Select 0 as HESAP_ID, ' TÜMÜ' as HESAPADI union all  
            SELECT BH.HESAP_ID,(isnull(b.Banka_Adi,'')+' ' + isnull(BH.HESAPADI,'')) as HESAPADI
            FROM Banka_Hesaplar BH 
            inner join Bankalar b on b.ID=BH.BNK_ID 
            where   1=1 " + s, "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["HESAP_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["HESAP_ID"];
                string name = dt.Rows[i]["HESAPADI"] == DBNull.Value ? "" : dt.Rows[i]["HESAPADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> BORDRO_BORCLU()
        {

            DataTable dt = helper.sc(@"  Select 0 as SEN_BORC_ID,' Seçiniz' as Unvan 
            union all Select SEN_BORC_ID,Unvan from BORDRO_BORCLU_KISI ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["SEN_BORC_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["SEN_BORC_ID"];
                string name = dt.Rows[i]["Unvan"] == DBNull.Value ? "" : dt.Rows[i]["Unvan"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }

        public List<KeyValuePair<int, string>> BankaHesaplar()
        {
            DataTable dt = helper.sc(@"
              Select 0 as [HESAP_ID],' Seçiniz' [HESAPADI] union all Select HESAP_ID,HESAPADI 
               FROM [Banka_Hesaplar] where [HESAPADI]<>'' ", "ConnStr");

            var pla = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = dt.Rows[i]["HESAP_ID"] == DBNull.Value ? 0 : (int)dt.Rows[i]["HESAP_ID"];
                string name = dt.Rows[i]["HESAPADI"] == DBNull.Value ? "" : dt.Rows[i]["HESAPADI"].ToString();
                pla.Add(new KeyValuePair<int, string>(id, name));
            }
            return pla;
        }


    }
}
