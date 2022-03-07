namespace Fizzbuzz
{
    internal class Determining
    {
      
        private static string A (int num)
        {
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    return "Fizzbuzz" + " ";
                }
                else

                    return "Fizz" + " ";
            }

            else if (num % 5 == 0)

            {
                return "Buzz" + " ";
            }
            else
                return "";
        }
    }
}