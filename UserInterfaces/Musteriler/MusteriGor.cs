using BusinessLogicLayer.Concrete;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaces.DigerFormlar;

namespace UserInterfaces.Musteriler
{
    public partial class MusteriGor : Form
    {
        Yetkili yetkili;
        Musteri Temp;
        BLLMusteriOperation musteriOperation;
        public MusteriGor(Yetkili yetkili_)
        {
            InitializeComponent();
            musteriOperation = new BLLMusteriOperation();
            yetkili = yetkili_;
        }

        private void MusteriGor_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = Guid.Parse((dataGridView1.CurrentRow.Cells[0].Value).ToString());
            Temp = musteriOperation.Find(row);
        }

        private void refresh()
        {
            dataGridView1.DataSource = musteriOperation.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisGir sip = new SiparisGir(Temp);
            sip.MdiParent = this.MdiParent;
            sip.Show();
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                MusteriEkle guncelle = new MusteriEkle(yetkili, Temp);
                guncelle.MdiParent = this.MdiParent;
                guncelle.Show();
            }
            else
            {
                lbl_message.Text = "Lütfen Müşteri Seçiniz!";
            }
        }

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                int returnValue = musteriOperation.Sil(Temp.MusteriNo, Temp, yetkili);
                if (returnValue > 0)
                {
                    lbl_message.Text = $"{Temp.MusteriAdı} Silindi.";

                }
            }
            else
            {
                lbl_message.Text = "Lütfen Müşteri Seçiniz!";
            }
        }

        private void btn_makGör_Click_1(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                Makineler makine = new Makineler(Temp);
                makine.MdiParent = this.MdiParent;
                makine.Text = Temp.MusteriAdı + "Makineleri";
                makine.Show();
            }
        }

        private void btn_yenile_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void txt_ara_ad_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteriOperation.GetAllByMusteriAdi(txt_ara_ad.Text.ToUpper());
            lbl_message.Text = musteriOperation.GetAllByMusteriAdi(txt_ara_ad.Text.ToUpper()).Count().ToString();
        }

        private void txt_ara_il_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteriOperation.GetAllByİl(txt_ara_il.Text.ToUpper());
            lbl_message.Text = musteriOperation.GetAllByİl(txt_ara_il.Text.ToUpper()).Count().ToString();
        }
    }
}
