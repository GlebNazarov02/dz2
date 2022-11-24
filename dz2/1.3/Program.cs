string TreriaCifra(int num)
{
    if (num >= 100) 
{
    while (num > 999)
    {   
        num = num / 10;
    }
    num = num % 10;
    return $"{num}";
}
else
{
    return "ошибка";
}
}

Console.WriteLine("Введите число");
int chis = int.Parse(Console.ReadLine());
Console.WriteLine(TreriaCifra(chis));