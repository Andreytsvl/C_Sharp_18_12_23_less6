
class Program
{
    static void Main()
    {
        string inputString = "level";
        
        bool isPalindrome = IsPalindrome(inputString);

        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом");
        }
    }

    static bool IsPalindrome(string input)
    {
        // Удаляем все пробелы из строки и приводим к нижнему регистру
        input = input.Replace(" ", "").ToLower();

        // Проверяем, является ли строка палиндромом
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}