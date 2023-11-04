using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKapsulleme
{// İçeride saklamış olduğumuz  private field ın önüne  koymuş olduğumuz bir property sayesinde
 // get ve set bloklarını kullanarak değer ataması da yapabiliriz değer de çekebiliriz.
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.isim = "Doğukan";
            //M1.soyisim = "ÖZEL";
            /*
             * Class içerisindeki bir alanın değer alma ve değer okuma kısımlarna müdehale ettiğimiz noktalara kapsülleme diyoruz.
             * Field değer ataması yapılamasın ama değer okuyA bilsin. (OK)
             * Field değer ataması yapılsın ama değer okunamasın. (OK)
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun. (OK)
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim
             * ,belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin. 
             */

            //Class
            //Field
            //Property
            //Get & set


            //M1.emailAdres = "dogukanozel692@gmail.com"; (Field dı bu nedenle hata veriyor.)
            // Genel olarak kapsülleme konusuna giriş yaptık.
            //(örnek için yorum satırı yaptım) M1.EmailAdres = "dogukanozel692@gmail.com";
            // (Örnek için yorum satırı yaptım)Console.WriteLine(M1.EmailAdres);

            // 1. Field değer ataması yapılamasın ama değer okunabilsin.
            Console.WriteLine("Musteri Id DEğeri = " + M1.ID.ToString());
            //M1.ID = 10; //Set edilemez Değer ataması yapılamaz.

            // 2. Field değer ataması yapılsın ama değer okunamasın.
            
            M1.TCKimlikNumarasi = "12345678912";
            //string TC = M1.TCKimlikNumarasi; //Get edilemez Değer okunamaz.
            // 3. Aynısı ama İlk 3 karakteri göster -  Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
            string TC = M1.TCKimlikNumarasi;

            //4. Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim
            //,belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin. 

            //İsim ve Soyisim
            //isim ve soyisim[soyisim] = set
            //Email Adresi.....
            //email get Dogukan.ozel@gmail.com
            //set : private

            M1.isim = "Dogukan";
            M1.Soyisim = "OZEL";
            Console.WriteLine(M1.EmailAdres);

        }
    }
}
