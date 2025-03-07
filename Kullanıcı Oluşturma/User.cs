using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcı_Oluşturma
{
    class User
    {
        private string adSoyad;
        private int yas;
        public string Email { get; set; }

        
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string deger)
        {
            adSoyad = deger;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int deger)
        {
            if (deger > 0) 
                yas = deger;
            else
                Console.WriteLine("Geçerli bir yaş giriniz!");
        }

        
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"E-Posta: {Email}");
        }
    }
}