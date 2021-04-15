using System;

namespace Task2
{
    public class NewAccount
    {
        public void CreateNewAccount()
        {
            Console.WriteLine("Choose currency:\n(1)EUR\n(2)USD\n(3)UAH\n(4)RUB\n(5)CNY\n");
            var choosenCurrency = Console.ReadLine();

            switch (choosenCurrency)
            {
                case "1": choosenCurrency = "EUR"; break;
                case "2": choosenCurrency = "USD"; break;
                case "3": choosenCurrency = "UAH"; break;
                case "4": choosenCurrency = "RUB"; break;
                case "5": choosenCurrency = "CNY"; break;
                default: Console.WriteLine("Wrong number");return;
            }

            Console.WriteLine("Enter your login:");
            var login = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();

            Console.WriteLine();

            AllBankAccounts.BankAccounts.Add(new BankAccount(choosenCurrency, login, password));                               
        }        
    }
}
