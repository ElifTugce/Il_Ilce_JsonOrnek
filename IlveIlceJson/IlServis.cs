using ILveILCEJSON_ENTITIYMODELS;
using ILveILCEJSON_ENTITIYMODELS.Classlar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IlveIlceJson
{
    public class IlServis
    {
        private string JSonString = string.Empty; // field ----Property değildir----
        public IlServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient Istemci = new WebClient())
            {
                byte[] data = Istemci.DownloadData(@"C:\Users\103SABAH_ELİFTUGCE\Source\Repos\Il_Ilce_JsonOrnek\belediyeler.json");


                //Json dosyasındaki ş ç ü gibi harfler çevrilirken bozulma yaşanabilmektedir.
                //Biz Encoding UTF8 kullanırsak bütün dillere göre çözümleme sunar.
                JSonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<IL> IlleriGetir()
        {
            List<IL> ILListesi = new List<IL>();

            // dta ILJson classından alınacak. Oradaki propertyler küçük harfli. Çünkü json dosyasında küçük harfle yazmışlar.

            var JsonData = JsonConvert.DeserializeObject<List<ILJson>>(JSonString);

            //Alınan data bizim sistemimizdeki IL classına aktarılacak

            foreach (var item in JsonData)
            {
                ILListesi.Add(
                    new IL()
                    {
                        ILAdi = item.il,
                        PlakaKodu = Convert.ToByte(item.plaka),
                        Ilceleri = item.ilceleri
                    });
            }
            return ILListesi;
        }
    }
}
