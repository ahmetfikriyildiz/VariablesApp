using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double tc ;
            Console.WriteLine("Lütfen asagıdaki bilgileri giriniz : ");
            Console.Write("T.C. Kimlik Numarasi : ");
            tc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adi : ");
            string ad = Console.ReadLine();
            Console.Write("Soyadi : ");
            string soyadi = Console.ReadLine();
            Console.Write("Telefon Numarasi : ");
            double tel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yaş : ");
            int yaş =Convert.ToInt32(Console.ReadLine());
            Console.Write("İlk Ürünün Fiyati : ");
            double ilk = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Ürünün Fiyati : ");
            double ikinci = Convert.ToDouble(Console.ReadLine());
            double toplam = ikinci + ilk;
            double pp = toplam /10;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{tc} Tc Numarali {ad} isimli kisi için kayit olusturulmustur.");
            Console.WriteLine($"{tel} telefon numarasina bildirim mesaji gönderilmiştir.");
            Console.WriteLine($"{toplam} toplam harcama karsiligi kazanilan %10 patika puan miktari -> {pp} TL'dir.");
            Console.ReadLine();
        }
    }
}
