using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite putanju direktorija: ");
            string putanja = Console.ReadLine();

            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteke in Directory.GetFiles(putanja)) ;
                {
                    Console.WriteLine(datoteka);
                }

                string putanjaPoddirektorija = putanja + "//TEST";
                if (!Directory.Exists(putanjaPoddirektorija))
                {
                    Directory.CreateDirectory(putanjaPoddirektorija);
                }
                Console.WriteLine("Poddirektoriji: ");
                foreach (string poddirektorij in Directory.GetDirectories(putanja)) ;

                Directory.Delete(putanjaPoddirektorija);

                Console.WriteLine("Nakon brisanja direktorija " +
                    "\n TEST:");
                {
                    foreach (string poddirektorij in Directory.GetDirectories(putanja)) ;
                }
            }
            else
            {
                Console.WriteLine("Putanja ne postoji na računalu!");
            }
            Console.ReadKey();
        }
    }
}
