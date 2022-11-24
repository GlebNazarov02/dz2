int Urez(int num)
{
    Console.WriteLine(num);
    num = (num / 100) * 10 + (num % 10);
    return num;
}

Console.WriteLine(Urez(new Random().Next(100, 1000)));