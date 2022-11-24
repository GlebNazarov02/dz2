string Nedela(int num)
{
    if ((num > 0) && (num < 8))
    {
        if (num > 5)
        {
            return "выходной";
        }
        else
        {
            return "будний";
        }
    }
    else
    {
        return "ошибка";
    }
}

Console.WriteLine("Введите цифру");
int chis = int.Parse(Console.ReadLine());
Console.WriteLine(Nedela(chis));