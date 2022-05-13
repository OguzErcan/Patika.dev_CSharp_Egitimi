// See https://aka.ms/new-console-template for more information


// Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
// - Negatif ve numeric olmayan girişleri engelleyin.
// - Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// - Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
using System.Collections;

ArrayList asalSayilar = new ArrayList();
ArrayList asalOlmayanSayilar = new ArrayList();

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Pozitif bir sayi giriniz   : ");
    var sayiString = Console.ReadLine();
    int sayi;
    
    
    while (!int.TryParse(sayiString, out sayi))
    {
        Console.WriteLine("Girdi numerik olmalidir!");
        sayiString = Console.ReadLine();
    }

    while (sayi < 0)
    {
        Console.WriteLine("Girilen deger pozitif olmalidir!");
        var sayiString2 = Console.ReadLine();
        while (!int.TryParse(sayiString2, out sayi))
        {
            Console.WriteLine("Girdi numerik olmalidir!");
            sayiString2 = Console.ReadLine();
        }
    }


    Console.WriteLine("Girdiginiz sayi asal sayi mi? (y/n)   : ");
    if (Console.ReadLine() == "y")
    {
        asalSayilar.Add(sayi);
    }
    else
    {
        asalOlmayanSayilar.Add(sayi);
    }
}

Console.WriteLine("***** Girilen Asal Olmayan Sayilar *****");

asalOlmayanSayilar.Sort();
asalOlmayanSayilar.Reverse();
foreach (var item in asalOlmayanSayilar)
{
    Console.WriteLine(item + ", ");
}


Console.WriteLine("***** Girilen Asal Sayilar");

asalSayilar.Sort();
asalSayilar.Reverse();
foreach (var item in asalSayilar)
{
    Console.WriteLine(item + ", ");
}





Console.WriteLine("********************************************");

Console.WriteLine("Asal olmayan sayilari tutan dizinin eleman sayisi    : " + asalOlmayanSayilar.Count);
Console.WriteLine("Asal sayilari tutan dizinin eleman sayisi            : " + asalSayilar.Count);





Console.WriteLine("********************************************");

int asalOlmayanlarToplam = 0;

foreach (int item in asalOlmayanSayilar)
{
    asalOlmayanlarToplam += item;
}

int asalOlmayanlarOrtalama = asalOlmayanlarToplam / asalOlmayanSayilar.Count;

Console.WriteLine(" Girilen Asal Olmayan Sayilarin Ortalamasi       : " + asalOlmayanlarOrtalama);


int asallarToplam = 0;

foreach (int item in asalSayilar)
{
    asallarToplam += item;
}

int asallarOrtalama = asallarToplam / asalSayilar.Count;

Console.WriteLine("Girilen Asal Sayilarin Ortalamasi                : " + asallarOrtalama);
