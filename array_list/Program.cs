// See https://aka.ms/new-console-template for more information



using System.Collections;
using System.Collections.Generic;

ArrayList liste = new ArrayList();

liste.Add("Ayse");
liste.Add(2);
liste.Add(true);
liste.Add('C');

// elemanlara erisim

Console.WriteLine(liste[1]);
foreach (var item in liste)
{
    Console.WriteLine(item);
}


// AddRange
Console.WriteLine("***** AddRange *****");

string[] renkler = {"kirmizi" , "yesil" , "mavi" , "sari"};
List<int> sayilar = new List<int>(){1, 8, 3, 7, 9, 92, 5};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}


// Sort
Console.WriteLine("***** Sort *****");

// yalnizca sayi barindarmali


// Binary Search
Console.WriteLine("***** Binary Search *****");

// önce siralama yapilmali
Console.WriteLine(liste.BinarySearch(9));


// Reverse
Console.WriteLine("***** Reverse *****");

liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}


// Clear
Console.WriteLine("***** Clear *****");

liste.Clear();

foreach (var item in liste)
{
    Console.WriteLine(item);
}