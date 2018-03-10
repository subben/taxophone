using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxophone
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pytti;

            Console.WriteLine("Введите путь до папки с иконками");

            pytti = Console.ReadLine(); //var_name=int.Parse(Console.ReadLine()); -или так?

            // Console.WriteLine("Введите путь до папки с иконками");

            // string[] Ikon = new string[] { };
            

            DirectoryInfo taskDirectory = new DirectoryInfo(pytti);
            FileInfo[] Ikon = taskDirectory.GetFiles("*.png");
            

            // string[] Ikon = DirectoryInfo.GetFiles(pytti, "*.png"); // список всех png файлов в директории указанной в переменной pytti

                for (int i = 0; i < Ikon.Length; i++)
                {
                    Console.WriteLine(Ikon[i]);                                             
                
                }

            int temp;
            for (int i = 0; i < Ikon.Length - 1; i++)
            {
                for (int j = i + 1; j < Ikon.Length; j++)
                {
                    if (Ikon[i] > Ikon[j])
                    {
                        temp = Ikon[i];
                        Ikon[i] = Ikon[j]; // просто печаль
                        Ikon[j] = temp;
                    }
                }
            }

            //Console.ReadKey(); вывод масива
        }
    }
}
