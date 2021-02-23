using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            Console.WriteLine("-------------------------");

            //array-dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı",
                "programlamaya başlangıç için temel kurs","Java","python","C#"};
            

            for (int i = 0; i < kurslar.Length; i++)
            { 
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach-dizileri tek tek dolaşmaya yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
