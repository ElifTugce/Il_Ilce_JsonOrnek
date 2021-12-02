using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IlveIlceJson
{
    public static class DilIslemleri
    {
        public static string
            TurkceKarakterleriIngilizceyeCevir(string deger)
        {
            return deger
                .Replace("ş", "s")
                .Replace("ç", "c")
                .Replace("ğ", "g")
                .Replace("ü", "u")
                .Replace("ö", "o")
                .Replace("i", "i")
                .Replace("İ", "i");
        }

    }
}