using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20StreamReader
{
    class Program
    {

        private static List<int> GetNumbersFromFile(string url)
        {
            using (StreamReader reader = new StreamReader(url))
            {
                List<int> values = new List<int>();
                while (!reader.EndOfStream)
                {
                    string line;
                    line = reader.ReadLine();

                    values.Add(int.Parse(line));

                }
                return values;
            }
        }

        static void Main(string[] args)
        {
            //int sum = 0;
            //int counter = 0;

            //using (StreamReader reader = new StreamReader(@"C:/Users/will5606/source/repos/EX20StreamReader/TextFile1.txt"))
            //{
            //    List<int> values = new List<int>();

            //    while (!reader.EndOfStream)
            //    {
            //        /* OPG 1
            //        string line;
            //        line = reader.ReadLine();

            //        counter += line.Count();
            //        sum += int.Parse(line);
            //        */

            //        string line;
            //        line = reader.ReadLine();

            //        values.Add(int.Parse(line));
            //    }

            //    //Console.WriteLine("Summen af tallene i filen TextFile1.txt er " + sum + " og antallet af tal er " + counter);

            //    Console.WriteLine("Summen af tallene i filen TextFile1.txt er -" + values.Sum() + "-, med et gennemsnit på -" + values.Average() + "-.");
            //}

//----------------------------------------------------------------------------------------------------------------------------------------------------------


            List<int> values = GetNumbersFromFile(@"C:\Users\will5606\source\repos\EX20StreamReader\TextFile1.txt");

            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.ReadKey();

            
        }


    }
}
