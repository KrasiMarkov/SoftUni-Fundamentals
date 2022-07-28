using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();

            string text = Console.ReadLine();

            int result = -1;

           

            while (true)
            {
                result = text.IndexOf(word);

              

                if (result == -1)
                {
                    break; 
                }


                text = text.Remove(result, word.Length);
            }

            Console.WriteLine(text);

        }
    }
}
