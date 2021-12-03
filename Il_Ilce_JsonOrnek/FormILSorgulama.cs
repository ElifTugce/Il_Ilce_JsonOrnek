using IlveIlceJson;
using ILveILCEJSON_ENTITIYMODELS.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il_Ilce_JsonOrnek
{
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }


        //Global alan
        IlServis ilServisim = new IlServis();
        ILILceServis ILILceServisim = new ILILceServis();

        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //Form yüklenirken burası çalışacak
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "ILAdi";
            comboBoxILSecimi.ValueMember = "PlakaKodu";


            //ListView'in içini dolduracağız:
            List<ILCE>SehireAitBilgilerListesi = ILILceServisim.BilgileriGetir();
            ILILceServisim.BilgileriGetir();
            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text = item.Ismi,
                    Tag = item


                };
                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);

                listView1.Items.Add(deger);
            }

            //GroupBox başlangıçta gizli olmalıdır.
            groupBoxIL.Enabled = false;
            groupBoxIL.Visible = false;

            //Detay göster şeklinde sağ tık menüsü gerekiyor.
            // Bu kontrol toolboxta var istersek designer ekranında toolboxtan çekip form üzerine yerleştirebiliriz.
            // Ama biz bunu designerdan yapmayıp code ekranından yapacağız.
            

        }
        

    private void btnSec_Click(object sender, EventArgs e)
        {
            //comboboxta hangi ili seçtiyse onun bilgilerini listview de görelim.


            // 1.YÖNTEM
            //IL secilenIL = (IL)comboBoxILSecimi.SelectedItem;

            // 2.YÖNTEM
            IL secilenIL = comboBoxILSecimi.SelectedItem as IL;

            // Linq ile şart yazıyorum.
            // where şartını kullandık. Verilen koşula göre bilgileri getirir. Liste olarak döndürür.
            // FirstorDefault ise where den dönen liste elemanlarından sadece birini almamızı sağlar.
            ILCE secilenILBilgisi =
            ILILceServisim.BilgileriGetir()
            .Where(x => x.Plaka == secilenIL.PlakaKodu)
            .FirstOrDefault();

            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();
            deger.Text = secilenILBilgisi.Ismi;
            deger.Tag = secilenILBilgisi;
            deger.SubItems.Add(secilenILBilgisi.Tel);
            deger.SubItems.Add(secilenILBilgisi.Faks);
            deger.SubItems.Add(secilenILBilgisi.Mail);
            deger.SubItems.Add(secilenILBilgisi.Web);
            listView1.Items.Add(deger);


        }

        private void detayGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxIL.Enabled = true;
            groupBoxIL.Visible = true;

            ILCE secilenIL = (ILCE)
                listView1.FocusedItem.Tag;
            richTextBoxIL.Text = secilenIL.Bilgi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
