public class Program
{
    public static void Main()
    {
        Action<string> greet = (name) => Console.WriteLine($"Hello, {name}!");
        greet("Aline");
    }
}
