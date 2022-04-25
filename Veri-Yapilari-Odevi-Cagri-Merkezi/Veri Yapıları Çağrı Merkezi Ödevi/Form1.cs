using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Çağrı_Merkezi_Ödevi
{
    public partial class cagriMerkezi : Form
    {
        public cagriMerkezi()
        {
            InitializeComponent();
        }

        BireyselMusteriLinkedList BLL = new BireyselMusteriLinkedList();
        TicariMusteriLinkedList TLL = new TicariMusteriLinkedList();
        
        

       

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            int IDB;
            Musteri bMusteri = new Musteri();
            IDB = bMusteri.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            BLL.basaEkle(IDB);

            rtxtBMusteriSirasi.Text = BLL.yazdir();
            MessageBox.Show("Müşteri Türü: Bireysel"
                            + "\n" + BLL.SiradaArama(IDB));
        }

        private void btnTicariArama_Click_1(object sender, EventArgs e)
        {
            int IDT;
            Musteri tMusteri = new Musteri();
            IDT = tMusteri.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            TLL.basaEkle(IDT);

            rtxtTMusteriSirasi.Text = TLL.yazdir();
            MessageBox.Show("Müşteri Türü: Ticari"
                            + "\n" + TLL.SiradaArama(IDT));

            // Müşteri tipi ve sırasını messageBox ile göster
        }

      
        
        private void btnTSorgula_Click(object sender, EventArgs e)
        {
            int sira = TLL.Arama(TLL.head, Convert.ToInt32(txtTSiraSorgula.Text));
            MessageBox.Show("Ticari Müşteri Sıranız: " + sira);
        }

        private void btnBSorgula_Click(object sender, EventArgs e)
        {
            int sira = BLL.Arama(BLL.head, Convert.ToInt32(txtBSiraSorgula.Text));
            MessageBox.Show("Bireysel Müşteri Sıranız: " + sira);
        }
    }
}
