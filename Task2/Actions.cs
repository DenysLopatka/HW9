using System;

namespace Task2
{
    public class Actions
    {
        public void StartMenu()
        {
            Console.WriteLine("This is test");
            System.Console.WriteLine("Hello! What do you want to do?\n(1)Add new bank acount\n(2)Log in");
            var actionInStartMenu = Console.ReadLine();

            if (actionInStartMenu == "1")
            {
                new NewAccount().CreateNewAccount();
            }
            else if (actionInStartMenu == "2")
            {
                new AllBankAccounts().LogIn();
            }
        }

        public void ChooseActionForCustomer()
        {
            Console.WriteLine("What do you want to do?\n(1)Top up an account\n(2)Withdraw money from " +
                "the account\n(3)Change currency of your account\n(4)Show exchange rates\n(5)Show balance\n(6)Log out\n");
            var actionForCustomer = Console.ReadLine();

            if (actionForCustomer == "1")
            {
                new AllBankAccounts().AddMoney(AllBankAccounts.LoggedInLogin);
            }

            else if (actionForCustomer == "2")
            {
                new AllBankAccounts().TakeMoney(AllBankAccounts.LoggedInLogin);
            }

            else if (actionForCustomer == "3")
            {
                Console.WriteLine("To which currency you want to convert your account?\nChoose currency:\n(1)EUR\n(2)USD\n(3)UAH\n(4)RUB\n(5)CNY\n");

                var convertTo = Console.ReadLine();
                switch (convertTo)
                {
                    case "1": convertTo = "EUR"; break;
                    case "2": convertTo = "USD"; break;
                    case "3": convertTo = "UAH"; break;
                    case "4": convertTo = "RUB"; break;
                    case "5": convertTo = "CNY"; break;
                    default: Console.WriteLine("Wrong number. Try Again. \n"); return;
                }

                var convertFrom = "";
                double howMuch = 0;

                for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
                {
                    if (AllBankAccounts.BankAccounts[i].IsLogin == true)
                    {
                        convertFrom = AllBankAccounts.BankAccounts[i].Currency;
                        howMuch = AllBankAccounts.BankAccounts[i].Money;
                        AllBankAccounts.BankAccounts[i].Money = new Converter().ConvertTo(convertFrom, convertTo, howMuch);
                        AllBankAccounts.BankAccounts[i].Currency = convertTo;
                        Console.WriteLine($"Now you have {AllBankAccounts.BankAccounts[i].Money} {AllBankAccounts.BankAccounts[i].Currency} on your account. \n");
                    }
                }
            }

            else if (actionForCustomer == "4")
            {
                Console.WriteLine();
                new Converter().ShowRates();
                Console.WriteLine();
            }

            else if (actionForCustomer == "5")
            {
                for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
                {
                    if (AllBankAccounts.BankAccounts[i].IsLogin == true)
                    {
                        Console.WriteLine($"You have {AllBankAccounts.BankAccounts[i].Money} {AllBankAccounts.BankAccounts[i].Currency} on your account. \n");
                    }
                }
            }


            else if (actionForCustomer == "6")
            {
                new AllBankAccounts().LogOut();
            }

            else
            {
                Console.WriteLine("Invalid input. Try again.\n");
            }             
        }
    }
}
