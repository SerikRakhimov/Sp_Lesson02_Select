using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SelectLoadfile
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
                    string fileName = args[0];
                    //            WebRequest req = WebRequest.Create(@"https://api.got.show/api/book/characters");
                    WebRequest req = WebRequest.Create(fileName);


                    string jsonText = "";

                    WebResponse response = req.GetResponse();
                    using (Stream s = response.GetResponseStream()) //Пишем в поток.
                    {
                        using (StreamReader r = new StreamReader(s)) //Читаем из потока.
                        {
                            jsonText = r.ReadToEnd();
                        }
                    }
                    response.Close(); //Закрываем поток

                    sw.WriteLine($"Файл скачан с {fileName}");

                }
            }
        }
    }
}
