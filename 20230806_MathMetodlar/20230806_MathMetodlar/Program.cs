using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_MathMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# programlama dilinde bazı matematiksel işlemleri yapmak için Math sınıfının içerisinde tanımlanmış olan bazı metodlar vardır.
            // Bu metodlardan en sık kullanılanlarını örnekler ile işleyelim.
            // Math metodlarının kullanımı için Math yazıp .(nokta) karakterinden sonra ismi çağırılır.


            // Abs() Metodu
            // Kendisine verilen herhangi bir sayının mutlak değerini verir.
            Console.WriteLine(Math.Abs(-50));

            Console.WriteLine("--------------");
            // Ceiling() metodu
            // Kendisine verilen ondalıklı sayıyı bir üst sayıya yuvarlar.
            // ondalık değerini 9.1 yazsanız bile 10 olarak alırsınız.
            Console.WriteLine(Math.Ceiling(9.1));


            Console.WriteLine("--------------");
            // Floor() metodu
            // Kendisine verile ondalıklı sayıyı sayının kendisine yuvarlar.
            // Ondalık değerini 9.999 yazsanız bile sonucu 9 olarak alırsınız.
            Console.WriteLine(Math.Floor(9.999999));


            Console.WriteLine("--------------");
            // Round() metodu
            // içersine verilen ondalıklı sayının hassasiyetini ayarlar.
            // içerisine verilen ilk değer sayının kendisi, ikinci değer ise virgülden sonra kaç basamak yazacağını belirtir.
            Console.WriteLine(Math.Round(56.7350500, 2));


            Console.WriteLine("--------------");
            // Max() metodu
            // içerisine iki adet sayı talep eder.
            // kendi içerisnde bu iki sayıyı karşılaştırır.
            // Hangi sayı büyük ise o sayıyı geri döndürür.
            Console.WriteLine(Math.Max(45, 85));


            Console.WriteLine("--------------");
            // Min() metodu
            // içerisine iki adet sayı talep eder.
            // kendi içerisinde bu iki sayıyı karşılaştırır.
            // Hangi sayı küçük ise o sayıyı geri döndürür.
            Console.WriteLine(Math.Min(34, 91));


            Console.WriteLine("--------------");
            // Pow() metodu
            // üssü alma işlemi için kullanılır.
            // içerisine iki adet sayı alır.
            // birinci sayının ikinci sayıya üssünü hesaplar.,
            Console.WriteLine(Math.Pow(2, 6));


            Console.WriteLine("--------------");
            // Sqrt() Metodu
            // içerisine aldığı sayının karekökünü hesaplar.
            Console.WriteLine(Math.Sqrt(37));


            Console.WriteLine("--------------");
            // PI
            // Math sınıfı içerisinde sabit bir değişkendir.
            // PI sayısını verir.
            Console.WriteLine(Math.PI);


            Console.WriteLine("--------------");
            // E
            // Math sınıfı içerisinde sabit bir değişkendir.
            // E sayısını verir.
            Console.WriteLine(Math.E);






            Console.ReadKey();
        }
    }
}
