// See https://aka.ms/new-console-template for more information

// Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;



string sesliHarfler = "aeiou";

ArrayList harfDizisi = new ArrayList();

Console.WriteLine("Bir cumle girin.");


string cumle = Console.ReadLine();

for (int i = 0; i < cumle.Length; i++)
{
    if (sesliHarfler.Contains(cumle[i]))
    {
        harfDizisi.Add(cumle[i]);
    }
}


harfDizisi.Sort();

foreach (var item in harfDizisi)
{
    Console.Write(item);
}