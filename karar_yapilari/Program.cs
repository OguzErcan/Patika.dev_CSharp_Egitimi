// See https://aka.ms/new-console-template for more information

int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("Gunaydin!!");
else if (time<=18)
    Console.WriteLine("İyi gunler!!");
else
    Console.WriteLine("Iyı geceler!!");

    //karar yapisini tek satirda yazma

string sonuc = time <= 18 ? "Iyı gunler!!" : "Iyı geceler!!";
Console.WriteLine(sonuc);

sonuc = time >= 6 && time < 11 ? "Gunaydin" : time <= 18 ? "Iyı gunler" : "Iyı geceler";


