using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Abstract;
using DatabaseLogicLayer.Concrete;
using Entites;

namespace BusinessLogicLayer.Concrete
{
   public class BLLYetkiliOperation : TransactionFolder.Transaction, IMachineOperation<Yetkili>
    {
        YetkiliOperation yetkiliOperation;
        int returnvalue = 0;
        Yetkili Temp;
        public BLLYetkiliOperation()
        {
            yetkiliOperation = new YetkiliOperation();
        }

        public Yetkili Find(string kAdi,string sifre)
        {
            return yetkiliOperation.Find(kAdi, sifre);
        }

        public Yetkili Find(Guid ID)
        {
            return yetkiliOperation.Find(ID);
        }

        public List<Yetkili> GetAll()
        {
            return yetkiliOperation.GetAll();
        }

        public int Guncelle(Guid ID, Yetkili entity, Yetkili yetkili,string Log = null)
        {
            Temp = Find(ID);
            #region güncelleme

            Temp.Makineekle = entity.Makineekle;
            Temp.MakineGor = entity.MakineGor;
            Temp.Musteriekle = entity.Musteriekle;
            Temp.MusteriGor = entity.MusteriGor;
            Temp.SiparisEkle = entity.SiparisEkle;
            Temp.KullaniciAdi = entity.KullaniciAdi;
            Temp.Sifre = entity.Sifre;
            Temp.YoneticiYetki = entity.YoneticiYetki;
            #endregion
            TransactionKullan(() =>
            {
                returnvalue = yetkiliOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem =Log,
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnvalue;

        }

        public int Kaydet(Yetkili entity, Yetkili yetkili)
        {
            TransactionKullan(() =>
            {
                returnvalue = yetkiliOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.İsimSoyisim}' İsimli Personel {yetkili.İsimSoyisim} Tarafından Kaydedildi.",
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
                returnvalue = yetkiliOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{Temp.İsimSoyisim}' İsimli Personel {yetkili.İsimSoyisim} Tarafından Silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnvalue;
        }


        public List<Yetkili> whereMachine(bool kontrol)
        {
            throw new NotImplementedException();
        }
    }
}
