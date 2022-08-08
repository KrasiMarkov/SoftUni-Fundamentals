using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            var regex = new Regex(@"\+359(-| )2\1[0-9]{3}\1[0-9]{4}\b");

            var matches = regex.Matches(numbers);



            Console.WriteLine(string.Join(", ", matches));
            
        } 
    }
}
