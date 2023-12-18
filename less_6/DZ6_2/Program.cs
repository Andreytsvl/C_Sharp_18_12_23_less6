class Program
{
    static void Main()
    {
        string inputString = "HeLLO WoRLd";
        string outputString = ConvertToUpperToLower(inputString);

        Console.WriteLine(outputString);
    }

    static string ConvertToUpperToLower(string input)
    {
        string result = "";

        foreach (char c in input)
        {
            if (Char.IsUpper(c))
            {
                char lower = Char.ToLower(c);
                result += lower;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
