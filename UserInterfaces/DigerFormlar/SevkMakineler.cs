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
    public partial class SevkMakineler : Form
    {
        BLLMecOperation mecOperation;
        BLLOtomatikYikamaOperation otomatikYikamaOperation;
        BLLPaketlemeOperation paketlemeOperation;
        BLLSikmaOperation sikmaOperation;
        BLLCırpmaOperation cırpmaOperation;
        Yetkili yetkili;
        public SevkMakineler(Yetkili yetkili_)
        {
            InitializeComponent();
            mecOperation = new BLLMecOperation();
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            paketlemeOperation = new BLLPaketlemeOperation();
            sikmaOperation = new BLLSikmaOperation();
            cırpmaOperation = new BLLCırpmaOperation();
            yetkili = yetkili_;
        }

        private void SevkMakineler_Load(object sender, EventArgs e)
        {
            DataDoldur();
        }

        private void DataDoldur()
        {
            dataOtomatik.DataSource = otomatikYikamaOperation.whereMachine(true);
            DataMeç.DataSource = mecOperation.whereMachine(true);
            dataCırpma.DataSource = cırpmaOperation.whereMachine(true);
            DataSıkma.DataSource = sikmaOperation.whereMachine(true);
            DataPaketleme.DataSource = paketlemeOperation.whereMachine(true);

            dataOtomatik.Columns[0].Visible = false;
            dataOtomatik.Columns[1].Visible = false;
            dataCırpma.Columns[0].Visible = false;
            dataCırpma.Columns[1].Visible = false;
            DataMeç.Columns[0].Visible = false;
            DataMeç.Columns[1].Visible = false;
            DataSıkma.Columns[0].Visible = false;
            DataSıkma.Columns[1].Visible = false;
            DataPaketleme.Columns[0].Visible = false;
            DataPaketleme.Columns[1].Visible = false;

            for (int i = 10; i < 32; i++)
            {
                DataMeç.Columns[i].Visible = false;
            }

            for (int i= 10; i < 46; i++)
            {
                DataPaketleme.Columns[i].Visible = false;
            }
            for (int i = 10; i < 45; i++)
            {
                dataCırpma.Columns[i].Visible = false;
            }
           

            for (int i = 10; i < 54; i++)
            {
                dataOtomatik.Columns[i].Visible = false;
            }

            for (int i = 10; i < 36; i++)
            {
                DataSıkma.Columns[i].Visible = false;
            }


            dataOtomatik.Columns[56].Visible = false;
            DataMeç.Columns[34].Visible = false;
            dataCırpma.Columns[47].Visible = false; 
            DataSıkma.Columns[38].Visible = false;
            DataPaketleme.Columns[48].Visible = false;

            dataOtomatik.AutoResizeColumns();
            DataMeç.AutoResizeColumns();
            dataCırpma.AutoResizeColumns();
            DataSıkma.AutoResizeColumns();
            DataPaketleme.AutoResizeColumns();
        }


    }
}
