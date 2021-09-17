using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSorular
{
    class Program
    {

        public static int ardisik4(int a)
        {
            if ((a - 6) % 4 == 0)
            {
                return ((a - 6) / 4) + 3;
            }
            else
            {
                return -1;
            }
        }

        public static int X2eksi1(int a)
        {
            return (a * 2) - 1;
        }

        static void Main(string[] args)
        {

            //SORU 1
            /*
            Console.WriteLine("Lütfen bir kelime giriniz");
            string kelime = Console.ReadLine();
            char[] harfler = kelime.ToCharArray();
            int i, j = 0, n = 0;
            Console.WriteLine("Lütfen bir harf giriniz:\na) alt alta\nb)tersten alt alta\nc) tersten yan yana\nd) merdiven şeklinde\ne) tersten merdiven şeklinde\nyazdırır.");
            char girilen = Console.ReadLine()[0];
            switch (girilen)
            {
                case 'a':
                    Console.WriteLine("\na) alt alta\n");
                    for (i = 0; i < harfler.Length; i++)
                    {
                        Console.WriteLine(harfler[i]);
                    }
                    break;
                case 'b':
                    Console.WriteLine("\nb) tersten alt alta\n");
                    for (i = harfler.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(harfler[i]);
                    }
                    break;
                case 'c':
                    Console.WriteLine("\nc) tersten yan yana\n");
                    for (i = harfler.Length - 1; i >= 0; i--)
                    {
                        Console.Write(harfler[i]);
                    }
                    break;
                case 'd':
                    Console.WriteLine("\nd) merdiven şeklinde\n");
                    n = 0;
                    for (i = 0; i < harfler.Length; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("  ");
                        }
                        Console.WriteLine(harfler[i]);
                        n++;
                    }
                    break;
                case 'e':
                    Console.WriteLine("\ne) tersten merdiven şeklinde\n");
                    n = 0;
                    for (i = harfler.Length - 1; i >= 0; i--)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("  ");
                        }
                        Console.WriteLine(harfler[i]);
                        n++;
                    }
                    break;
                default:
                    Console.WriteLine("Lütfen isminizi ve soyisminizi giriniz");
                    string adsoyad = Console.ReadLine();
                    char[] harfler2 = adsoyad.ToCharArray();
                    Console.WriteLine(harfler2[1]);
                    break;
            }
            */

            //SORU 2

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            string girilen = Console.ReadLine();
            char[] sayilar = girilen.ToCharArray();
            int i, j;
            for (i = 0; i < sayilar.Length; i++)
            {
                for (j = i + 1; j < sayilar.Length; j++)
                {
                    if (sayilar[i].Equals(sayilar[j]))
                    {
                        Console.WriteLine(sayilar[i] + " sayısı tekrar ediyor. Basamak sayıları: " + (i + 1) + " ve " + (j + 1));
                    }
                }
            }
            */

            //SORU 3

            /*
            int a;
            for (a = 100; a < 1000; a++)
            {
                int sayi = a, yuzler, onlar, birler, carpim;
                yuzler = sayi / 100;
                sayi = sayi % 100;
                onlar = sayi / 10;
                birler = sayi % 10;
                carpim = yuzler * onlar * birler;
                if (carpim != 0)
                {
                    if (a % carpim == 0)
                    {
                        Console.WriteLine(a + " basamaklari carpimina bolunebilir.");
                        Console.WriteLine(a + " nın 2 katının 1 eksiği : " + X2eksi1(a));
                        Console.WriteLine();
                    }
                }
            }
            */

            //SORU 4

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi, i = 0, bassayi = 1;
            while (temp / 10 > 0)
            {
                bassayi++;
                temp = temp / 10;
            }
            temp = sayi;
            int[] basamaklar = new int[bassayi];
            while (temp / 10 > 0)
            {
                basamaklar[i] = temp % 10;
                temp = temp / 10;
                i++;
            }
            basamaklar[i] = temp;
            int toplam = 0;
            for (i = 0; i < basamaklar.Length; i++)
            {
                switch (i % 6)
                {
                    case 0:
                        toplam += basamaklar[i];
                        break;
                    case 1:
                        toplam += basamaklar[i] * 3;
                        break;
                    case 2:
                        toplam += basamaklar[i] * 2;
                        break;
                    case 3:
                        toplam += basamaklar[i] * -1;
                        break;
                    case 4:
                        toplam += basamaklar[i] * -3;
                        break;
                    case 5:
                        toplam += basamaklar[i] * -2;
                        break;
                }
            }
            if (toplam % 7 == 0)
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 7ye tam bolunebilir.");
            }
            else
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 7ye tam bolunemez.");
            }
            */

            //SORU 5

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi, i = 0, bassayi = 1;
            while (temp / 10 > 0)
            {
                bassayi++;
                temp = temp / 10;
            }
            temp = sayi;
            int[] basamaklar = new int[bassayi];
            while (temp / 10 > 0)
            {
                basamaklar[i] = temp % 10;
                temp = temp / 10;
                i++;
            }
            basamaklar[i] = temp;
            int artilar = 0, eksiler = 0;
            for (i = 0; i < basamaklar.Length; i++)
            {
                if (i % 2 == 0)
                {
                    artilar += basamaklar[i];
                }
                else
                {
                    eksiler += basamaklar[i];
                }

            }
            int sonuc = 0;
            if (artilar > eksiler)
            {
                sonuc = artilar - eksiler;
            }
            else
            {
                sonuc = eksiler - artilar;
            }
            if (sonuc < 0)
                sonuc += 11;
            if (sonuc % 11 == 0)
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 11e tam bolunur.");
            }
            else
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 11e tam bolunemez.");
            }
            */

            //SORU 6

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a = sayi, cikarilacak = 0;
            while (a >= 7)
            {
                cikarilacak = ((a % 10) * 2);
                a = a / 10;
                a = a - cikarilacak;
            }
            while (a < 0)
                a += 7;
            if (a == 0)
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 7ye tam bolunur.");
            }
            else
            {
                Console.WriteLine("Girilen " + sayi + " sayisi 7ye tam bolunemez.");
            }
            */

            //SORU 7

            /*
            int i, sayi, toplam;
            Console.WriteLine("Rakamlarının kareleri toplamına kalansız bölünebilen sayılar: ");
            for (i = 1235; i < 9876; i++)
            {
                toplam = 0;
                sayi = i;
                while (sayi > 0)
                {
                    toplam += ((sayi % 10) * (sayi % 10));
                    sayi = sayi / 10;
                }
                if (i % toplam == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // SORU8

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a = sayi, bassayi = 1;
            while (a / 10 > 0)
            {
                bassayi++;
                a = a / 10;
            }
            a = sayi;
            int i = 1, basamak, toplam = 0, carpim = 1;
            if (bassayi % 2 == 0)
            {
                while (a > 0)
                {
                    basamak = a % 10;
                    a = a / 10;
                    if (i % 2 == 0)
                    {
                        toplam += basamak;
                    }
                    else
                    {
                        carpim *= basamak;
                    }
                    i++;
                }
            }
            else
            {
                while (a > 0)
                {
                    basamak = a % 10;
                    a = a / 10;
                    if (i % 2 == 0)
                    {
                        carpim *= basamak;
                    }
                    else
                    {
                        toplam += basamak;
                    }
                    i++;
                }
            }
            Console.WriteLine("Sayinin tek siradaki basamaklardaki sayilarinin toplamı: " + toplam + "\nSayinin cift siradaki basamaklardaki sayilarinin carpimi: " + carpim);
            */

            //SORU 9

            /*
            string cumle, coktekrareden = "";
            string[] kelimeler;
            Console.Write("Cümleyi gir : ");
            cumle = Console.ReadLine();
            kelimeler = cumle.Split(' ');
            int i, j, counter, max = 0;
            for (i = 0; i < kelimeler.Length; i++)
            {
                counter = 0;
                for (j = i + 1; j < kelimeler.Length; j++)
                {
                    if (kelimeler[i] == kelimeler[j])
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    coktekrareden = kelimeler[i];
                }
            }
            Console.WriteLine("En çok tekrar eden kelime :" + coktekrareden);
            */

            //SORU 10

            /*
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi, i = 0, bassayi = 1;
            while (temp / 10 > 0)
            {
                bassayi++;
                temp = temp / 10;
            }
            temp = sayi;
            int[] basamaklar = new int[bassayi];
            while (temp / 10 > 0)
            {
                basamaklar[i] = temp % 10;
                temp = temp / 10;
                i++;
            }
            basamaklar[i] = temp;
            int counter = 1, j = 1, max = 0, min = 100, coktekrareden = 0, aztekrareden = 0;
            for (i = 0; i < basamaklar.Length; i++)
            {
                for (j = 0; j < basamaklar.Length; j++)
                {
                    if (basamaklar[i] == basamaklar[j])
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    coktekrareden = basamaklar[i];
                }
                else if (counter < min)
                {
                    min = counter;
                    aztekrareden = basamaklar[i];
                }
                counter = 1;

            }
            Console.WriteLine("En çok tekrar eden sayi :" + coktekrareden);
            Console.WriteLine("En az tekrar eden sayi :" + aztekrareden);
            */

            //SORU 11

            /*
            int a, sayi, tersi = 0, b;
            double kontrol;
            Console.WriteLine("Tersi ile çarpımı tam kare olan 3 basamaklı sayılar");
            for (a = 100; a < 1000; a++)
            {
                sayi = a;
                tersi = 0;
                while (sayi != 0)
                {
                    b = sayi % 10;
                    tersi = tersi * 10 + b;
                    sayi /= 10;

                }
                kontrol = Convert.ToInt32(Math.Sqrt(a * tersi));
                if (kontrol * kontrol == a * tersi)
                {
                    Console.WriteLine(a);
                }
            }
            */

            //SORU 12

            /*
            int a, b;
            string str1 = "", str2 = "";
            Console.Write("Basamak sayısını girin:");
            a = Convert.ToInt32(Console.ReadLine());
            int[] dizi1 = new int[a];
            for (int iter = 1; iter <= a; iter++) str1 += " ";
            if (a == 1) Console.Write("{0} 1", str1);
            if (a == 2) Console.Write("{0}1\n 1 1", str1);
            str1 = "";
            if (a > 2)
            {
                for (int iter = a; iter >= 0; iter--) str2 += " ";
                Console.WriteLine("{0}1", str2);
                str2 = "";
                for (int iter = a; iter >= 1; iter--) str2 += " ";
                Console.WriteLine("{0}1 1", str2);
                str2 = "";
                dizi1[0] = 1;
                dizi1[1] = 1;
                for (int i = 2; i < a; i++)
                {
                    int[] dizi2 = new int[i];
                    for (b = 1; b < i; b++)
                    {
                        dizi2[b] = dizi1[b] + dizi1[b - 1];
                        str1 = str1 + " " + dizi2[b].ToString();
                    }
                    for (b = 1; b < i; b++)
                    {
                        dizi1[b] = dizi2[b];
                    }
                    dizi1[i] = 1;
                    for (int iter = a; iter >= i; iter--) str2 += " ";
                    Console.WriteLine("{1}1{0} 1", str1, str2);
                    str2 = "";
                    str1 = "";
                }

            }
            */

            //SORU 13

            /*
            string cumle;
            string[] kelimeler;
            int i, j, a = 0;
            char[] harfler = new char[10];
            Console.WriteLine("Lutfen kaç isim gireceğinizi giriniz :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen kaç soyisim gireceğinizi giriniz :");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ad soyad giriniz : ");
            cumle = Console.ReadLine();
            kelimeler = cumle.Split(' ');
            string[] soyadlar = new string[n2];
            string[] adlar = new string[n1];
            for (i = 0; i < n1; i++)
            {
                adlar[i] = kelimeler[i];
            }
            for (j = i; j < (n1 + n2); j++)
            {
                soyadlar[a] = kelimeler[j];
                a++;
            }
            for (i = 0; i < n2; i++)
            {
                Console.Write(soyadlar[i] + " ");
            }
            for (i = 0; i < n1; i++)
            {
                Console.Write(adlar[i] + " ");
            }
            */

            //SORU 14

            /*
            Console.WriteLine("Ulke kodu-alan kodu- numara şeklinde telefon numarası giriniz (örn: 905054283524) : ");
            string input = Console.ReadLine();
            int ulkevealanhane = input.Length - 7;
            int ulkehane = ulkevealanhane - 3;
            string ulkekodu = input.Substring(0, ulkehane);
            string alankodu = input.Substring(ulkehane, 3);
            string numara = input.Substring(ulkevealanhane, 7);
            Console.WriteLine("Ulke kodu\tAlan kodu\tNumara");
            Console.WriteLine(ulkekodu + "\t\t" + alankodu + "\t\t" + numara);
            */

            //SORU 15.a

            /*
            long numPoints = 100000;
            Random rand = new Random();
            int numHits = 0;
            double pi;
            for (int i = 0; i < numPoints; i++)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                double dx = x - 0.5;
                double dy = y - 0.5;
                if (dx * dx + dy * dy < 0.25) numHits++;
            }
            double fraction = numHits / (double)numPoints;
            pi = 4.0 * fraction;
            Console.WriteLine("final pi " + pi);
            */

            //SORU 15.b

            /*
            Random rand = new Random();
            int[] sayilar = new int[6];
            int i;
            Console.WriteLine("Şanslı sayılar: ");
            for (i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rand.Next(90) + 1;
            }
            for (i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            */

            //SORU 16

            /*
            Random rand = new Random();
            int kullanıcı, comp1, comp2, tur = 1, kullanıcıpuan = 0, comppuan = 0;
            int fark;
            while (true)
            {
                if (tur % 2 != 0)
                {
                    Console.WriteLine("Tur: " + tur);
                    Console.WriteLine("Lutfen hamlenizi seçiniz (1-2-3): ");
                    Console.WriteLine("1)Taş\n2)Kağıt\n3)Makas");
                    kullanıcı = Convert.ToInt32(Console.ReadLine());
                    comp1 = rand.Next(3) + 1;
                    if (kullanıcı == 1)
                    {
                        if (comp1 == 2)
                        {
                            comppuan++;
                        }
                        else if (comp1 == 3)
                        {
                            kullanıcıpuan++;
                        }
                    }
                    else if (kullanıcı == 2)
                    {
                        if (comp1 == 1)
                        {
                            kullanıcıpuan++;
                        }
                        else if (comp1 == 3)
                        {
                            comppuan++;
                        }
                    }
                    else if (kullanıcı == 3)
                    {
                        if (comp1 == 1)
                        {
                            comppuan++;
                        }
                        else if (comp1 == 2)
                        {
                            kullanıcıpuan++;
                        }
                    }
                    Console.WriteLine("-Güncel skorlar-");
                    Console.WriteLine("Kullanıcı: " + kullanıcıpuan + "\nBilgisayar: " + comppuan);
                    tur++;
                }
                else
                {
                    Console.WriteLine("Tur: " + tur);
                    comp1 = rand.Next(3) + 1;
                    comp2 = rand.Next(3) + 1;
                    if (comp1 == 1 && comp2 == 3)
                    {
                        comppuan++;
                    }
                    else if (comp1 == 2 && comp2 == 1)
                    {
                        comppuan++;
                    }
                    else if (comp1 == 3 && comp2 == 2)
                    {
                        comppuan++;
                    }
                    Console.WriteLine("-Güncel skorlar-");
                    Console.WriteLine("Kullanıcı: " + kullanıcıpuan + "\nBilgisayar: " + comppuan);
                    tur++;
                }
                fark = Math.Abs(kullanıcıpuan - comppuan);
                if (fark == 2)
                {
                    if (kullanıcıpuan > comppuan)
                    {
                        Console.WriteLine("Oyun Bitti! Kazanan : Kullanıcı");
                    }
                    else
                    {
                        Console.WriteLine("Oyun Bitti! Kazanan : Bilgisayar");
                    }

                    break;
                }

            }
            */

            //SORU 17

            /*
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int hamle = 0;
            while (sayi != 2)
            {
                if (sayi % 2 == 0)
                {
                    sayi = sayi / 2;
                    hamle++;
                }
                else
                {
                    sayi = (sayi * 3) + 1;
                    hamle++;
                }
                Console.WriteLine(sayi);
            }
            Console.WriteLine(hamle + " Hamle sonunda 2 sayısı elde edildi.");
            */

            //SORU 18

            /*
            int sayi, buyuk;
            Console.WriteLine("Bir sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            buyuk = ardisik4(sayi);
            if (buyuk != -1)
            {
                Console.WriteLine(sayi + " sayisi ardisik 4 sayinin toplamidir ve bunlardan en buyugu: " + buyuk);
            }
            else
            {
                Console.WriteLine(sayi + " sayisi ardisik 4 sayinin toplami değildir.");
            }
            */
            Console.ReadKey();

        }

    }
}
