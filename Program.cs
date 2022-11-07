Console.WriteLine("Enter an integer ");
int n = int.Parse(Console.ReadLine()!);
int res = 0;
int sumDigit(int n)
{
    while (n > 0)
    {
        int dig = n % 10;
        res = res + dig;
        n = n / 10;
    }
    return res;
}
sumDigit (n);

Console.WriteLine("сумма цифр " + res);


