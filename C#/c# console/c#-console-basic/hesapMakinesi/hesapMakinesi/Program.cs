Console.WriteLine("****************Hesap Makinesi********************");

while (true)
{
    Console.WriteLine("Toplama için : 1");
    Console.WriteLine("Çıkarma için : 2");
    Console.WriteLine("Çarpma için  : 3");
    Console.WriteLine("Bölme için   : 4");
    Console.WriteLine("Çıkış için   : ESC");
    Console.Write("Tuşlarından birine basınız.......");
    
    var basilanTus = Console.ReadKey();

    if (basilanTus.Key==ConsoleKey.NumPad1)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.Write("sayı 1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("sayı 2: ");
        int num2 = int.Parse(Console.ReadLine());
        int top = num1 + num2;
        Console.WriteLine("sonuc = " + top);
        Console.WriteLine("**********************");
    }
    else if (basilanTus.Key == ConsoleKey.NumPad2)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.Write("sayı 1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("sayı 2: ");
        int num2 = int.Parse(Console.ReadLine());
        int cik = num1 - num2;
        Console.WriteLine("sonuc = " + cik);
        Console.WriteLine("**********************");
    }
    else if (basilanTus.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.Write("sayı 1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("sayı 2: ");
        int num2 = int.Parse(Console.ReadLine());
        int carp = num1 * num2;
        Console.WriteLine("sonuc = " + carp);
        Console.WriteLine("**********************");
    }
    else if (basilanTus.Key == ConsoleKey.NumPad4)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.Write("sayı 1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("sayı 2: ");
        int num2 = int.Parse(Console.ReadLine());
        int bol = num1 / num2;
        Console.WriteLine("sonuc = " + bol);
        Console.WriteLine("**********************");
    }
    else
    {
        break;
    }


}

Console.Read();