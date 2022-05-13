// See https://aka.ms/new-console-template for more information



List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(4);
sayiListesi.Add(10);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);


List<string> renkListesi = new List<string>();

renkListesi.Add("mavi");
renkListesi.Add("kirmizi");
renkListesi.Add("turuncu");
renkListesi.Add("mor");
renkListesi.Add("yesil");
renkListesi.Add("siyah");
renkListesi.Add("beyaz");

// Count: eleman sayisi

Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

// elemanlara erisim

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));


foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}
renkListesi.ForEach(renk => Console.WriteLine(renk));


// listeden eleman cıkarma

sayiListesi.Remove(4);
renkListesi.Remove("beyaz");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

sayiListesi.RemoveAt(0); // indexteki elemani cıkarma


// liste icerisinde arama

if (sayiListesi.Contains(10))
{
    Console.WriteLine("Bulundu");
}

// eleman ile indexe erisme

Console.WriteLine(renkListesi.BinarySearch("mor"));


// diziyi liste cevirme

string[] hayvanlar = {"kedi" , "kopek" , "kus" , "balik"};

List<string> hayvanlarListesi = new List<string>(hayvanlar);


// listeyi temizleme

hayvanlarListesi.Clear();


// list icerisinde nesne tutmak

List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Ayse";
kullanici1.Soyisim = "Yilmaz";
kullanici1.Yas = 26;

Kullanicilar kullanici2 =new Kullanicilar();
kullanici2.Isim = "Oguz";
kullanici2.Soyisim = "Ercan";
kullanici2.Yas = 24;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);


List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar()
{
    Isim = "Deniz",
    Soyisim = "Arda",
    Yas = 35
});

foreach (Kullanicilar kullanici in kullaniciListesi)
{
    Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
    Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim);
    Console.WriteLine("Kullanici Yasi: " + kullanici.Yas);
}

public class Kullanicilar
{
    string isim;
    string soyisim;
    int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
    
}