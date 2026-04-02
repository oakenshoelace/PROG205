namespace AdventureGame2026
{
    public class Utility
    {
        public static void Print(string output) => Console.WriteLine(output);

        public static int ConvertStringToInteger(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }

            return 0;
        }
        public static float ConvertStringToFloat(string s)
        {
            if (float.TryParse(s, out float result))
            {
                return result;
            }

            return 0;
        }
        public static double ConvertStringToDouble(string s)
        {
            if (double.TryParse(s, out double result))
            {
                return result;
            }

            return 0;
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }

}