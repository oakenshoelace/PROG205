/*
 * Adventure Game 2026
 * Janell Baxter, 1/29/2026
 * Description: A text-based adventure game set in the year 2026.
 */


//using directives
//there are a few reasons these are helpful
//one is that they allow us to skip using a fully qualified name
//i.e., instead of namespace.class.property or namespace.class.method
//we can just type class.property or class.method

//with the static using directive we can just type property or method
using static System.Console;

// namespace is a way to organize code and prevent naming conflicts
//by default Visual Studio names the namespace the same name as your project
namespace AdventureGame2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.SetUpWorld();
        }
    }
}
