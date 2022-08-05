using System;
using System.Collections.Generic;
using System.Linq;
namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ").ToArray();

            List<string> final = new List<string>();

            for (int i = 0; i < username.Length; i++)
            {
                string word = username[i];

                int countWord = word.Length;

                if (countWord > 2 && countWord < 17)
                {
                    bool flag = false;

                    for (int j = 0; j < word.Length; j++)
                    {
                        char symbol = word[j];

                        if (!char.IsDigit(symbol) && !char.IsLetter(symbol) && symbol != '-' && symbol != '_')
                        {
                            flag = true;

                            break;
                        }




                    }

                    if (flag == true)
                    {
                        continue;
                    }

                    
                    
                        final.Add(word);
                    


                }
            }

            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
        }
    }
}
