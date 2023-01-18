
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Enter the month you were born");
            string month = (Console.ReadLine());

            Console.WriteLine("entered month: " + month);

            Console.WriteLine("write down the day you were born");
            int day = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("entered day:" + day);
          

            if (month.Equals("January"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Aquarius");
                }
                else
                {
                    Console.WriteLine("goat");
                }



            }
            if (month.Equals("February"))
            {
                if (day> 20)
                {
                    Console.WriteLine("fish");
                }
                else
                {
                    Console.WriteLine("Aquarius");
                }



            }
            if (month.Equals("March"))
            {
                if (day > 21)
                {
                    Console.WriteLine("ram");
                }
                else
                {
                    Console.WriteLine("fish");
                }



            }
            if (month.Equals("April"))
            {
                if (day > 21)
                {
                    Console.WriteLine("Bull");
                }
                else
                {
                    Console.WriteLine("ram");
                }



            }
            if (month.Equals("May"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Twins");
                }
                else
                {
                    Console.WriteLine("Bull");
                }



            }
            if (month.Equals("June"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Crab");
                }
                else
                {
                    Console.WriteLine("Twins");
                }



            }
            if (month.Equals("Jully"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Lion");
                }
                else
                {
                    Console.WriteLine("Crab");
                }



            }
            if (month.Equals("August"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Virgo");
                }
                else
                {
                    Console.WriteLine("Lion");
                }



            }
            if (month.Equals("September"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Scales");
                }
                else
                {
                    Console.WriteLine("Virgo");
                }



            }
            if (month.Equals("October"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Scorpion");
                }
                else
                {
                    Console.WriteLine("Scales");
                }



            }
            if (month.Equals("November"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Arrow");
                }
                else
                {
                    Console.WriteLine("Scorpion");
                }



            }
            if (month.Equals("December"))
            {
                if (day > 22)
                {
                    Console.WriteLine("Goat");
                }
                else
                {
                    Console.WriteLine("Arrow");
                }



            }






            //if ((month== December && day >= 22) || (month = 1 && day = 21))
            //{
            //    Console.WriteLine("Capricorn");

            //}
            //else if ((month == 2 && day == 20) || (month == 3 && day == 20))
            //{
            //    Console.WriteLine("Pisces");

            //}

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


        }
    }
}
