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

namespace UserInterfaces.DigerFormlar
{
    public partial class SiparisGir : Form
    {
        Musteri musteri;
        string FileName;
        string path;
        public SiparisGir(Musteri musteri_)
        {
            InitializeComponent();
            musteri = musteri_;
            if (musteri.Ulke == "TÜRKİYE")
            {
                path = @"C:\Siparişler\" + musteri.MusteriNo + "-" + musteri.Il + "-" + musteri.MusteriAdı + ".txt";
            }
            else
            {
                path = @"C:\Siparişler\" + musteri.MusteriNo + "-" + musteri.Il + "-" + musteri.MusteriAdı + ".txt";
            }
        }

        public SiparisGir(string FileName_)
        {
            InitializeComponent();
            FileName = FileName_;
            txtDoldur();
            path = @"C:\Siparişler\" + FileName + ".txt";
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileName))
            {  
                File.AppendAllText(path, richTextBox1.Text);

                this.Close();  
            }
            else
            {
                
                try
                {
                    if (!File.Exists(path))
                    {
                        FileStream FS = File.Create(path);
                        FS.Close();
                    }

                    File.AppendAllText(path, richTextBox1.Text);
                    this.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtDoldur()
        {
            richTextBox1.Text = File.ReadAllText(path);
        }

        private void SiparisGir_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileName))
            {
                File.Delete(path);

                this.Close();
            }
        }
    }
}
