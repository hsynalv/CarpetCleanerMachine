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
    public class BLLOtomatikYikamaOperation : TransactionFolder.Transaction, IMachineOperation<OtomatikHaliYikama>
    {
        DLLOtomatikyıkamaOperation otomatikyıkamaOperation;
        OtomatikHaliYikama Temp;
        int returnValue = 0;
        public BLLOtomatikYikamaOperation()
        {
            otomatikyıkamaOperation = new DLLOtomatikyıkamaOperation();
            
        }

        public OtomatikHaliYikama Find(Guid ID)
        {
            return otomatikyıkamaOperation.Find(ID);
        }

        public List<OtomatikHaliYikama> whereMachine(bool kontrol)
        {
            return otomatikyıkamaOperation.WhereMachine(kontrol);
        }

        public List<OtomatikHaliYikama> WhereMusteri(Guid ID)
        {
            return otomatikyıkamaOperation.WhereMusteri(ID);
        }

        public List<OtomatikHaliYikama> WhereMachineStock(bool kontrol)
        {
            return otomatikyıkamaOperation.WhereMachineStock(kontrol);
        }

        public OtomatikHaliYikama FindUretimNo(int ara)
        {
            return otomatikyıkamaOperation.FindUretimNo(ara);
        }

        public List<OtomatikHaliYikama> GetAll()
        {
            return otomatikyıkamaOperation.GetAll();
        }

        public int Guncelle(Guid ID, OtomatikHaliYikama entity, Yetkili yetkili, string Log = null)
        {
            Temp = Find(ID);
            #region guncelleme
            Temp.Te_UretimNo = entity.Te_UretimNo;
            Temp.stok_mu = entity.stok_mu;
            Temp.Te_SiparisTarihi = entity.Te_SiparisTarihi;
            Temp.Te_TerminTarihi = entity.Te_TerminTarihi;
            Temp.Oz_ŞaseTipi = entity.Oz_ŞaseTipi;
            Temp.Oz_HaliGiris = entity.Oz_HaliGiris;
            Temp.Oz_UniteSayisi = entity.Oz_UniteSayisi;
            Temp.Oz_EkranBoyutu = entity.Oz_EkranBoyutu;
            Temp.Oz_EtiketDili = entity.Oz_EtiketDili;
            Temp.Oz_KacParcaGidecek = entity.Oz_KacParcaGidecek;
            Temp.Oz_FircaSayisi = entity.Oz_FircaSayisi;
            Temp.Oz_UstRulo = entity.Oz_UstRulo;
            Temp.Oz_AltRulo = entity.Oz_AltRulo;
            Temp.Oz_Citileme = entity.Oz_Citileme;
            Temp.Oz_Gelberi = entity.Oz_Gelberi;
            Temp.Oz_HaliKatlamaSistemi = entity.Oz_HaliKatlamaSistemi;
            Temp.Sip_PlastikMalzeme = entity.Sip_PlastikMalzeme;
            Temp.Sip_RulmanGrubu = entity.Sip_RulmanGrubu;
            Temp.Sip_Boru_ProfilGrubu = entity.Sip_Boru_ProfilGrubu;
            Temp.Sip_FircaGrubu = entity.Sip_FircaGrubu;
            Temp.Sip_MotorGrubu = entity.Sip_MotorGrubu;
            Temp.Sip_HirdavatGrubu = entity.Sip_HirdavatGrubu;
            Temp.Sip_ElektrikSiparisi = entity.Sip_ElektrikSiparisi;
            Temp.Sip_ButonEtiketi = entity.Sip_ButonEtiketi;
            Temp.Sip_CE_Etiketi = entity.Sip_CE_Etiketi;
            Temp.Sip_Digerleri = entity.Sip_Digerleri;
            Temp.Arge_LazerKesim = entity.Arge_LazerKesim;
            Temp.Arge_Bukum = entity.Arge_Bukum;
            Temp.Arge_Boru_ProfilKaynak = entity.Arge_Boru_ProfilKaynak;
            Temp.Arge_BoruDisTorna = entity.Arge_BoruDisTorna;
            Temp.Arge_icTornalikMalzeme = entity.Arge_icTornalikMalzeme;
            Temp.Arge_Kaynakİslem = entity.Arge_Kaynakİslem;
            Temp.Arge_DisKaplamaKaynak = entity.Arge_DisKaplamaKaynak;
            Temp.Arge_DisKaplamaBoya = entity.Arge_DisKaplamaBoya;
            Temp.Arge_Sase_UniteGalvaniz = entity.Arge_Sase_UniteGalvaniz;
            Temp.Arge_BoruGalvaniz = entity.Arge_BoruGalvaniz;
            Temp.Arge_SaseKaldirmasi = entity.Arge_SaseKaldirmasi;
            Temp.Arge_SaseMontaj = entity.Arge_SaseMontaj;
            Temp.Arge_UniteMontaj = entity.Arge_UniteMontaj;
            Temp.Arge_UniteSaseMontaj = entity.Arge_UniteSaseMontaj;
            Temp.Arge_ElektrikPanoDösenmesi = entity.Arge_ElektrikPanoDösenmesi;
            Temp.Arge_PanoSaseMontaj = entity.Arge_PanoSaseMontaj;
            Temp.Arge_Kablolama = entity.Arge_Kablolama;
            Temp.Arge_TopMontaj = entity.Arge_TopMontaj;
            Temp.Arge_BantOlcu = entity.Arge_BantOlcu;
            Temp.Arge_OtomasyonYazilim = entity.Arge_OtomasyonYazilim;
            Temp.Arge_BantMontaj = entity.Arge_BantMontaj;
            Temp.Dig_SevkDurum = entity.Dig_SevkDurum;
            Temp.Dig_TestAsamasi = entity.Dig_TestAsamasi;

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            #endregion
            TransactionKullan(() =>
            {
                returnValue = otomatikyıkamaOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Otomatik Halı Yıkama Makinesi Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }


        public int Kaydet(OtomatikHaliYikama entity, Yetkili yetkili)
        {
            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            TransactionKullan(() =>
            {
                returnValue = otomatikyıkamaOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.Te_MusteriAdi}' na ait {entity.Te_UretimNo} Üretim Nolu Otomatik Yıkama Makinesi Eklendi.",
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
                returnValue = otomatikyıkamaOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Otomatik Halı Yıkama Makinesi Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }


    }
}
