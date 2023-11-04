using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKapsulleme
{ // İçeride saklamış olduğumuz  private field ın önüne  koymuş olduğumuz bir property sayesinde
  // get ve set bloklarını kullanarak değer ataması da yapabiliriz değer de çekebiliriz.
    internal class Musteri
    {
        public Musteri()
        {
            this.id = IDUret();
        }
        //Class => Field
        int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            private set 
            {
                this.id = value; 
            }
        }

        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get { return this._soyisim; }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@gmail.com",isim,_soyisim);
            }
        }


        //Class => Property
        private string emailAdres;
        public string EmailAdres
        {
            // get; //Database veya farklı bir veri kaynagı... Class çağıran programcıya datayı gösterdiğimiz kısım..
            //set; //dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım..

            private set 
            {
                this.emailAdres=value;
            }
            get
            {
                return this.emailAdres;
            }
        }
        //Ara Ödev :

        private string _tckimliknumarasi;
        public string TCKimlikNumarasi
        {
            get { return _tckimliknumarasi.Substring(0, 3);  }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            //Sayısal Değer demektir...
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TC Kimlik Numarası içindeki değerler sayısal olmalıdır...");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 hane olmalıdır...");
                }
            }
        }

        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000,90000);
        }
    }
}
