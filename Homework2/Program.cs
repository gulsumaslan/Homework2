
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Koç Burcu : 21 Mart – 20 Nisan
            //Boğa Burcu: 21 Nisan – 21 Mayıs
            //İkizler Burcu: 22 Mayıs – 22 Haziran
            //Yengeç Burcu: 23 Haziran – 22 Temmuz
            //Aslan Burcu: 23 Temmuz – 22 Ağustos
            //Başak Burcu: 23 Ağustos – 22 Eylül
            //Terazi Burcu: 23 Eylül – 22 Ekim
            //Akrep Burcu: 23 Ekim – 21 Kasım
            //Yay Burcu: 22 Kasım – 21 Aralık
            //Oğlak Burcu: 22 Aralık – 21 Ocak
            //Kova Burcu: 22 Ocak – 19 Şubat
            //Balık Burcu: 20 Şubat – 20 Mart

            //int ay = Convert.ToInt32(Console.ReadLine());
            //int gun = Convert.ToInt32(Console.ReadLine());
            //var ay = 1;
            //var gun = 20;


            Console.WriteLine("doğduğunuz ayı giriniz");
            string ay = (Console.ReadLine());

            Console.WriteLine("girilen ay: " + ay);

            Console.WriteLine("doğduğunuz günü yazınız");
            int gun = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("girilen gün:" + gun);
            //string burc = "";



            //Console.WriteLine(gun + " " + ay + " " + " gününde doğduysanız burcunuz:"+burc);

            if (ay.Equals("Ocak"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("kova");
                }
                else
                {
                    Console.WriteLine("oğlak");
                }



            }
            if (ay.Equals("Şubat"))
            {
                if (gun > 20)
                {
                    Console.WriteLine("Balık");
                }
                else
                {
                    Console.WriteLine("Kova");
                }



            }
            if (ay.Equals("Mart"))
            {
                if (gun > 21)
                {
                    Console.WriteLine("koç");
                }
                else
                {
                    Console.WriteLine("Balık");
                }



            }
            if (ay.Equals("Nisan"))
            {
                if (gun > 21)
                {
                    Console.WriteLine("Boğa");
                }
                else
                {
                    Console.WriteLine("koç");
                }



            }
            if (ay.Equals("Mayıs"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("İkizler");
                }
                else
                {
                    Console.WriteLine("Boğa");
                }



            }
            if (ay.Equals("Haziran"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Yengeç");
                }
                else
                {
                    Console.WriteLine("İkizler");
                }



            }
            if (ay.Equals("Temmuz"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Aslan");
                }
                else
                {
                    Console.WriteLine("Yengeç");
                }



            }
            if (ay.Equals("Ağustos"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Başak");
                }
                else
                {
                    Console.WriteLine("Aslan");
                }



            }
            if (ay.Equals("Eylül"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Terazi");
                }
                else
                {
                    Console.WriteLine("Başak");
                }



            }
            if (ay.Equals("Ekim"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Akrep");
                }
                else
                {
                    Console.WriteLine("terazi");
                }



            }
            if (ay.Equals("Kasım"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Yay");
                }
                else
                {
                    Console.WriteLine("Akrep");
                }



            }
            if (ay.Equals("Aralık"))
            {
                if (gun > 22)
                {
                    Console.WriteLine("Oğlak");
                }
                else
                {
                    Console.WriteLine("Yay");
                }



            }






            //if ((ay== Aralık && gun >= 22) || (ay = 1 && gun = 21))
            //{
            //    Console.WriteLine("Oğlak Burcu");

            //}
            //else if ((ay == 2 && gun == 20) || (ay == 3 && gun == 20))
            //{
            //    Console.WriteLine("Balık Burcu");

            //}


        }
    }
}
