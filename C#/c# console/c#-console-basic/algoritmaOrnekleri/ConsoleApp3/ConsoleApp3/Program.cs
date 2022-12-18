//Bilgisayar tarafından rasgele tutulan sayıyı tahmin eden ve kaçıncı hakta bildiğini kullanıcıya ileten program 


int hak = 0;
Random rnd = new Random();
int tut = rnd.Next(2,10);

while (true)
{
    
    Console.Write(" 1 ile 10 arasında sayı tahmin edin : ");
    int sayi = int.Parse(Console.ReadLine());
    
    hak++;

    if (tut==sayi)
    {
        Console.WriteLine(" Oyun bitti {0}. tahminde bildiniz..", hak);
        break;
        
    }

}



















Console.Read();