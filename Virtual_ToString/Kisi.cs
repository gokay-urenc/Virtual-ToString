using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ToString
{
    class Kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }

        public override string ToString()
        {
            // return base.ToString(); // Base, bu sınıf için object sınıfıdır.
            return ad + " " + soyad + " " + yas;
        }
    }
}
// ListBox ve ComboBox'a eklenen elemanlar çalışma zamanında kullanıcının görebileceği veriyi      string'e çevirir.

// ToString() override edilebilir bir methoddur. Gövdesine müdahele edilerek string'e              çevrildiğinde verinin nasıl gösterileceği belirlenebilir.