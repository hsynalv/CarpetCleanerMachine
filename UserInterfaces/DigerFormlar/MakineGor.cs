using BusinessLogicLayer.Concrete;
using Entites;
using Entites.Machine;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;


namespace UserInterfaces.DigerFormlar
{
    public partial class MakineGor : Form
    {
        int row;
        Yetkili yetkili;
        BLLMecOperation mecOperation;
        BLLOtomatikYikamaOperation otomatikYikamaOperation;
        BLLPaketlemeOperation paketlemeOperation;
        BLLSikmaOperation sikmaOperation;
        MakineBase Temp;
        BLLCırpmaOperation cırpmaOperation;



        private void DataDoldur()
        {
            dataOtomatik.DataSource = otomatikYikamaOperation.whereMachine(false);
            DataMeç.DataSource = mecOperation.whereMachine(false);
            dataCırpma.DataSource = cırpmaOperation.whereMachine(false);
            DataSıkma.DataSource = sikmaOperation.whereMachine(false);
            DataPaketleme.DataSource = paketlemeOperation.whereMachine(false);
            dataCırpma.AutoResizeColumns();
            dataOtomatik.AutoResizeColumns();
            DataSıkma.AutoResizeColumns();
            DataMeç.AutoResizeColumns();
            DataPaketleme.AutoResizeColumns();
        }
        public MakineGor(Yetkili yetkili_)
        {
            InitializeComponent();
            yetkili = yetkili_;
            mecOperation = new BLLMecOperation();
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            paketlemeOperation = new BLLPaketlemeOperation();
            sikmaOperation = new BLLSikmaOperation();
            cırpmaOperation = new BLLCırpmaOperation();
        }

        private void MakineGor_Load(object sender, EventArgs e)
        {
            DataDoldur();
            KolonGizle();
        }

        private void KolonGizle()
        {
            try
            {
                dataOtomatik.Columns["ID"].Visible = false;
                dataCırpma.Columns["ID"].Visible = false;
                DataMeç.Columns["ID"].Visible = false;
                DataPaketleme.Columns["ID"].Visible = false;
                DataSıkma.Columns["ID"].Visible = false;

                dataOtomatik.Columns["MusteriID"].Visible = false;
                dataCırpma.Columns["MusteriID"].Visible = false;
                DataMeç.Columns["MusteriID"].Visible = false;
                DataPaketleme.Columns["MusteriID"].Visible = false;
                DataSıkma.Columns["MusteriID"].Visible = false;

                dataOtomatik.Columns["Musteri"].Visible = false;
                dataCırpma.Columns["Musteri"].Visible = false;
                DataMeç.Columns["Musteri"].Visible = false;
                DataPaketleme.Columns["Musteri"].Visible = false;
                DataSıkma.Columns["Musteri"].Visible = false;

            }
            catch (Exception)
            { }
           

        }

        private void dataOtomatik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((int)dataOtomatik.CurrentRow.Cells[6].Value);
            Temp = otomatikYikamaOperation.FindUretimNo(row);
            OtomatikYikamaEkle guncelle = new OtomatikYikamaEkle(yetkili, (Entites.Machine.OtomatikHaliYikama)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataDoldur();
        }

        private void DataPaketleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((int)DataPaketleme.CurrentRow.Cells[6].Value);
            Temp = paketlemeOperation.FindUretimNo(row);
            PaketlemeEkle guncelle = new PaketlemeEkle(yetkili, (Entites.Machine.PaketlemeMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();

        }

        private void dataCırpma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((int)dataCırpma.CurrentRow.Cells[6].Value);
            Temp = cırpmaOperation.FindUretimNo(row);
            TozCırpmaEkle guncelle = new TozCırpmaEkle(yetkili, (Entites.Machine.TozCırpmaMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();

        }

        private void DataSıkma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((int)DataSıkma.CurrentRow.Cells[6].Value);
            Temp = sikmaOperation.FindUretimNo(row);
            SikmaEkle guncelle = new SikmaEkle(yetkili, (Entites.Machine.SikmaMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();

        }

        private void DataMeç_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((int)DataMeç.CurrentRow.Cells[6].Value);
            Temp = mecOperation.FindUretimNo(row);
            MecMakineEkle guncelle = new MecMakineEkle(yetkili, (Entites.Machine.MecMakine)Temp);
            guncelle.MdiParent = this.MdiParent;
            guncelle.Show();
            
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            #region 1. deneme
            /*  int sutun = 1;
              int satir = 1;
              Excel.Application ExcelApp = new Excel.Application();
              ExcelApp.Visible = true;
              object Missing = Type.Missing;
              Workbook book = ExcelApp.Workbooks.Add(Missing);
              Worksheet sheet1 = (Worksheet)book.Sheets[1];



              for (int j = 0; j < dataOtomatik.Columns.Count; j++)
              {
                  Range myRange = (Range)sheet1.Cells[satir, sutun + j];
                  myRange.Value2 = dataOtomatik.Columns[j].HeaderText;
              }

              satir++;

              for (int i = 0; i < dataOtomatik.Rows.Count; i++)
              {
                  for (int j = 0; j < dataOtomatik.Columns.Count; j++)
                  {
                      Range myRange = (Range)sheet1.Cells[satir + i + 1, sutun + j + 1];
                      string hucre = dataOtomatik[j, i].Value == null ? "" : dataOtomatik[j, i].Value.ToString();
                      myRange.Value2 = hucre;
                      myRange.Select();
                  }
              }*/
            #endregion
            
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook ktp = uyg.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)ktp.Sheets[1];

            for (int i = 0; i < dataOtomatik.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dataOtomatik.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataOtomatik.Columns.Count; i++)
            {
                for (int j = 0; j < dataOtomatik.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dataOtomatik[i, j].Value;
                }
            }
        }
    }

}

