// See https://aka.ms/new-console-template for more information


// Uygulama 1

Console.WriteLine("*** Belirtilen sayi araligindaki tek sayilari ekrana yazdirma ***");

Console.Write("Lutfen bir sayi giriniz: "); // Write ile sayi ayni satirda girilebiliyor

int sayac = int.Parse(Console.ReadLine()); // ReadLine string okudugu icin int'e cast ettik
// int sayac = (Int32)Console.ReadLine(); --> string türü int türüne donusturulemiyor uyarisi
// int sayac = Convert.ToInt32(Console.ReadLine()); --> bu sekilde de cast edilebilirdi

for (int i = 1; i <= sayac; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}



// Uygulama 2

Console.WriteLine("*** 1 ve 1000 Arasindaki Tek ve Cift Sayilarin Toplami ***");

int teklerToplam = 0;
int ciftlerToplam = 0;

for (int i = 1; i <= 1000; i++)
{
    if (i % 2 ==0)
    {
        ciftlerToplam += i;
    }
    else
    {
        teklerToplam += i;
    }

}

Console.WriteLine("Tek sayilarin toplami: " + teklerToplam);
Console.WriteLine("Cift sayilarin toplami: " + ciftlerToplam);



// Break ve Continue 

Console.WriteLine("*** Break ve Continue ***");

for (int i = 1; i <= 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i = 1; i <= 10; i++)
{
    if (i == 4)
    {
        continue;
    }

    Console.WriteLine(i);
}



