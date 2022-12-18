using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                int nSayisi;
                Console.WriteLine("n sayisini giriniz: ");
                nSayisi = Convert.ToInt32(Console.ReadLine());
                float gecici = 0;
                float x = 0;
                for (float i = 1; i < nSayisi; i++)
                {
                    gecici = i / (i + 1);
                    x = gecici + x;
                }
                Console.WriteLine("İşlemin sonucu= " + x);
                Console.ReadLine();
            }
        }
    }
}
