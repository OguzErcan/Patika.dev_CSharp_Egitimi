// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;

Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(10, "Ayse Yilmaz");
kullanicilar.Add(12, "Ahmet Yilmaz");
kullanicilar.Add(18, "Deniz Arda");
kullanicilar.Add(20, "Ozcan Cosar");

// Dizinin elemanlarina erisim
Console.WriteLine("***** Dizinin Elemanlarina Erisim *****");

Console.WriteLine(kullanicilar[12]);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}



Console.WriteLine(kullanicilar.Count);  // pair sayisi
Console.WriteLine(kullanicilar.ContainsKey(10)); // icerik kontrolu
Console.WriteLine(kullanicilar.ContainsValue("Oguz Ercan"));
kullanicilar.Remove(12); // kaldirma
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

foreach (var item in kullanicilar.Keys)
{
    Console.WriteLine(item);
}

foreach (var item in kullanicilar.Values)
{
    Console.WriteLine(item);
}



