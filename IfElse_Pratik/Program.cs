Console.Write("Lütfen bir sayı giriniz:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 10)
{
    Console.WriteLine("Girilen sayi 10'dan büyüktür.");
}
else if (num < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}

if (num % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}


