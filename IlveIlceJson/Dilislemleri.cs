using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlveIlceJson
{
    public static class DilIslemleri
    {
        public static string TurkceKarakterleriIngilizceyeCevir(string deger)

        {
            return deger
                        .Replace("ş", "s")
                        .Replace("ç", "c")
                        .Replace("ğ", "g")
                        .Replace("ü", "u")
                        .Replace("ö", "o")
                        .Replace("ı", "i")
                        .Replace("İ", "I");


        }
    }
}
