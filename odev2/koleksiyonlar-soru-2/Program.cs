// See https://aka.ms/new-console-template for more information

// Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

int[] sayiDizisi = new int [20];


for (int i = 0; i < 20; i++)
{
    Console.Write("{0}. sayiyi girin        : ", i+1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}


Array.Sort(sayiDizisi);

int[] enKucukUclu = {sayiDizisi[0], sayiDizisi[1], sayiDizisi[2]};
int[] enBuyukUclu = {sayiDizisi[17], sayiDizisi[18], sayiDizisi[19]};

int enKucuklerToplam = 0;
int enBuyuklerToplam = 0;

foreach (int sayi in enKucukUclu)
{
    enKucuklerToplam += sayi;
}

int enKucuklerOrtalama = enKucuklerToplam / 3;

Console.WriteLine("Verilen sayilardan en kucuk uc sayinin ortalamasi        : " + enKucuklerOrtalama);


foreach (int sayi in enBuyukUclu)
{
    enBuyuklerToplam += sayi;
}

int enBuyuklerOrtalama = enBuyuklerToplam / 3;

Console.WriteLine("Verilen sayilardan en buyuk uc sayinin ortalmasi         : " + enBuyuklerOrtalama);


int ortalamalarToplam = enKucuklerOrtalama + enBuyuklerOrtalama;
Console.WriteLine("Ortalamlarin toplam degeri                               : " + ortalamalarToplam);




