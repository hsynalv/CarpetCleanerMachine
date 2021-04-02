using DatabaseLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public  class BLLMusteriOperation:TransactionFolder.Transaction
    {
        MusteriOperation musteriOperation;
        Musteri Temp;
        int returnValue = 0;
        public  BLLMusteriOperation()
        {
            musteriOperation = new MusteriOperation();
        }



        public  Musteri MusteriAra(string musteriNO)
        {
            return musteriOperation.Find(musteriNO);
        }

        public  Musteri Find(Guid ID)
        {
            return musteriOperation.Find(ID);
        }

        public Musteri FindMusteriAdi(string MusteriAdi)
        {
            return musteriOperation.FindMusteriAdi(MusteriAdi);
        }

        public List<Musteri> GetAllByMusteriAdi(string key)
        {
            return musteriOperation.GetAllByMusteriAdi(key);
        }
        public List<Musteri> GetAllByİl(string key)
        {
            return musteriOperation.GetAllByİl(key);
        }

        public List<Musteri> GetAll()
        {
            return musteriOperation.GetAll();
        }

        public List<Musteri> Get_Ulke(string ulke)
        {
            return musteriOperation.Get_Ulke(ulke);
        }

        public List<Musteri> Get_il(string il)
        {
            return musteriOperation.Get_Il(il);
        }

        public int Guncelle(string MusteriNo, Musteri entity,Yetkili yetkili)
        {
            Temp = MusteriAra(MusteriNo);
            #region Güncelleme
            Temp.Ulke = entity.Ulke;
            Temp.Il = entity.Ulke;
            Temp.MusteriAdı = entity.MusteriAdı;
            Temp.MusteriNo = entity.MusteriNo;
            Temp.TelefonNo = entity.TelefonNo;
            Temp.Adres = entity.Adres;
            #endregion
            TransactionKullan(() =>
            {
                returnValue = musteriOperation.Guncelle(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.MusteriNo} nolu, {entity.MusteriAdı}  Güncellendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public int Kaydet(Musteri entity,Yetkili yetkili)
        {
            TransactionKullan(() =>
            {
                returnValue = musteriOperation.Kaydet(entity);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.MusteriNo} Müşteri Numaralı, {entity.MusteriAdı}  eklendi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;
        }

        public int Sil (string MusteriNo,Musteri entity,Yetkili yetkili)
        {
            Temp = MusteriAra(MusteriNo);
            TransactionKullan(() =>
            {
                returnValue = musteriOperation.Sil(Temp);
                DLLOlayKaydı.OlayEkle(new OlayKayit()
                {
                    dateTime = DateTime.Now,
                    ID = Guid.NewGuid(),
                    Islem = $"{entity.MusteriNo} nolu, {entity.MusteriAdı}  silindi.",
                    Kullanici = yetkili.İsimSoyisim,
                });
            });
            return returnValue;

        }

        public bool kontrol(Musteri musteri)
        {
            bool control = true;
            List<Musteri> musteriler = GetAll();

            foreach (Musteri item in musteriler)
            {
                if (item.MusteriNo == musteri.MusteriNo)
                {
                    control = false;
                    break;
                }
                else
                {
                    control = true;
                }
            }

            return control;
        }
    }
}
