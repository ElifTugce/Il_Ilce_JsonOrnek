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
        }
        

    private void btnSec_Click(object sender, EventArgs e)
        {
            //ILILceServis deneme = new ILILceServis();
            //deneme.BilgileriGetir();
        }
    }
}
