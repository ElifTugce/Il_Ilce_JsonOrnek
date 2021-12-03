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
    public partial class FormILeAitILceleriSorgulama : Form
    {
        public FormILeAitILceleriSorgulama()
        {
            InitializeComponent();
        }
        IlServis ilServisim = new IlServis();
        ILILceServis ilceServis = new ILILceServis();
        private void FormILeAitILceleriSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilServisim.IlleriGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";
        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yani içindeki değer değiştiğinde bu metot tetiklenecek/çalışacak...

            IL secilenIL = comboBoxILLER.SelectedItem as IL;

            // IlveIlceJson'dan bilgileri getirmesine ihtiyacımız var...
            // Öyle bir metot olmalı ki il ismini parametre olarak verince bana ilçeye dair detay bilgi versin.

            List<ILCE> sehreAitILceListem=
            ilceServis.ILAdinaGoreILceleriGetir(secilenIL.ILAdi);

            listView1.Items.Clear();

            foreach (var item in sehreAitILceListem)
            {
                // Her birini listviewitem olarak tutup

                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);

                //listView içine ekleyeceğim
                listView1.Items.Add(li);
            }
            

        }
        //Global Alan





    }
}
