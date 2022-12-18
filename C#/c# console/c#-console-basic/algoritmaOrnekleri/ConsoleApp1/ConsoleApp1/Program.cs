//Klavyeden girilen sayı 0 (Sıfır) olana kadar, girilen sayılardan çift sayıları toplayan, tek sayıları çıkaran ve sonucu ekranda gösteren programı yapınız.

int tek = 0;
int cift = 0;

while (true)
{
    Console.Write("Sayı giriniz : ");
    int sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0)
    {
        cift = cift + sayi;
    }
    else if (sayi % 2 != 0)
    {
        tek = tek - sayi;
    }

    if (sayi == 0)
    {
        Console.WriteLine("Döngü bitti..");
        break;
    }


    Console.WriteLine("Tek sayıların toplamı : " + tek);
    Console.WriteLine("Çift sayıların toplamı : " + cift);
}

Console.Read();