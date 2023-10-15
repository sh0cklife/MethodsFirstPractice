static double CalculatePrice(string product, int qty)
{
    double total = 0;
    if (product == "coffee")
    {
        total = qty * 1.50;
    }
    else if (product == "water")
    {
        total = qty * 1.00;
    }
    else if (product == "coke")
    {
        total = qty * 1.40;
    }
    else if (product == "snacks")
    {
        total = qty * 2.00;
    }

    return total;
}

string product = Console.ReadLine();
int qty = int.Parse(Console.ReadLine());

double total = CalculatePrice(product, qty);
Console.WriteLine($"{total:f2}");