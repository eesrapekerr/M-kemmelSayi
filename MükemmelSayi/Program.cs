using System;

namespace MükemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir Sayı Giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for(int i=1; i<sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        toplam += i;
            //        Console.WriteLine(sayi + "Sayı Mükemmeldir");
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi + "Sayı Mükemmel değildir!");
            //    }
            //    Console.ReadLine();
            //}

            for (int i=1; i<1000; i++)
            {
                int toplam = 0;
                for (int k =1;k<i; k++ )
                {
                    if ( i%k==0)
                    {
                        toplam += k; 
                        
                    }

                    else
                    {
                        Console.WriteLine(k + " Sayı Mükemmel değildir.");
                    }
                }
                if (i == toplam)
                {
                    Console.WriteLine(i + " Sayı Mükemmeldir");
                }
            }
            Console.ReadLine();
        }
    }
}
