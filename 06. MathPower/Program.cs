int MathPower(int baseNum, int power)
{
    int ouput = baseNum;
    for (int i = 0; i < power - 1; i++)
    {
        ouput *= baseNum;
    }
    return ouput;
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int result = MathPower(num1, num2);
Console.WriteLine(result);