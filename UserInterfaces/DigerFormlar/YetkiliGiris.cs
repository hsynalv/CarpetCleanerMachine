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
    public partial class YetkiliGiris : Form
    {
        public static bool kontrol;
        BLLYetkiliOperation yetkiliOperation;
        public static Yetkili yetkili;

        public  YetkiliGiris()
        {
            InitializeComponent();
            yetkiliOperation = new BLLYetkiliOperation();
            txt_sifre.UseSystemPasswordChar = true;
            //return kontrol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yetkili = yetkiliOperation.Find(txt_kadi.Text, txt_sifre.Text);

            if (yetkili != null)
            {
                //MainForm form = new MainForm(yetkili);
                //form.Show();
                kontrol = true;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Kullanıcı Bulunamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                kontrol = false;
                Application.Exit();
            }
        }

    }
}
