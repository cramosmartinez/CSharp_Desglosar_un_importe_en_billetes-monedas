using System;

class BillBreaker
{
    static void Main()
    {
        Console.Write("Ingrese un importe: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        BreakDownAmount(amount);
    }

    static void BreakDownAmount(decimal amount)
    {
        int[] bills = { 100, 50, 20, 10, 5, 1 };
        decimal[] coins = { 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

        Console.WriteLine("Desglose en billetes:");
        foreach (int bill in bills)
        {
            int count = (int)(amount / bill);
            amount -= count * bill;
            Console.WriteLine($"{count} billetes de {bill}");
        }

        Console.WriteLine("Desglose en monedas:");
        foreach (decimal coin in coins)
        {
            int count = (int)(amount / coin);
            amount -= count * coin;
            Console.WriteLine($"{count} monedas de {coin:F2}");
        }
    }
}
