using BusinessLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaces.Makine_Ekle;

namespace UserInterfaces.DigerFormlar
{
    public partial class StokMakineler : Form
    {
        Yetkili yetkili;
        BLLMecOperation mecOperation;
        BLLOtomatikYikamaOperation otomatikYikamaOperation;
        BLLPaketlemeOperation paketlemeOperation;
        BLLSikmaOperation sikmaOperation;
        BLLCırpmaOperation cırpmaOperation;
        string row;
        MakineBase Temp;


        public StokMakineler(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkili = yetkili_;
            mecOperation = new BLLMecOperation();
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            paketlemeOperation = new BLLPaketlemeOperation();
            sikmaOperation = new BLLSikmaOperation();
            cırpmaOperation = new BLLCırpmaOperation();
        }


        private void StokMakineler_Load(object sender, EventArgs e)
        {
            DataDoldur();
        }

        private void DataDoldur()
        {
            dataOtomatik.DataSource = otomatikYikamaOperation.WhereMachineStock(true);
            DataMeç.DataSource = mecOperation.WhereMachineStock(true);
            dataCırpma.DataSource = cırpmaOperation.WhereMachineStock(true);
            DataSıkma.DataSource = sikmaOperation.WhereMachineStock(true);
            DataPaketleme.DataSource = paketlemeOperation.WhereMachineStock(true);

            dataOtomatik.AutoResizeColumns();
            DataMeç.AutoResizeColumns();
            dataCırpma.AutoResizeColumns();
            DataSıkma.AutoResizeColumns();
            DataPaketleme.AutoResizeColumns();
        }


        private void dataOtomatik_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = ((string)dataOtomatik.CurrentRow.Cells[6].Value);
            Temp = otomatikYikamaOperation.FindUretimNo(int.Parse(row));
            OtomatikYikamaEkle guncelle = new OtomatikYikamaEkle(yetkili, (Entites.Machine.OtomatikHaliYikama)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();
        }

        private void DataPaketleme_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = (DataPaketleme.CurrentRow.Cells[6].Value).ToString();
            Temp = paketlemeOperation.FindUretimNo(int.Parse(row));
            PaketlemeEkle guncelle = new PaketlemeEkle(yetkili, (Entites.Machine.PaketlemeMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();
        }

        private void dataCırpma_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = (dataCırpma.CurrentRow.Cells[6].Value).ToString();
            Temp = cırpmaOperation.FindUretimNo(int.Parse(row));
            TozCırpmaEkle guncelle = new TozCırpmaEkle(yetkili, (Entites.Machine.TozCırpmaMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();
        }

        private void DataSıkma_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = (DataSıkma.CurrentRow.Cells[6].Value).ToString();
            Temp = sikmaOperation.FindUretimNo(int.Parse(row));
            SikmaEkle guncelle = new SikmaEkle(yetkili, (Entites.Machine.SikmaMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();
        }

        private void DataMeç_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = (DataMeç.CurrentRow.Cells[6].Value).ToString();
            Temp = mecOperation.FindUretimNo(int.Parse(row));
            MecMakineEkle guncelle = new MecMakineEkle(yetkili, (Entites.Machine.MecMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();

        }
    }
}
