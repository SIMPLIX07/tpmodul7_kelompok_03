using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class KuliahMahasiswa103022300113
    {
        public static void ReadJSON()
        {
            // Tentukan path file JSON
            string filePath = @"C:\tumbal\tp7_2_103022300113.json";  // Pastikan path ini sesuai dengan file Anda

            // Membaca file JSON
            string jsonString = File.ReadAllText(filePath);

            // Deserialisasi JSON ke objek KuliahMahasiswa
            KuliahMahasiswa data = JsonSerializer.Deserialize<KuliahMahasiswa>(jsonString);

            // Menampilkan daftar mata kuliah yang diambil
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"{course.code} - {course.name}");
            }
        }
    }
}
