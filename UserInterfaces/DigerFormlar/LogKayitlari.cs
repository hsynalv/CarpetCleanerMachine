using DatabaseLogicLayer.Concrete;
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
    public partial class LogKayitlari : Form
    {
        public LogKayitlari()
        {
            InitializeComponent();
        }

        private void LogKayitlari_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sumakMusteriTakipDataSet1.OlayKayits' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            dataGridView1.DataSource = DLLOlayKaydı.OlayGetir();
            this.dataGridView1.AutoResizeColumns();
            this.dataGridView1.Columns[0].Visible = false;
        }
    }
}
