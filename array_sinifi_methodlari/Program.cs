// See https://aka.ms/new-console-template for more information




// Sort

int [] sayiDizisi = {23 , 7 , 32 , 77 , 97, 27 , 55 , 2 , 10 , 5};

Console.WriteLine("***** Sirasiz dizi *****");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("***** Sirali dizi *****");
// array siniflari bu metotlari static olarak acmis oldugundan erisilebilir
Array.Sort(sayiDizisi); // void fonksiyon oldugundan verilen dizi uzerinde degisiklik yapar yeni bir dizi tanimlanmasi gerekmez
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}


// Clear

Console.WriteLine("***** Array Clear *****");

// sayiDizisi elemanlarini kullanarak 2. indexten itibaren 2 tane elemani sifirlar
Array.Clear(sayiDizisi, 2, 2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}


// Reverse

Console.WriteLine("***** Reverse *****");
// diziyi tersine cevirir

Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}


// IndexOf
// verilen dizi uzerinde verilen elemanin indexini doner

Console.WriteLine("***** IndexOf *****");

Console.WriteLine(Array.IndexOf(sayiDizisi, 23));



// Resize
// Yeniden boyutlandirma

Console.WriteLine("***** Resize *****");

Array.Resize<int>(ref sayiDizisi, 11);
sayiDizisi[10] = 99;
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
