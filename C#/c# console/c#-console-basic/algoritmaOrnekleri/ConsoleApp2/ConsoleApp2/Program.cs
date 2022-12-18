//1-100 arasındaki sayıların toplamını While Döngüsü kullanarak yapınız.

int toplam = 0;
int sayi = 1;

while (sayi < 100)
{
    
    toplam = sayi + toplam;
    sayi++;

}
Console.WriteLine("Toplam = " + toplam);








Console.Read();