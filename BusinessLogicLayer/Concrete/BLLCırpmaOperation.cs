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
    public class BLLCırpmaOperation : TransactionFolder.Transaction, IMachineOperation<TozCırpmaMakine>
    {
        DLLCırpmaOperation cırpmaOperation;
        TozCırpmaMakine Temp;
        int returnValue = 0;

        public BLLCırpmaOperation()
        {
            cırpmaOperation = new DLLCırpmaOperation();
            
        }

        public TozCırpmaMakine Find(Guid ID)
        {
            return cırpmaOperation.Find(ID);
        }

        public List<TozCırpmaMakine> WhereMusteri(Guid ID)
        {
            return cırpmaOperation.WhereMusteri(ID);
        }

        public TozCırpmaMakine FindUretimNo(int ara)
        {
            return cırpmaOperation.FindUretimNo(ara);
        }

        public List<TozCırpmaMakine> GetAll()
        {
            return cırpmaOperation.GetAll();
        }

        public int Guncelle(Guid ID, TozCırpmaMakine entity, Yetkili yetkili,string Log = null)
        {
            Temp = Find(ID);
            #region Güncelle
            Temp.Te_MusteriAdi = entity.Te_MusteriAdi;
            Temp.Te_MusteriNo = entity.Te_MusteriNo;
            Temp.Te_UretimNo = entity.Te_UretimNo;
            Temp.stok_mu = entity.stok_mu;
            Temp.Te_SiparisTarihi = entity.Te_SiparisTarihi;
            Temp.Te_TerminTarihi = entity.Te_TerminTarihi;
            Temp.Oz_SaseTipi = entity.Oz_SaseTipi;
            Temp.Oz_HaliGirisOlcu = entity.Oz_HaliGirisOlcu;
            Temp.Oz_DovucuSayi = entity.Oz_DovucuSayi;
            Temp.Oz_FanSayi = entity.Oz_FanSayi;
            Temp.Oz_Helezon = entity.Oz_Helezon;
            Temp.Sip_PlasitkMalzeme = entity.Sip_PlasitkMalzeme;
            Temp.Sip_RulmanGrup = entity.Sip_RulmanGrup;
            Temp.Sip_Boru_ProfilGrup = entity.Sip_Boru_ProfilGrup;
            Temp.Sip_FircaGrup = entity.Sip_FircaGrup;
            Temp.Sip_MotorGrup = entity.Sip_MotorGrup;
            Temp.Sip_HirdavatGrup = entity.Sip_HirdavatGrup;
            Temp.Sip_ElektrikSiparis = entity.Sip_ElektrikSiparis;
            Temp.Sip_ButonEtiketi = entity.Sip_ButonEtiketi;
            Temp.Sip_Ce_Etiketi = entity.Sip_Ce_Etiketi;
            Temp.Sip_Digerleri = entity.Sip_Digerleri;
            Temp.Arge_LazerKesim = entity.Arge_LazerKesim;
            Temp.Arge_Bukum = entity.Arge_Bukum;
            Temp.Arge_BoruProfilKaynak = entity.Arge_BoruProfilKaynak;
            Temp.Arge_BoruDisTorna = entity.Arge_BoruDisTorna;
            Temp.Arge_FanTorna_Kama_Balans = entity.Arge_FanTorna_Kama_Balans;
            Temp.Arge_IcTornaMalzeme = entity.Arge_IcTornaMalzeme;
            Temp.Arge_KaynakIslem = entity.Arge_KaynakIslem;
            Temp.Arge_DovucuGalvaniz = entity.Arge_DovucuGalvaniz;
            Temp.Arge_BoyahaneDurum = entity.Arge_BoyahaneDurum;
            Temp.Arge_BoruGalvaniz = entity.Arge_BoruGalvaniz;
            Temp.Arge_ŞaseKaldirma = entity.Arge_ŞaseKaldirma;
            Temp.Arge_ŞaseMontaj = entity.Arge_ŞaseMontaj;
            Temp.Arge_ElektrikPanoDosenme = entity.Arge_ElektrikPanoDosenme;
            Temp.Arge_PanoSaseMontaj = entity.Arge_PanoSaseMontaj;
            Temp.Arge_Kablolama = entity.Arge_Kablolama;
            Temp.Arge_MontajDurumu = entity.Arge_MontajDurumu;
            Temp.Arge_BantOlcu = entity.Arge_BantOlcu;
            Temp.Arge_BantMontaj = entity.Arge_BantMontaj;
            Temp.Arge_KumandaPanoAtama = entity.Arge_KumandaPanoAtama;
            Temp.Dig_TestAsaması = entity.Dig_TestAsaması;
            Temp.Dig_SevkDurum = entity.Dig_SevkDurum;

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            #endregion
            TransactionKullan(() =>
            {
                returnValue = cırpmaOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait {Temp.Te_UretimNo} Üretim Nolu Çırpma Makinesi Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public int Kaydet(TozCırpmaMakine entity, Yetkili yetkili)
        {
            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            TransactionKullan(() =>
            {
                returnValue = cırpmaOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.Te_MusteriAdi}' na ait {entity.Te_UretimNo} Üretim Nolu Çırpma Makinesi Eklendi.",
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
                returnValue = cırpmaOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Çırpma Makinesi Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public List<TozCırpmaMakine> whereMachine(bool kontrol)
        {
            return cırpmaOperation.WhereMachine(kontrol);
        }

        public List<TozCırpmaMakine> WhereMachineStock(bool kontrol)
        {
            return cırpmaOperation.WhereMachineStock(kontrol);
        }
    }
}
