using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class DataMahasiswa103022300113
    {
        public static void ReadJSON()
        {
            string filePath = @"C:\tumbal\tp7_1_103022300113.json";
            string jsonString = File.ReadAllText(filePath);
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");


        }
    }   
}
