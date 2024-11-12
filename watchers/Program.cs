using watchers.Types;

namespace watchers;

internal class Program
{
    static void Main(string[] args)
    {
        var typeAsString = "type1";
        var factory = new TypeFactory();

        var isValidType = factory.IsValidType(typeAsString);
        if (isValidType)
        {
            Console.WriteLine("is valid");
        }

        var type = factory.CreateType(typeAsString);

    }
}
