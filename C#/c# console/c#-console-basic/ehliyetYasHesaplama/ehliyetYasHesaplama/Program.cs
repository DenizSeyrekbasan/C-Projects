Console.WriteLine("Ehliyet otomasyonuna hoş geldiniz,Lütfen bilgileri eksiksiz doldurun..");

Console.Write("Adınız : ");
string ad = Console.ReadLine();
Console.Write("Soyadınız : ");
string soyad = Console.ReadLine();
Console.Write("Egitim durumunuz : ");
string egitim=Console.ReadLine();
Console.Write("Yasınız : ");
int yas = int.Parse(Console.ReadLine());

int ehliyetYas = 18;

if (yas>=ehliyetYas)
{
    Console.WriteLine("*************************");
    Console.WriteLine("Adı : "+ad);
    Console.WriteLine("Soyadı : "+soyad);
    Console.WriteLine("Egitim : "+egitim);
    Console.WriteLine("Yas : "+yas);
    Console.WriteLine("Ehliyet alabilirsiniz..");
}
else
{
    Console.WriteLine("Ehliyet alma başarısız");
}







Console.Read();