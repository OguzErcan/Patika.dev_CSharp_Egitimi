// See https://aka.ms/new-console-template for more information

// DateTime Class

Console.WriteLine(DateTime.Now);  // gunun tarihini ve saatini getirir
Console.WriteLine(DateTime.Now.Date); // tarihi
Console.WriteLine(DateTime.Now.Day); // gunu
Console.WriteLine(DateTime.Now.Month); 
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek); // gunlerden ne str olarak
Console.WriteLine(DateTime.Now.DayOfYear); // yilin kacinci gunu

Console.WriteLine(DateTime.Now.ToLongDateString()); // 3 mayis 2022 sali
Console.WriteLine(DateTime.Now.ToShortDateString()); // 3.05.2022
Console.WriteLine(DateTime.Now.ToLongTimeString()); // saat dakika saniye
Console.WriteLine(DateTime.Now.ToShortTimeString()); // saat dakika

Console.WriteLine(DateTime.Now.AddDays(5));
Console.WriteLine(DateTime.Now.AddMonths(3));
// yil, dakika, saniye ...

// DateTime Format
Console.WriteLine(DateTime.Now.ToString("dd")); // 03
Console.WriteLine(DateTime.Now.ToString("ddd")); // Tue
Console.WriteLine(DateTime.Now.ToString("dddd")); // Tuesday
Console.WriteLine(DateTime.Now.ToString("MM")); // 05
Console.WriteLine(DateTime.Now.ToString("MMM")); // May
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Mayis
Console.WriteLine(DateTime.Now.ToString("yy")); // 22
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022





// Math Class

Console.WriteLine(Math.Abs(-25));  // mutlak deger
Console.WriteLine(Math.Sin(30)); // sinus trigonometrik fonksiyonlar

Console.WriteLine(Math.Ceiling(22.3));  // yukari yuvarlar
Console.WriteLine(Math.Round(22.3));    // yuvarlama
Console.WriteLine(Math.Floor(22.7));    // asagi yuvarlar

Console.WriteLine(Math.Max(2, 6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3, 4));  // üs alma
Console.WriteLine(Math.Sqrt(4));    // karekok

Console.WriteLine(Math.Log(9)); // 9 un e tabanindaki log karsiligi
Console.WriteLine(Math.Exp(3)); // e üzeri 3





