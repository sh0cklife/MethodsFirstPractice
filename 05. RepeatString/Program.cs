string RepeatString(string text, int repeatCountText)
{
    string output = "";
    for (int i = 0; i < repeatCountText; i++)
    {
        output += text;
    }
    return output;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatString(text, count);
Console.WriteLine(result);
