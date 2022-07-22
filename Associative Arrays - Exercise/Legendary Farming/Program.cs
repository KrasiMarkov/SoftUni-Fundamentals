using System;
using System.Linq;
using System.Collections.Generic;
namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> keySubject = new Dictionary<string, int>();

            Dictionary<string, int> junk = new Dictionary<string, int>();

            keySubject["motes"] = 0;
            keySubject["fragments"] = 0;
            keySubject["shards"] = 0;



            while (true)
            {
                string[] elements = Console.ReadLine().ToLower().Split();

                bool flag = false;

                for (int i = 0; i < elements.Length; i += 2)
                {


                    int quantity = int.Parse(elements[i]);

                    string materials = elements[i + 1];

                    if (materials == "shards")
                    {
                       

                        
                        
                            keySubject[materials] += quantity;

                            if (keySubject[materials] >= 250)
                            {
                                keySubject[materials] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                flag = true;
                                break;
                            }
                        
                    }

                    else if (materials == "motes")
                    {
                        

                        
                        
                            keySubject[materials] += quantity;

                            if (keySubject[materials] >= 250)
                            {
                                keySubject[materials] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                flag = true;
                                break;
                            }
                        
                    }

                    else if (materials == "fragments")
                    {
                       

                        
                        
                            keySubject[materials] += quantity;

                            if (keySubject[materials] >= 250)
                            {
                                keySubject[materials] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                flag = true;
                                break;
                            }
                        
                    }

                    else
                    {
                        if (!junk.ContainsKey(materials))
                        {
                            junk[materials] = quantity;
                        }

                        else
                        {
                            junk[materials] += quantity;


                        }
                    }


                }

                if (flag == true)
                {
                    break;
                }
            }

            var sortKeySubject = keySubject.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var sortJunk = junk.OrderBy(x => x.Key);

            foreach (var item in sortKeySubject)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in sortJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
