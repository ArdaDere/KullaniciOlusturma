using System;
using Kullanıcı_Oluşturma;
using Kullanıcı_Oluşturma;

class Program
{
    static void Main()
    {
        User kullanici = new User();
        kullanici.SetAdSoyad("Arda Dere");
        kullanici.SetYas(19);
        kullanici.Email = "ardadere114@gmail.com";

        kullanici.BilgileriGoster();
    }
}
