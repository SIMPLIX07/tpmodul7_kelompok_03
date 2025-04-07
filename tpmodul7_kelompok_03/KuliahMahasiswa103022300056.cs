using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace tpmodul7_kelompok_03
{
    class KuliahMahasiswa103022300056
    {
        public static void ReadJSON()
        {

            // berguna untuk menentukan path file json yang akan kita pakai
            string filePath = @"C:\Users\daffa\tpmodul7_kelompok_03\tpmodul7_kelompok_03\tp7_2_103022300056.json";
            // membaca file json yang sudah kita buat sebelumnya
            string jsonString = File.ReadAllText(filePath);
            // mendeserialisasi json ke dalam object Course
            var data = JsonConvert.DeserializeObject<Dictionary<string, List<Course>>>(jsonString);

            List<Course> courses = data["courses"];
            // menampilkan data yang sudah kita ambil dari file json
            var courseCount = 1;
            foreach (var course in courses)
            {

                Console.WriteLine($"MK{courseCount++}: {course.code} - {course.name}");
            }
        }
    }
}
