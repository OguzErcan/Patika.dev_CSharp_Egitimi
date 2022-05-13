// See https://aka.ms/new-console-template for more information


int month = DateTime.Now.Month;

// uygulama 1
switch (month)
{ 
    case 1:
        Console.WriteLine("Ocak ayindasiniz");
        break;
    case 2:
        Console.WriteLine("Subat ayindasiniz");
        break;
    case 3:
        Console.WriteLine("Mart ayindasiniz");
        break;
    case 4:
        Console.WriteLine("Nisan ayindasiniz");
        break;
    case 5:
        Console.WriteLine("Mayis ayindasiniz");
        break;
    default:
        Console.WriteLine("Yanlis veri girisi yapildi");
    break;
}

// uygulama 2
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kis mevsimindesiniz");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Ilkbahar mevisimindesiniz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz mevsimindesiniz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimindesiniz");
        break;
    default:

    break;
}
