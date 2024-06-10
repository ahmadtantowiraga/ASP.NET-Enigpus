public class Utility
{
    public static string InputString(string info)
    {
        Console.Write(info);
        while (true)
        {
            string result = Console.ReadLine();
            if (string.IsNullOrEmpty(result))
            {
                continue;
            }
            return result;
        }
    }
    public static int InputIntUtil(string info)
    {
        while (true)
        {
            Console.Write(info);
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("ONLY INPUT NUMBERS");
                Console.WriteLine();
                continue;
            }
        }
    }
}
