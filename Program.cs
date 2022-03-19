﻿namespace modul4_1302204100;

public class MainClass
{
    public static void Main(string[] args)
    {
        // NIM = 1302204051
        Penjumlahan.JumlahTigaAngka<long>(13, 02, 20);
        SimpleDataBase<long> objData1 = new SimpleDataBase<long>();
        objData1.AddNewData(13);
        objData1.AddNewData(02);
        objData1.AddNewData(20);
        objData1.PrintAllData();
    }
}
public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic angka1 = data1;
        dynamic angka2 = data2;
        dynamic angka3 = data3;

        Console.WriteLine(angka1 + angka2 + angka3 + "\n");

    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T databaru)
    {
        storedData.Add(databaru);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + " yang disimpan pada waktu UTC : " + inputDates[i] + " AM");
        }
    }
}