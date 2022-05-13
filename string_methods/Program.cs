// See https://aka.ms/new-console-template for more information



string degisken = "Dersimiz CSharp, Hosgeldiniz!";

Console.WriteLine(degisken.Length);  // karakter sayisi 

Console.WriteLine(degisken.ToUpper());  // karakterleri büyütme
Console.WriteLine(degisken.ToLower());  // karaktetleri küçülttü

Console.WriteLine(String.Concat(degisken, "Merhaba"));  // concatenation

string degisken2 = "Dersimiz CSharp";

Console.WriteLine(degisken.CompareTo(degisken2));  // karakter sayisi esitse 0 , 1>2 ise 1, 1<2 ise -1 doner
Console.WriteLine(String.Compare(degisken, degisken2, true));  // true/false: buyuk-kucuk harf duyarsız/duyarlı

string degisken3 = "CSharp";

Console.WriteLine(degisken.Contains(degisken3));  // icerme/icerme durumu

Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // bool
Console.WriteLine(degisken.StartsWith("Merhaba"));   // bool

Console.WriteLine(degisken.IndexOf("CS"));  //kacinci indexte oldugunu gösterir. bulamazsa -1 verir
Console.WriteLine(degisken.LastIndexOf("i"));  // sondan saymaya baslayarak kacıncı indexte oldugunu verir

Console.WriteLine(degisken.Insert(0, "Merhaba. "));  //baslangıc indexi, eklenecek karakterler

Console.WriteLine(degisken + degisken3.PadLeft(30)); //degisken3 u 30 a tamamlayacak kadar bosluk tanimlar
Console.WriteLine(degisken + degisken3.PadLeft(30, '*'));
// .PadRight 


Console.WriteLine(degisken.Remove(10)); // 10. indexten sonrasini siler
Console.WriteLine(degisken.Remove(5, 3)); // 5. indexten sonra 3 karakter siler

Console.WriteLine(degisken.Replace("CSharp", "C#"));  // degisiklik yapti

Console.WriteLine(degisken.Split(' ')[1]); // boslugu dikkate alarak 3 elemanli dizi tanimladi ve 1. indexi getirdi

Console.WriteLine(degisken.Substring(4,6)); //4. indexten baslayarak 6 karakter getirir





