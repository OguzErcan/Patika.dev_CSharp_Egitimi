// See https://aka.ms/new-console-template for more information


// Dizi tanimlama

string[] renkler = new string [5];  // boyutu belirtilmis dizi

string[] hayvanlar = {"kedi" , "kopek" , "kus" , "balik"};

int[] dizi;
dizi = new int [5];

// Dizilere deger atama ve erisim

renkler[0] = "mavi";
dizi [3] = 10;



Console.WriteLine(renkler[0]);
Console.WriteLine(dizi[3]);
Console.WriteLine(hayvanlar[1]);


// Dongulerde dizi kullanımı

// Kullanici tarafinden verilen n tane sayinin ortalamasini hesaplayan program

Console.Write("Lutfen eleman sayisini giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int [] sayiDizisi = new int [diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lutfen {0}. sayiyi giriniz: ", i+1); // kullanici ekranda index degeri yerine eleman sayisini gorecek
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;

foreach (int sayi in sayiDizisi)
{
    toplam += sayi;
}

Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);



