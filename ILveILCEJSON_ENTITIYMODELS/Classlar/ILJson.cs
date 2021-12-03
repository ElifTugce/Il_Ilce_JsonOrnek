using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_ENTITIYMODELS.Classlar
{
    public class ILJson
    {

        //Json dosyasındaki key değerleriyle aynı olacak şekilde ayarlandı.
        //Normal küçük harfle başlamamalı...
        // Plaka değil plaka şeklinde yazmalıyız.
        public string il { get; set; }
        public string plaka { get; set; }
        public List<string> ilceleri { get; set; }
    }
}
