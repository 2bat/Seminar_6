// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
public class Task2
{
    public static void Main(string[] args)
    {
        string input = "hElLo_WoRd!";
        string result = input.ToLower();
        Console.WriteLine(result);
    }
}