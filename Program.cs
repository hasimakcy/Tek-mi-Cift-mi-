using System;

namespace Tek_Mi_Cift_Mi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi % 2;
            // sayi'nın 2'ye bölümünden kalan 0 ve ya 1 olabilir. O yüzden modunu(%) alıyoruz.
            // Buda bize kalanı veriyor.

            if(sonuc == 0)            
            {
                //if = kalan sıfır ise, çift....
                Console.WriteLine("çift");
            }
            else
            {
                //else = diğer herşey için, tek....
                //else if kullanarak (sonuc == 1) diyip tektir diyebilirdik ama
                //0 ve ya 1'den başka bir sonuc cıkmayacagını bildiğimiz için bu
                //ram harcanması konusunda daha tasarrufludur.
                Console.WriteLine("tek");
            }

            Console.WriteLine("hoşçakal");
        }
    }
}
