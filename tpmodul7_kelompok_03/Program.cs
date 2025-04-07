using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace tpmodul7_kelompok_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            DataMahasiswa103022300113.ReadJSON();
            Console.WriteLine();

            DataMahasiswa103022300147.ReadJSON();
            Console.WriteLine();

            KuliahMahasiswa103022300147.ReadJSONKuliah();
            Console.WriteLine();
        }
    }
}
