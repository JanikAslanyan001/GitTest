using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public static class Validater
    {
        public static T Convert<T>(string promt)
        { 
            bool valid = false;
            string userInput;

            while (!valid)
            { 
                userInput = Utility.GetUserInput(promt);

                try 
                {
                   var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else 
                    {
                        return default;
                    }

                }
                catch 
                {
                    Utility.PrintMessage("Invalid input. Try again", false);
                }
            }
            return default;
        }
    }
}
