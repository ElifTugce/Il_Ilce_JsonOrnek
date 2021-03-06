using ILveILCEJSON_ENTITIYMODELS.Classlar;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IlveIlceJson
{
    public class ILILceServis
    {
        IlServis ilServisi = new IlServis();
        private string JsonString = string.Empty;
        public ILILceServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_ELİFTUGCE\Source\Repos\Il_Ilce_JsonOrnek\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<ILCE> BilgileriGetir()
        {
            List<ILCE> liste = new List<ILCE>();
            JObject j = JObject.Parse(JsonString);
            List<string> illerim = ilServisi.IlleriGetir().Select(x => x.ILAdi).ToList();
            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (var item in illerim)
            {
                //her bir il için bilgleri belediyelerfull.json'dan çekeceğiz.

                var data = j.SelectToken(item).SelectToken("il");
                ILCE detaylıBilgi = new ILCE();
                detaylıBilgi.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());
                detaylıBilgi.Tel = data["belediye-tel"].ToObject<string>();
                detaylıBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detaylıBilgi.Ismi = data ["belediye-ismi"].ToObject<string>();

                //BAzı belediyelerin mail adresi olmadığından null gelmesin diye kontrol yapıyoruz.
                detaylıBilgi.Mail = data ["belediye-mail"]==null?
                    ""
                    :data["belediye-mail"].ToObject<string>();



                detaylıBilgi.Web = data["belediye-web"] ==null? 
                    "" 
                    :data["belediye-web"].ToObject<string>();



                detaylıBilgi.Alankodu = data["alankodu"] == null ?
                    ""
                    : data["alankodu"].ToObject<string>();


                detaylıBilgi.Bolge = data["nufus"].ToObject<string>();
                detaylıBilgi.Bilgi = data["bolge"].ToObject<string>();
                detaylıBilgi.Nufus = data["bilgi"].ToString();
                liste.Add(detaylıBilgi);
                
            }


        return liste;
        }
        public List<ILCE> ILAdinaGoreILceleriGetir(string ilAdi)
        {
            List<ILCE> liste = new List<ILCE>();
            JObject j = JObject.Parse(JsonString);

            List<string> ilcelerListem = ilServisi.IlleriGetir().Single(x => x.ILAdi == ilAdi).Ilceleri;

            // çevirici kullanmamız lazım çünkü ağrı ---> agri diye yazılır...
            // ismi json un içindeki gibi değiştirdik.
            ilAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ilAdi.ToLower());
            
            // Single : Verilen koşula göre istenilen elementi liste halinde getirir.

            // ilçeler de json içinde ingilizce karakterli halde yazıyor.
            // Bu neden onu da çevirmemiz gerekti.
            ilcelerListem = ilcelerListem.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();
            foreach (var item in ilcelerListem)
            {
                var data = j.SelectToken(ilAdi.ToLower()).SelectToken(item);

                

                if (data != null) // bazı illerin ilçelerinde null gelme durumuna yakalanmayalım.
                {
                    ILCE bilgim = new ILCE();
                    bilgim.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgim.Tel = data["belediye-tel"] ==null?"":data["belediye-tel"].ToObject<string>();
                    bilgim.Faks = data["belediye-faks"] == null ? "" : data["belediye-faks"].ToObject<string>();
                    bilgim.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgim.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgim.Nufus = data["nufus"] == null ? "" : data["nufus"].ToObject<string>();
                    bilgim.Bilgi = data["bilgi"] == null ? "" : data["bilgi"].ToObject<string>();
                    liste.Add(bilgim);
                }
            }

            return liste;
        }
    }
}
