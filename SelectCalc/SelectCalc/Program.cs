using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SelectCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = "result.txt";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                if (args.Length != 1)
                {
                    sw.WriteLine("Ошибка, нужно один документ");
                }
            else
                {
                int p = int.Parse(args[0]);

                int i, summa;
                summa = 0;

                for (i = 0; i < p; i++)
                {
                    summa += (i+1);
                }
                    sw.WriteLine($"Сумма первых {p} чисел = {summa}");

                }
            }
        }
    }
}
