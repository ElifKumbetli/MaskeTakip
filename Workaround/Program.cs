namespace Workaround
{
     class Program
     {
        static void Main(string[] args)
        {

            SelamVer(isim : "Engin");
            SelamVer(isim : "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();


            int sonuc = Topla(6,58);



            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2= 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            return sonuc;
        }
    }
}

 