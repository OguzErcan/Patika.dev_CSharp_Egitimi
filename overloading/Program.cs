// See https://aka.ms/new-console-template for more information



// out parametreler

string sayi = "999";
// int outSayi; --> bu noktada tanimlama yapilmadan TryParse icinde kullanilabilir

// bool sonuc = int.TryParse(sayi, out outSayi);
bool sonuc = int.TryParse(sayi, out int outSayi);

if (sonuc)
{
    Console.WriteLine("Basarili!");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Basarisiz!");
}



Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);







// Method overloading
// Method imzasi --> metodAdi + parametreSayisi + parametre

int ifade = 555;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Oguz ", "Ercan");



class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}

