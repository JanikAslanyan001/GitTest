using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "My ATM App";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n---------Welcom to my ATM App-----------\n\n");

            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physicial ATM card, " +
                "read the card number and validate it.");
            Utility.PressEnterToContinue();
        }

        
    }
}
 