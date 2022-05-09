using Dapper;
using DBModel;
using DBModel.Infrastruce;
using DBModel.Model;
using DBModel.Utility;
using FINANS.Infrastruce;
using FINANS.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINANS.Repository
{
    public class CARIFISRepository : IDisposable, FINANS.IRepository.ICARIFISRepository
    {

        public IUnitOfWork unitOfWork = null;
        public IConfiguration configuration;
        public string mesaj = "";
        public CARIFISRepository()
        {

        }

        public CARIFISRepository(IUnitOfWork unitOfWork, out string mesaj)
        {
            this.unitOfWork = unitOfWork;
            mesaj = this.mesaj;
        }

        public CARIFISRepository(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<CARIFISDTO>> GetAllAsync()
        {
            List<CARIFISDTO> rlist = new List<CARIFISDTO>();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    CARIHAREKETRepository fisrepo = new CARIHAREKETRepository(unitOfWork, configuration);
                    try
                    {
                        var parameters = new DynamicParameters();
                        var query = "SELECT * FROM FISLER WHERE FISTURID in (20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,31,32,33,34)";
                        List<FISLER> list = (await unitOfWork.Connection.QueryAsync<FISLER>(query, parameters, unitOfWork.Transaction)).ToList();
                        for (int i = 0; i < list.Count; i++)
                        {
                            CARIFISDTO n = new CARIFISDTO();
                            n.fisler = list[i];
                            n.chlist = await fisrepo.GetAllAsync((int)list[0].FIS_ID);
                            rlist.Add(n);
                        }
                        //Unit of work ile para hareketi eklenecek
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    unitOfWork.Commit();
                    return rlist;
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return rlist;
                }
            }

        }

        public async Task<List<CARIFISDTO>> GetById(int id)
        {
            List<CARIFISDTO> rlist = new List<CARIFISDTO>();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    CARIHAREKETRepository fisrepo = new CARIHAREKETRepository(unitOfWork, configuration);
                    try
                    {
                        var parameters = new DynamicParameters();
                        var query = "SELECT * FROM FISLER WHERE  FIS_ID=@FIS_ID and  FISTURID in (20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,31,32,33,34)";
                        parameters.Add("FIS_ID", id, DbType.Int32);
                        List<FISLER> list = (await unitOfWork.Connection.QueryAsync<FISLER>(query, parameters, unitOfWork.Transaction)).ToList();
                        for (int i = 0; i < list.Count; i++)
                        {
                            CARIFISDTO n = new CARIFISDTO();
                            n.fisler = list[i];
                            n.chlist = await fisrepo.GetAllAsync((int)list[0].FIS_ID);
                            rlist.Add(n);
                        }
                        //Unit of work ile para hareketi eklenecek
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    unitOfWork.Commit();
                    return rlist;
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return rlist;
                }
            }
        }

        protected SqlConnection CreateConnection()
        {

            return new SqlConnection(configuration.GetConnectionString("ConnStr"));
        }

        public async Task<bool> CreateAsync(CARIFISDTO entity)
        {

            FISLER fisler = entity.fisler;
            List<CARIHAREKET> cari_hareket = entity.chlist;
            if (fisler.FICHENO == "")
            {
                mesaj = "Hatalı veri";
            }
            if (fisler.DOVIZID == null || fisler.DOVIZID == 0)
            {
                mesaj = "Lütfen Doviz Türü Seçiniz";
            }
            if (fisler.FISTURID == null || fisler.FISTURID == 0)
            {
                mesaj = "Lütfen Fiş Türü Seçiniz";
            }
            if (cari_hareket.Count == 0)
            {
                mesaj = "Hatalı Veri";

            }
            if (fisler.FISTURID == 24)
            {
                if (cari_hareket.Count != 2)
                {
                    mesaj = "Virman Fişinde İki Cari Seçili Olmalıdır";

                }
                int bcount = cari_hareket.Where(c => c.BORC == 1).Count();
                int acount = cari_hareket.Where(c => c.ALACAK == 1).Count();
                if (!(acount == 1 && bcount == 1))
                {
                    mesaj = "Virman Fişinde bir borç carisi bir ALACAK carisi olmalıdır";

                }
            }
            if (fisler.FISTURID == 26)
            {
                int bcount = cari_hareket.Where(c => c.BORC == 1).Count();
                int acount = cari_hareket.Where(c => c.ALACAK == 1).Count();
                if (cari_hareket.Count != bcount + acount)
                {
                    mesaj = "Lütfen hareketin borç veya ALACAK olduğunu belirtiniz";
                }
            }

            if (fisler.FISTURID == 27)
            {
                if (cari_hareket.Count != 1)
                {
                    mesaj = "Alınan Vade Farkı  Faturasında Tek Cari Olmalıdır";
                }

            }
            if (fisler.FISTURID == 28)
            {
                if (cari_hareket.Count != 1)
                {
                    mesaj = "Verilen Vade Farkı  Faturasında Tek Cari Olmalıdır";
                }
            }

            FISLER f = new FISLER();
            f.CDATE = DateTime.Now;
            f.FISTARIHI = fisler.FISTARIHI;
            f.FISTURID = fisler.FISTURID;
            f.CUSR_ID = 0;
            f.DOVIZID = fisler.DOVIZID;
            f.FICHENO = fisler.FICHENO;
            f.FIS_ID = fisler.FIS_ID;
            f.TRANSACTION_ID = Guid.NewGuid().ToString();

            Doviz_Kurlari dk = await kur_bulAsync((int)fisler.DOVIZID);
            decimal? toplam = 0m;
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {

                    FISLERRepository fisrepo = new FISLERRepository(unitOfWork);
                    int FIS_ID = fisrepo.CreateAsync(f);
                    try
                    {

                        PARA_HAREKET parahareket = new PARA_HAREKET();


                        for (int i = 0; i < cari_hareket.Count; i++)
                        {
                            CARIHAREKETRepository cari = new CARIHAREKETRepository(unitOfWork, configuration);

                            CARIHAREKET ck = new CARIHAREKET();

                            SetBorcAlacak(out parahareket, out ck, fisler.FISTURID);


                            ck.CARI_HAR_ID = cari_hareket[i].CARI_HAR_ID;
                            ck.CARI_ID = cari_hareket[i].CARI_ID;
                            ck.CDATE = DateTime.Now;
                            ck.ACIKLAMA = cari_hareket[i].ACIKLAMA;
                            ck.TUTAR = cari_hareket[i].TUTAR;
                            ck.BNK_ID = cari_hareket[i].BNK_ID;
                            if (fisler.FISTURID == 24)
                            {
                                ck.BORC = cari_hareket[i].BORC;
                                ck.ALACAK = cari_hareket[i].ALACAK;
                                ck.GIRISMI = 0;
                                ck.CIKISMI = 0;
                                ck.FTUR_ID = 24;

                                parahareket.BORC = cari_hareket[i].BORC;
                                parahareket.ALACAK = cari_hareket[i].ALACAK;
                                parahareket.GIRIS = 0;
                                parahareket.CIKIS = 0;
                                parahareket.TUR_ID = 24;

                            }

                            if (fisler.FISTURID == 26)
                            {
                                ck.BORC = cari_hareket[i].BORC;
                                ck.ALACAK = cari_hareket[i].ALACAK;
                                ck.GIRISMI = 0;
                                ck.CIKISMI = 0;
                                ck.FTUR_ID = 26;

                                parahareket.BORC = cari_hareket[i].BORC;
                                parahareket.ALACAK = cari_hareket[i].ALACAK;
                                parahareket.GIRIS = 0;
                                parahareket.CIKIS = 0;
                                parahareket.TUR_ID = 26;
                            }
                            if (fisler.FISTURID == 29 || fisler.FISTURID == 30)
                            {
                                ck.TUTAR = cari_hareket[i].TOPLAM;
                            }

                            ck.FIS_ID = FIS_ID;
                            ck.DOV_ID = f.DOVIZID;
                            ck.CEKSENNO = cari_hareket[i].CEKSENNO;
                            ck.TAHNO = cari_hareket[i].TAHNO;
                            ck.ISLEMTARIHI = f.FISTARIHI;
                            ck.ACIKLAMA = cari_hareket[i].ACIKLAMA;
                            ck.LDOV_ID = 1;
                            ck.KUR1 = dk.Doviz1_Deger;
                            ck.KUR2 = dk.Doviz2_Deger;
                            ck.STOPAJORAN = cari_hareket[i].STOPAJORAN;
                            ck.STOPAJTUTAR = cari_hareket[i].STOPAJTUTAR;
                            ck.FONPAYIORAN = cari_hareket[i].FONPAYIORAN;
                            ck.FONPAYITUTAR = cari_hareket[i].FONPAYITUTAR;
                            ck.BRKDVORAN = cari_hareket[i].BRKDVORAN;
                            ck.BRKDVTUTAR = cari_hareket[i].BRKDVTUTAR;
                            ck.NET = cari_hareket[i].NET;
                            ck.BRUT = cari_hareket[i].BRUT;
                            ck.KESTUTAR = cari_hareket[i].KESTUTAR;
                            ck.TOPLAM = cari_hareket[i].TOPLAM;
                            cari.CreateAsync(ck);
                            if (cari_hareket[i].TOPLAM == 0m)
                            {
                                toplam += cari_hareket[i].TUTAR;
                            }
                            else
                            {
                                toplam += cari_hareket[i].TOPLAM;
                            }
                        }
                        //Unit of work ile para hareketi eklenecek
                        parahareket.CDATE = DateTime.Now;
                        parahareket.TARIH = fisler.FISTARIHI;
                        parahareket.TUTAR = toplam;
                        parahareket.DOV_ID = fisler.DOVIZID;
                        parahareket.LDOV_ID = 0;
                        parahareket.KUR1 = dk.Doviz1_Deger;
                        parahareket.KUR2 = dk.Doviz2_Deger;
                        parahareket.CARI_ID = fisler.CARIID;
                        parahareket.FIS_ID = fisler.FIS_ID;
                        parahareket.TRANSACTION_ID = fisler.TRANSACTION_ID;


                        PARA_HAREKETRepository parahareketrepo = new PARA_HAREKETRepository(unitOfWork, configuration);
                        bool paraharupdate = await parahareketrepo.CreateAsync(parahareket);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return false;
                }
            }
        }

        public async Task<Doviz_Kurlari> kur_bulAsync(int Doviz2_ID)
        {

            Doviz_KurlariRepository dk = new Doviz_KurlariRepository(configuration);
            Doviz_Kurlari doviz_Kurlari = await dk.GetByIdAsync(Doviz2_ID);
            if (doviz_Kurlari != null)
            {
                return doviz_Kurlari;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(CARIFISDTO entity)
        {
            FISLER fisler = entity.fisler;
            List<CARIHAREKET> cari_hareket = entity.chlist;
            if (fisler.FICHENO == "")
            {
                mesaj = "Hatalı veri";
            }
            if (fisler.DOVIZID == null || fisler.DOVIZID == 0)
            {
                mesaj = "Lütfen Doviz Türü Seçiniz";
            }
            if (fisler.FISTURID == null || fisler.FISTURID == 0)
            {
                mesaj = "Lütfen Fiş Türü Seçiniz";
            }
            if (cari_hareket.Count == 0)
            {
                mesaj = "Hatalı Veri";

            }
            if (fisler.FISTURID == 24)
            {
                if (cari_hareket.Count != 2)
                {
                    mesaj = "Virman Fişinde İki Cari Seçili Olmalıdır";

                }
                int bcount = cari_hareket.Where(c => c.BORC == 1).Count();
                int acount = cari_hareket.Where(c => c.ALACAK == 1).Count();
                if (!(acount == 1 && bcount == 1))
                {
                    mesaj = "Virman Fişinde bir borç carisi bir ALACAK carisi olmalıdır";

                }
            }
            if (fisler.FISTURID == 26)
            {
                int bcount = cari_hareket.Where(c => c.BORC == 1).Count();
                int acount = cari_hareket.Where(c => c.ALACAK == 1).Count();
                if (cari_hareket.Count != bcount + acount)
                {
                    mesaj = "Lütfen hareketin borç veya ALACAK olduğunu belirtiniz";
                }
            }

            if (fisler.FISTURID == 27)
            {
                if (cari_hareket.Count != 1)
                {
                    mesaj = "Alınan Vade Farkı  Faturasında Tek Cari Olmalıdır";
                }
            }
            if (fisler.FISTURID == 28)
            {
                if (cari_hareket.Count != 1)
                {
                    mesaj = "Verilen Vade Farkı  Faturasında Tek Cari Olmalıdır";
                }
            }

            int? TRA_ID = new Helper(configuration).sdbint("Select [TRA_ID]  from [PARA_HAREKET] where [FIS_ID]=" + fisler.FIS_ID);

            FISLER f = new FISLER();
            f.CDATE = DateTime.Now;
            f.FISTARIHI = fisler.FISTARIHI;
            f.FISTURID = fisler.FISTURID;
            f.CUSR_ID = 0;
            f.DOVIZID = fisler.DOVIZID;
            f.FICHENO = fisler.FICHENO;
            f.FIS_ID = fisler.FIS_ID;
            f.TRANSACTION_ID = fisler.TRANSACTION_ID;
            Doviz_Kurlari dk = await kur_bulAsync((int)fisler.DOVIZID);

            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {

                    FISLERRepository fisrepo = new FISLERRepository(unitOfWork);
                    bool fisinsert = await fisrepo.UpdateAsync(f);
                    if (!fisinsert) { unitOfWork.Rollback(); return false; }

                    decimal? toplam = 0m;
                    PARA_HAREKET parahareket = new PARA_HAREKET();
                    try
                    {

                        for (int i = 0; i < cari_hareket.Count; i++)
                        {
                            CARIHAREKETRepository cari = new CARIHAREKETRepository(unitOfWork, configuration);

                            CARIHAREKET ck = new CARIHAREKET();
                            SetBorcAlacak(out parahareket, out ck, fisler.FISTURID);
                            ck.CARI_HAR_ID = cari_hareket[i].CARI_HAR_ID;
                            ck.CARI_ID = cari_hareket[i].CARI_ID;
                            ck.CDATE = DateTime.Now;
                            ck.ACIKLAMA = cari_hareket[i].ACIKLAMA;
                            ck.TUTAR = cari_hareket[i].TUTAR;
                            ck.BNK_ID = cari_hareket[i].BNK_ID;
                            ck.FIS_ID = f.FIS_ID;

                            if (fisler.FISTURID == 29 || fisler.FISTURID == 30)
                                ck.TUTAR = cari_hareket[i].TOPLAM;

                            ck.FIS_ID = f.FIS_ID;
                            ck.DOV_ID = f.DOVIZID;
                            ck.CEKSENNO = cari_hareket[i].CEKSENNO;
                            ck.TAHNO = cari_hareket[i].TAHNO;
                            ck.ISLEMTARIHI = f.FISTARIHI;
                            ck.ACIKLAMA = cari_hareket[i].ACIKLAMA;
                            ck.LDOV_ID = 1;
                            ck.KUR1 = dk.Doviz1_Deger;
                            ck.KUR2 = dk.Doviz2_Deger;
                            ck.STOPAJORAN = cari_hareket[i].STOPAJORAN;
                            ck.STOPAJTUTAR = cari_hareket[i].STOPAJTUTAR;
                            ck.FONPAYIORAN = cari_hareket[i].FONPAYIORAN;
                            ck.FONPAYITUTAR = cari_hareket[i].FONPAYITUTAR;
                            ck.BRKDVORAN = cari_hareket[i].BRKDVORAN;
                            ck.BRKDVTUTAR = cari_hareket[i].BRKDVTUTAR;
                            ck.NET = cari_hareket[i].NET;
                            ck.BRUT = cari_hareket[i].BRUT;
                            ck.KESTUTAR = cari_hareket[i].KESTUTAR;
                            ck.TOPLAM = cari_hareket[i].TOPLAM;
                            ck.TRANSACTION_ID = fisler.TRANSACTION_ID;
                            //bilemiyorum nasıldı
                            if (cari_hareket[i].TOPLAM == 0m)
                            {
                                toplam += cari_hareket[i].TUTAR;
                            }
                            else
                            {
                                toplam += cari_hareket[i].TOPLAM;
                            }

                            await cari.UpdateAsync(ck);
                        }
                        //Unit of work ile para hareketi eklenecek
                        parahareket.CDATE = DateTime.Now;
                        parahareket.TARIH = fisler.FISTARIHI;
                        parahareket.TUTAR = toplam;
                        parahareket.DOV_ID = fisler.DOVIZID;
                        parahareket.LDOV_ID = 0;
                        parahareket.KUR1 = dk.Doviz1_Deger;
                        parahareket.KUR2 = dk.Doviz2_Deger;
                        parahareket.CARI_ID = fisler.CARIID;
                        parahareket.FIS_ID = fisler.FIS_ID;
                        parahareket.TRANSACTION_ID = fisler.TRANSACTION_ID;
                        parahareket.TRA_ID = TRA_ID;

                        PARA_HAREKETRepository parahareketrepo = new PARA_HAREKETRepository(unitOfWork, configuration);
                        bool paraharupdate = await parahareketrepo.UpdateAsync(parahareket);


                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();

                }
            }
            return false;
        }

        public async Task<bool> DeleteAsync(object ID)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    var query = "DeleteFISLER";
                    int f = 0;
                    var parameters = new DynamicParameters();
                    parameters.Add("@FIS_ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);
                    f = await unitOfWork.Connection.ExecuteAsync(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);

                    var qdelete = "Delete from CARIHAREKET where FIS_ID=@FIS_ID";

                    var parameters2 = new DynamicParameters();
                    parameters2.Add("@FIS_ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);
                    await unitOfWork.Connection.QueryAsync<int>(qdelete, parameters2, unitOfWork.Transaction);

                    var para_hareket = "Delete from [PARA_HAREKET] where FIS_ID=@FIS_ID";

                    var parameters3 = new DynamicParameters();
                    parameters3.Add("@FIS_ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);
                    await unitOfWork.Connection.QueryAsync<int>(para_hareket, parameters3, unitOfWork.Transaction);

                    unitOfWork.Commit();
                    return true;

                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return false;
                }
            }







            return false;
        }

        public void Dispose()
        {

        }

        public void SetBorcAlacak(out PARA_HAREKET parahareket, out CARIHAREKET ck, int? TUR_ID)
        {

            parahareket = new PARA_HAREKET();
            ck = new CARIHAREKET();


            ck.BORC = 0;
            ck.ALACAK = 0;
            ck.GIRISMI = 0;
            ck.CIKISMI = 0;
            ck.FTUR_ID = 0;

            parahareket.BORC = 0;
            parahareket.ALACAK = 0;
            parahareket.GIRIS = 0;
            parahareket.CIKIS = 0;
            parahareket.TUR_ID = 0;

            if (TUR_ID == 20)
            {

                ck.BORC = 1;

                ck.FTUR_ID = 20;

                parahareket.BORC = 1;

                parahareket.TUR_ID = 20;

            }


            //Cari ALACAK
            if (TUR_ID == 21)
            {
                ck.ALACAK = 1;
                ck.FTUR_ID = 21;
                parahareket.ALACAK = 1;
                parahareket.TUR_ID = 21;
            }
            //Nakit Tahsilat
            if (TUR_ID == 22)
            {
                ck.GIRISMI = 1;
                ck.FTUR_ID = 22;
                parahareket.BORC = 0;
                parahareket.ALACAK = 0;
                parahareket.GIRIS = 1;
                parahareket.CIKIS = 0;
                parahareket.TUR_ID = 22;
            }

            //Nakit Ödeme
            if (TUR_ID == 23)
            {
                ck.GIRISMI = 1;
                ck.FTUR_ID = 23;
                parahareket.GIRIS = 1;
                parahareket.TUR_ID = 23;

            }



            //Verilen Vade Farkı Faturası
            if (TUR_ID == 27)
            {
                ck.ALACAK = 1;
                ck.FTUR_ID = 27;
                parahareket.ALACAK = 1;
                parahareket.TUR_ID = 27;
            }
            //Alınan Vade Farkı Faturası
            if (TUR_ID == 28)
            {
                ck.BORC = 1;
                ck.FTUR_ID = 28;
                parahareket.BORC = 1;
                parahareket.TUR_ID = 28;
            }
            if (TUR_ID == 29)
            {
                ck.BORC = 1;
                ck.FTUR_ID = 29;
                parahareket.BORC = 1;
                parahareket.TUR_ID = 29;
            }
            if (TUR_ID == 30)
            {
                ck.ALACAK = 1;
                ck.FTUR_ID = 30;
                parahareket.ALACAK = 1;
                parahareket.TUR_ID = 30;
            }
            if (TUR_ID == 31)
            {

                ck.GIRISMI = 1;
                ck.FTUR_ID = 31;
                parahareket.GIRIS = 1;
                parahareket.TUR_ID = 31;
            }
            if (TUR_ID == 32)
            {


                ck.CIKISMI = 1;
                ck.FTUR_ID = 32;
                parahareket.CIKIS = 1;
                parahareket.TUR_ID = 32;

            }
            if (TUR_ID == 33)
            {
                ck.CIKISMI = 1;
                ck.FTUR_ID = 33;
                parahareket.CIKIS = 1;
                parahareket.TUR_ID = 33;
            }
            if (TUR_ID == 34)
            {
                ck.GIRISMI = 1;
                ck.FTUR_ID = 34;
                parahareket.GIRIS = 1;
                parahareket.TUR_ID = 34;
            }


        }

        Task<CARIFISDTO> IRepository<CARIFISDTO>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
