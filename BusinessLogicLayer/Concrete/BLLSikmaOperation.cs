using BusinessLogicLayer.Abstract;
using DatabaseLogicLayer.Concrete;
using Entites;
using Entites.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class BLLSikmaOperation : TransactionFolder.Transaction, IMachineOperation<SikmaMakine>
    {
        DLLSikmaOperation sikmaOperation;
        SikmaMakine Temp;
        int returnValue = 0;

        public BLLSikmaOperation()
        {
            sikmaOperation = new DLLSikmaOperation();
        }

        public List<SikmaMakine> WhereMusteri(Guid ID)
        {
            return sikmaOperation.WhereMusteri(ID);
        }

        public SikmaMakine Find(Guid ID)
        {
           return sikmaOperation.Find(ID);
        }

        public List<SikmaMakine> whereMachine(bool kontrol)
        {
            return sikmaOperation.WhereMachine(kontrol);
        }

        public List<SikmaMakine> WhereMachineStock(bool kontrol)
        {
            return sikmaOperation.WhereMachineStock(kontrol);
        }

        public SikmaMakine FindUretimNo(int ara)
        {
            return sikmaOperation.FindUrunNo(ara);
        }

        public List<SikmaMakine> GetAll()
        {
            return sikmaOperation.GetAll();
        }

        public int Guncelle(Guid ID, SikmaMakine entity, Yetkili yetkili, string Log = null)
        {
            Temp = Find(ID);
            #region guncelleme
            Temp.Te_MusteriAdi = entity.Te_MusteriAdi;
            Temp.Te_MusteriNo = entity.Te_MusteriNo;
            Temp.Te_UretimNo = entity.Te_UretimNo;
            Temp.stok_mu = entity.stok_mu;
            Temp.Te_SiparisTarihi = entity.Te_SiparisTarihi;
            Temp.Te_TerminTarihi = entity.Te_TerminTarihi;
            Temp.Oz_SaseUzunluğu = entity.Oz_SaseUzunluğu;
            Temp.Oz_TamburCap = entity.Oz_TamburCap;
            Temp.Oz_FrenSistem = entity.Oz_FrenSistem;
            Temp.Oz_HaliTasımaArabaSayi = entity.Oz_HaliTasımaArabaSayi;
            Temp.Sip__Mil_LamaMalzeme = entity.Sip__Mil_LamaMalzeme;
            Temp.Sip_RulmanGrup = entity.Sip_RulmanGrup;
            Temp.Sip_Yatak_YaglamaGrup = entity.Sip_Yatak_YaglamaGrup;
            Temp.Sip_KapakkGrup = entity.Sip_KapakkGrup;
            Temp.Sip_MotorGrup = entity.Sip_MotorGrup;
            Temp.Sip_HirdavatGrup = entity.Sip_HirdavatGrup;
            Temp.Sip_ElektrikSiparis = entity.Sip_ElektrikSiparis;
            Temp.Sip_ButonEtiketi = entity.Sip_ButonEtiketi;
            Temp.Sip_Ce_Etiketi = entity.Sip_Ce_Etiketi;
            Temp.Sip_Digerleri = entity.Sip_Digerleri;
            Temp.Arge_LazerKesim = entity.Arge_LazerKesim;
            Temp.Arge_Bukum = entity.Arge_Bukum;
            Temp.Arge_TamburDurum = entity.Arge_TamburDurum;
            Temp.Arge_IcTornaMalzeme = entity.Arge_IcTornaMalzeme;
            Temp.Arge_KaynakIslem = entity.Arge_KaynakIslem;
            Temp.Arge_NikelajMalzeme = entity.Arge_NikelajMalzeme;
            Temp.Arge_BoyahaneDurum = entity.Arge_BoyahaneDurum;
            Temp.Arge_MontajAsama = entity.Arge_MontajAsama;
            Temp.Arge_ElektrikPanoDosenme = entity.Arge_ElektrikPanoDosenme;
            Temp.Arge_PanoSaseMontaj = entity.Arge_PanoSaseMontaj;
            Temp.Arge_Kablolama = entity.Arge_Kablolama;
            Temp.Dig_SevkDurum = entity.Dig_SevkDurum;
            Temp.Dig_TestAsaması = entity.Dig_TestAsaması;

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            #endregion
            TransactionKullan(() =>
            {
                returnValue = sikmaOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Sıkma Makinesi Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public int Kaydet(SikmaMakine entity, Yetkili yetkili)
        {

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            TransactionKullan(() =>
            {
                returnValue = sikmaOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.Te_MusteriAdi}' na ait {entity.Te_UretimNo} Üretim Nolu Sıkma Makinesi Eklendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public int Sil(Guid ID, Yetkili yetkili)
        {
            Temp = Find(ID);
            TransactionKullan(() =>
            {
                returnValue = sikmaOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Sıkma Makinesi Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }


    }
}
