using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class KuliahMahasiswa103022300147
    {
        public string kode_matakuliah { get; set; }
        public string nama_matakuliah { get; set; }

        public static void ReadJSONKuliah()
        {
            string jsonString = File.ReadAllText("tp7_2_103022300147.json");
            var data = JsonConvert.DeserializeObject<List<KuliahMahasiswa103022300147>>(jsonString);
            int i = 1;
            foreach (var item in data)
            {
                Console.WriteLine($"MK {i} <{item.kode_matakuliah}> - <{item.nama_matakuliah}>");
                i++;
            }
        }
    }
}
