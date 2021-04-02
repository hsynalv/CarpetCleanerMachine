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

namespace UserInterfaces.DigerFormlar
{
    public partial class Makineler : Form
    {
        Musteri musteri;
        BLLMecOperation mecOperation;
        BLLOtomatikYikamaOperation otomatikYikamaOperation;
        BLLPaketlemeOperation paketlemeOperation;
        BLLSikmaOperation sikmaOperation;
        BLLCırpmaOperation cırpmaOperation;

        public Makineler(Musteri musteri_)
        {
            InitializeComponent();
            musteri = musteri_;
            mecOperation = new BLLMecOperation();
            otomatikYikamaOperation = new BLLOtomatikYikamaOperation();
            paketlemeOperation = new BLLPaketlemeOperation();
            sikmaOperation = new BLLSikmaOperation();
            cırpmaOperation = new BLLCırpmaOperation();
        }
        private void Doldur()
        {
            {
                {
                    dataCırpma.DataSource = cırpmaOperation.WhereMusteri(musteri.ID);
                }
                {
                    dataMeç.DataSource = mecOperation.WhereMusteri(musteri.ID);
                }
                {
                    dataOtomatik.DataSource = otomatikYikamaOperation.WhereMusteri(musteri.ID);
                }
                {
                    dataPaketleme.DataSource = paketlemeOperation.WhereMusteri(musteri.ID);
                }
                {
                    dataSıkma.DataSource = sikmaOperation.WhereMusteri(musteri.ID);
                }
            }
        }

        private void Makineler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
