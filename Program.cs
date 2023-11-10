using System;

namespace kurucu_metotlar;

class Program
{
    static void Main(string[] args)
    {
        /*  Söz Dizimi
            class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
                [Erişim Belirleyici] [Veri Tipi] MetotAdi(Parametre Listesi)
                {
                    Metot Komutları
                }
            }
        */

        /*
            Erişim Belirleyiciler
            * Public
            * Private
            * Internal
            * Protected
        */

        Console.WriteLine("************Calışan 1************");
        Calisan calisan1 = new Calisan("Ayşe", "Kara", 234225634, "İnsan Kaynakları");
        calisan1.CalisanBilgileri();

        Console.WriteLine("************Çalışan 2************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Derya";
        calisan2.Soyad = "Yılmaz";
        calisan2.No = 256646984;
        calisan2.Departman = "Satın Alma";
        calisan2.CalisanBilgileri();
        
        Console.WriteLine("************Çalışan 3************");
        Calisan calisan3 = new Calisan("Vahdet", "Savcı");
        calisan3.CalisanBilgileri();
    }
}

class Calisan
{
    internal string Ad;
    internal string Soyad;
    internal int No;
    internal string Departman;

    internal Calisan(){}
    internal Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    internal Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    internal void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
}
