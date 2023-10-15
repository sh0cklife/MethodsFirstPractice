static int CalcRectArea(int width, int length)
{
    return width * length;
}

int width = int.Parse(Console.ReadLine());
int lengh = int .Parse(Console.ReadLine());
int area = CalcRectArea(width, lengh);
Console.WriteLine(area);