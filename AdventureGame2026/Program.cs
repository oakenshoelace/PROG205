/*
 * Adventure Game 2026
 * Ryan Perlatti, 3/12/2026
 * Description: A text-based adventure game set in a faraway fictional land.
 * Used Adventure Game files from Janell Baxter as the skeleton, modified along the way.
 * Used ASCII art from www.asciiart.eu but unfortunately, both artists were uncredited on the website. For ASCII text, I used https://patorjk.com/software/taag/
 */


//using directives
//there are a few reasons these are helpful
//one is that they allow us to skip using a fully qualified name
//i.e., instead of namespace.class.property or namespace.class.method
//we can just type class.property or class.method

//with the static using directive we can just type property or method
// namespace is a way to organize code and prevent naming conflicts
//by default Visual Studio names the namespace the same name as your project
namespace AdventureGame2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //World world = new World();
            //world.SetUpWorld();
            GameEngine gameEngine = new GameEngine();
            gameEngine.Worlds.Add(new World()); //take out after adding multiple worlds
            gameEngine.SetUpWorld();

        }

    }
}
