using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_ENTITIYMODELS.Classlar
{
    public class IL
    {

        // C# Property kurallarına göre IL isimli classı oluşturduk.
        // JSONIL class deserialize olunca oradaki dataları IL Classından türeteceğiz ve nesneye aktaracağız.

        public string ILAdi { get; set; }
        public byte PlakaKodu { get; set; }
        public List<String> Ilceleri { get; set; }
    }
}
