using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Console.WriteLine("Yarışmaya Hoşgeldiniz");
            Console.Title = "Bilgi yarışması";
            string ad, soyad;
            Console.WriteLine("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hazır olduğunuzda enter tuşuna basın!");
            Console.WriteLine("Her yanıttan sonra lütfen enter tuşuna basın!");
            Console.WriteLine("Soruları lütfen büyük harfle cevaplayın!");
            Console.ReadLine();

            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            string s1;
            Console.WriteLine("Soru 1) Cumhuriyet kaç yılında ilan edilmiştir?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine(" A-1920 \n B-1923 \n C-1930 \n D-1960 \n Cevabınızı giriniz: ");
            c1=Console.ReadLine();

            if (c1 == "B")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler bir sonraki soru için entere basın!");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Yanlış cevapladınız!");
                Console.ReadLine();
            }
           
            string s2;
            Console.WriteLine("Soru 2) Türkiyenin başkenti neresidir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine(" A-Ankara\n B-İstanbul\n C-İzmir\n D-Adana\n Cevabınızı giriniz: ");
            c2 = Console.ReadLine();
            if (c2 == "A")
            {
                para = para + 1000;
                dogru += 1;
                Console.WriteLine("Tebrikler bir sonraki soru için entere basın!");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Yanlış cevapladınız!");
                Console.ReadLine();
            }
            string s3;
            Console.WriteLine("Soru 3) İstiklal marşı yazarı kimdir?");
            s3 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine(" A-Mehmet Akif Ersoy \n B-Zülfü Livaneli \n C-kemal tahir \n D-Ömer Seyfettin \n Cevabınızı giriniz: ");
            c3 = Console.ReadLine();

            if (c3 == "A")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler bir sonraki soru için entere basın!");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Yanlış cevapladınız!");
                
                Console.ReadLine();
            }
            
            string s4;
            Console.WriteLine("Soru 4) Türkiyede toplam kaç coğrafik bölge var?");
            s4 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.WriteLine(" A-2 \n B-4 \n C-7 \n D-10 \n Cevabınızı giriniz: ");
            c4 = Console.ReadLine();

            if (c4 == "C")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler bir sonraki soru için entere basın!");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Yanlış cevapladınız!");
                Console.ReadLine();
            }
           
            string s5;
            Console.WriteLine("Soru 5) İstanbulun araç plakası kaç numaradır?");
            s5 = Convert.ToString(Console.ReadLine());
            string c5;
            Console.WriteLine(" A-1 \n B-22 \n C-57 \n D-34 \n Cevabınızı giriniz: ");
            c5 = Console.ReadLine();

            if (c5 == "D")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler bir sonraki soru için entere basın!");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis+1;
                Console.WriteLine("Yanlış cevapladınız!");
                Console.ReadLine();
            }
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru sayınız: " + dogru);
            Console.WriteLine("Yanlış sayınız: " + yanlis);
            Console.WriteLine("Kazandığınız para: " + para);
            
            Console.Read();

        }
    }
}
