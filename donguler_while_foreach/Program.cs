// See https://aka.ms/new-console-template for more information

// while
Console.WriteLine("***** While *****");

// 1 den baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console a yazdiran program

Console.Write("Lutfen bir sayi giriniz: ");
int sayi1 = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi1)
{
    toplam += sayac;
    sayac ++;
}

Console.WriteLine(toplam / sayi1);





// alfabedeki harfleri console a yazdirma

char harf = 'a';

while (harf <= 'z')
{
    Console.Write(harf);
    harf ++;
}






// foreach

Console.WriteLine("***** foreach *****");

string[] arabalar = {"BMW" , "Ford" , "Toyota" , "Audi"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
