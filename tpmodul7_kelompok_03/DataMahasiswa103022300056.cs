using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class DataMahasiswa103022300056
    {
        public static void ReadJSON()
        {
            // berguna untuk menentukan path file json yang akan kita pakai
            string filePath = @"C:\Users\daffa\tpmodul7_kelompok_03\tpmodul7_kelompok_03\tp7_1_103022300056.json";
            // membaca file json yang sudah kita buat sebelumnya
            string jsonString = File.ReadAllText(filePath);
            // mendeserialisasi json ke dalam object mahasiswa
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            // menampilkan data yang sudah kita ambil dari file json
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");


        }
    }
}
