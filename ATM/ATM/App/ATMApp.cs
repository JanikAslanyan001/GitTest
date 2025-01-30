using ATM.Domain.Entities;
using ATM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{

    internal class ATMApp
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeDate()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id = 1, FullName = "Janik Aslanyan", AccountNumber = 123456, CardNumber = 321321, CardPin = 123123, AccountBalance = 50000.00m, IsLocked = false },
                new UserAccount{Id = 2, FullName = "Artur Karapetyan", AccountNumber = 456789, CardNumber = 654654, CardPin = 456456, AccountBalance = 40000.00m, IsLocked = false },
                new UserAccount{Id = 3, FullName = "Ani Saghatelyan", AccountNumber = 123555, CardNumber = 987987, CardPin = 789789, AccountBalance = 20000.00m, IsLocked = true },
            };
        }
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validater.Convert<long>("your card number:");
            Console.WriteLine($"Your cardnumber is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
