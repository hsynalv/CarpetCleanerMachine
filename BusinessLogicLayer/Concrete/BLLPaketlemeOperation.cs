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
    public class BLLPaketlemeOperation : TransactionFolder.Transaction, IMachineOperation<PaketlemeMakine>
    {
        DLLPaketlemeOperation paketlemeOperation;
        PaketlemeMakine Temp;
        int returnvalue = 0;

        public BLLPaketlemeOperation()
        {
            paketlemeOperation = new DLLPaketlemeOperation();
        }

        public PaketlemeMakine Find(Guid ID)
        {
            return paketlemeOperation.Find(ID);
        }

        public List<PaketlemeMakine> WhereMusteri(Guid ID)
        {
            return paketlemeOperation.WhereMusteri(ID);
        }

        public List<PaketlemeMakine> whereMachine(bool kontrol)
        {
            return paketlemeOperation.WhereMachine(kontrol);
        }

        public List<PaketlemeMakine> WhereMachineStock(bool kontrol)
        {
            return paketlemeOperation.WhereMachineStock(kontrol);
        }

        public PaketlemeMakine FindUretimNo(int ara)
        {
            return paketlemeOperation.FindUrunNo(ara);
        }

        public List<PaketlemeMakine> GetAll()
        {
            return paketlemeOperation.GetAll();
        }

        public int Guncelle(Guid ID, PaketlemeMakine entity, Yetkili yetkili, string Log = null)
        {
            Temp = Find(ID);
            #region guncelleme
            Temp.Te_MusteriAdi = entity.Te_MusteriAdi;
            Temp.Te_MusteriNo = entity.Te_MusteriNo;
            Temp.Te_UretimNo = entity.Te_UretimNo;
            Temp.stok_mu = entity.stok_mu;
            Temp.Te_SiparisTarihi = entity.Te_SiparisTarihi;
            Temp.Te_TerminTarihi = entity.Te_TerminTarihi;
            Temp.Oz_SaseTipi = entity.Oz_SaseTipi;
            Temp.Oz_HaliGirisOlcu = entity.Oz_HaliGirisOlcu;
            Temp.Oz_FanSayisi = entity.Oz_FanSayisi;
            Temp.Oz_Parfumleme = entity.Oz_Parfumleme;
            Temp.Sip_PlastikMalzeme = entity.Sip_PlastikMalzeme;
            Temp.Sip_RulmanGrup = entity.Sip_RulmanGrup;
            Temp.Sip_Boru_ProfilGrup = entity.Sip_Boru_ProfilGrup;
            Temp.Sip_FircaGrup = entity.Sip_FircaGrup;
            Temp.Sip_MotorGrup = entity.Sip_MotorGrup;
            Temp.Sip_HirdavatGrup = entity.Sip_HirdavatGrup;
            Temp.Sip_ElektrikSiparis = entity.Sip_ElektrikSiparis;
            Temp.Sip_ButonEtiketi = entity.Sip_ButonEtiketi;
            Temp.Sip_Ce_Etiketi = entity.Sip_Ce_Etiketi;
            Temp.Arge_LazerKesim = entity.Arge_LazerKesim;
            Temp.Arge_Bukum = entity.Arge_Bukum;
            Temp.Arge_BoruProfilKaynak = entity.Arge_BoruProfilKaynak;
            Temp.Arge_BoruDisTorna = entity.Arge_BoruDisTorna;
            Temp.Arge_FanTorna_Kama_Balans = entity.Arge_FanTorna_Kama_Balans;
            Temp.Arge_IcTornaMalzeme = entity.Arge_IcTornaMalzeme;
            Temp.Arge_KaynakIslem = entity.Arge_KaynakIslem;
            Temp.Arge_DisKaplamaKaynak = entity.Arge_DisKaplamaKaynak;
            Temp.Arge_DisKaplamaBoya = entity.Arge_DisKaplamaBoya;
            Temp.Arge_BaskiTopuGalvaniz = entity.Arge_BaskiTopuGalvaniz;
            Temp.Arge_BoruGalvaniz = entity.Arge_BoruGalvaniz;
            Temp.Arge_ŞaseKaldirma = entity.Arge_ŞaseKaldirma;
            Temp.Arge_ŞaseMontaj = entity.Arge_ŞaseMontaj;
            Temp.Arge_UniteSaseMontaj = entity.Arge_UniteSaseMontaj;
            Temp.Arge_ElektrikPanoDosenme = entity.Arge_ElektrikPanoDosenme;
            Temp.Arge_PanoSaseMontaj = entity.Arge_PanoSaseMontaj;
            Temp.Arge_Kablolama = entity.Arge_Kablolama;
            Temp.Arge_TopMontaj = entity.Arge_TopMontaj;
            Temp.Arge_BantOlcu = entity.Arge_BantOlcu;
            Temp.Arge_BantMontaj = entity.Arge_BantMontaj;
            Temp.Arge_KumandaPanoAtama = entity.Arge_KumandaPanoAtama;
            Temp.Dig_SevkDurum = entity.Dig_SevkDurum;
            Temp.Dig_TestAsaması = entity.Dig_TestAsaması;

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            #endregion
            TransactionKullan(() =>
            {
                returnvalue = paketlemeOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Paketleme Makinesi Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnvalue;
        }

        public int Kaydet(PaketlemeMakine entity, Yetkili yetkili)
        {
            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            TransactionKullan(() =>
            {
                returnvalue = paketlemeOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.Te_MusteriAdi}' na ait {entity.Te_UretimNo} Üretim Nolu Paketleme Makinesi Eklendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnvalue;
        }

        public int Sil(Guid ID, Yetkili yetkili)
        {
            Temp = Find(ID);
            TransactionKullan(() =>
            {
                returnvalue = paketlemeOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Paketleme Makinesi Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnvalue;
        }


    }
}
