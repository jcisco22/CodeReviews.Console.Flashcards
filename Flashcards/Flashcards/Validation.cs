
public class Validation
{
    // input validation logic
    public static int ValidateId(string Input)
    {

        int result;


        while (!int.TryParse(Input, out result) || result <= 0)
        {
            Console.WriteLine("Please enter a valid ID.");
            Input = Console.ReadLine();

        }

        return result;
    }

    public static string GetNonEmptyInput(string prompt)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input can't be empty. Please try again:");
            input = Console.ReadLine();
        }

        return input.Trim();
    }

}