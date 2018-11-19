using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2tp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {
                    string path; //путь 
                    Console.WriteLine("Введите путь к папке"); // C:\...\название файла.txt 
                    path = Console.ReadLine();

                    int code; //кодировка 
                    Console.WriteLine("Введите кодировку:Win(1251),DOC(866),UTF-8(65001)");
                    code = int.Parse(Console.ReadLine());

                    using (TextReader txt = new StreamReader(path, Encoding.GetEncoding(code)))
                    {
                        Console.WriteLine(txt.ReadToEnd());
                    }
                    flag = true;
                }
                catch (Exception)
                { }
            }
            while (!flag);

            Console.ReadKey();
        }
    }
}
