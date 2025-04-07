using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class DataMahasiswa103022300147
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_1_103022300147.json");
            var data = JsonConvert.DeserializeObject<DataMahasiswa103022300147>(jsonString);
            Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
