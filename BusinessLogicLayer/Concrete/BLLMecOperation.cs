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
    public class BLLMecOperation : TransactionFolder.Transaction, IMachineOperation<MecMakine>
    {
        DLLMecMakineOperation mecMakineOperation;
        MecMakine Temp;
        int returnValue = 0;
        public BLLMecOperation()
        {
            mecMakineOperation = new DLLMecMakineOperation();
        }

        public  MecMakine Find(Guid ID)
        {
            return mecMakineOperation.Find(ID);
        }

        public MecMakine FindUretimNo(int ara)
        {
            return mecMakineOperation.FindUrunNo(ara);
        }

        public List<MecMakine> WhereMusteri(Guid ID)
        {
            return mecMakineOperation.WhereMusteri(ID);
        }

        public List<MecMakine> whereMachine(bool kontrol)
        {
            return mecMakineOperation.WhereMachine(kontrol);
        }

        public List<MecMakine> WhereMachineStock(bool kontrol)
        {
            return mecMakineOperation.WhereMachineStock(kontrol);
        }

        public List<MecMakine> GetAll()
        {
            return mecMakineOperation.GetAll();
        }

        public int Guncelle(Guid ID, MecMakine entity, Yetkili yetkili, string Log = null)
        {
            Temp = Find(ID);
            #region guncelleme
            Temp.Te_MusteriAdi = entity.Te_MusteriAdi;
            Temp.Te_UretimNo = entity.Te_UretimNo;
            Temp.stok_mu = entity.stok_mu;
            Temp.Te_SiparisTarihi = entity.Te_SiparisTarihi;
            Temp.Te_TerminTarihi = entity.Te_TerminTarihi;
            Temp.Oz_SaseTipi = entity.Oz_SaseTipi;
            Temp.Oz_KumandaSistem = entity.Oz_KumandaSistem;
            Temp.Oz_FircaKalinlik = entity.Oz_FircaKalinlik;
            Temp.Oz_YedekFrica = entity.Oz_YedekFrica;
            Temp.Oz_CiftYonSistem = entity.Oz_CiftYonSistem;
            Temp.Oz_KabloUzunluk = entity.Oz_KabloUzunluk;
            Temp.Sip_BoruGrup = entity.Sip_BoruGrup;
            Temp.Sip_MilGrup = entity.Sip_MilGrup;
            Temp.Sip_PlastikGrup = entity.Sip_PlastikGrup;
            Temp.Sip_FircaGrup = entity.Sip_FircaGrup;
            Temp.Sip_MotorGrup = entity.Sip_MotorGrup;
            Temp.Sip_HirdavatGrup = entity.Sip_HirdavatGrup;
            Temp.Sip_ElektrikSiparis = entity.Sip_ElektrikSiparis;
            Temp.Arge_LazerKEsim = entity.Arge_LazerKEsim;
            Temp.Arge_Bukum = entity.Arge_Bukum;
            Temp.Arge_BombeDurum = entity.Arge_BombeDurum;
            Temp.Arge_IcTornaMalzeme = entity.Arge_IcTornaMalzeme;
            Temp.Arge_KaynakIslem = entity.Arge_KaynakIslem;
            Temp.Arge_GalvanizIslem = entity.Arge_GalvanizIslem;
            Temp.Arge_MontajAsama = entity.Arge_MontajAsama;
            Temp.Arge_ElektrikPanoDoseme = entity.Arge_ElektrikPanoDoseme;
            Temp.Dig_SevkDurum = entity.Dig_SevkDurum;
            Temp.Dig_TestAsama = entity.Dig_TestAsama;

            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            #endregion
            TransactionKullan(() =>
            {
                returnValue = mecMakineOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait {Temp.Te_UretimNo} Üretim Nolu Meç Makinesi Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }


        public int Kaydet(MecMakine entity, Yetkili yetkili)
        {
            if (entity.Dig_SevkDurum == "Sevk Edildi")
            {
                Temp.Dig_SevkTarih = DateTime.Now.ToString();
            }
            TransactionKullan(() =>
            {
                returnValue = mecMakineOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.Te_MusteriAdi}' na ait {entity.Te_UretimNo} Üretim Nolu Meç Makinesi Eklendi.",
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
                returnValue = mecMakineOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.Te_MusteriAdi}' na ait Meç Makinesi Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

 
    }
}

