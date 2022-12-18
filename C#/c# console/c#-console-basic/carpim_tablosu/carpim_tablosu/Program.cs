Console.WriteLine("Çarpım Tablosu");

for(int i = 0; i <= 10; i++)
{
    for(int j = 0; j <= 10; j++)
    {
        int sonuc = i * j;
        Console.WriteLine(i + " * " + j + " = " + sonuc);
    }
}


Console.Read();