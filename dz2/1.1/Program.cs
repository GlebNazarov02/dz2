string VtoraiaCifra(int num)
{
    if ((num >= 100) && (num < 1000))
{
        num = num / 10;
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
Console.WriteLine(VtoraiaCifra(chis));