using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //подключение бинарной сериализации
using System.Runtime.Serialization; //для обработки сериализации и десериализации событиями

namespace testing111
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamWriter sw = new StreamWriter("Testfile.txt"))
            {
                sw.WriteLine("Testing text1");
                sw.WriteLine("Testing text2");

                sw.Write("The date is: ");
                sw.WriteLine(DateTime.Now);
            }
            
            try
            {
                using (StreamReader sr = new StreamReader("Testfile.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
