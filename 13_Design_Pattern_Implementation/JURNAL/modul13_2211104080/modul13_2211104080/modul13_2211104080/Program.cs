using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    public List<string> DataTersimpan { get; set; }

    // Konstruktor privat untuk mencegah pembuatan instance secara langsung
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Mendapatkan instance tunggal dari kelas PusatDataSingleton
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    // Mengembalikan seluruh data yang tersimpan
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    // Menampilkan seluruh data
    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    // Menambahkan data baru ke dalam list
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Menghapus data berdasarkan index yang diberikan
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat dua variabel dengan tipe PusatDataSingleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Menambahkan data anggota kelompok dan asisten praktikum ke data1
        data1.AddSebuahData("Anggota 1");
        data1.AddSebuahData("Anggota 2");
        data1.AddSebuahData("Asisten Praktikum");

        // Mencetak semua data dari data2
        Console.WriteLine("Data di data2:");
        data2.PrintSemuaData();

        // Menghapus nama asisten praktikum
        data2.HapusSebuahData(2);  // Indeks asisten praktikum adalah 2

        // Mencetak data setelah penghapusan dari data1
        Console.WriteLine("\nData di data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // Mencetak jumlah data dari data1 dan data2
        Console.WriteLine("\nJumlah data di data1: " + data1.GetSemuaData().Count);
        Console.WriteLine("Jumlah data di data2: " + data2.GetSemuaData().Count);
    }
}
