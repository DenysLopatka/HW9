using System.Collections.Generic;
using System;

namespace Task2
{
    public class AllBankAccounts
    {
        public static List<BankAccount> BankAccounts = new List<BankAccount> { };

        public static string LoggedInLogin = "";
        public static bool IsAnybodyLogedIn = false;

        public void LogIn()
        {
            Console.WriteLine("Enter login of your account:");
            var login = Console.ReadLine();

            if (IsAnybodyLogedIn)
            {
                Console.WriteLine("You are already loged in.");
            }

            if (IsLoginExist(login)) {
                for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
                {
                    if (AllBankAccounts.BankAccounts[i].Login == login)
                    {
                        Console.WriteLine("Enter the password:");
                        var password = Console.ReadLine();

                        if (AllBankAccounts.BankAccounts[i].Password == password)
                        {
                            Console.WriteLine("You loged in!\n");
                            AllBankAccounts.BankAccounts[i].IsLogin = true;

                            LoggedInLogin = login;
                            IsAnybodyLogedIn = true;
                        }

                        else
                        {
                            Console.WriteLine("Wrong password");
                        }
                    }                    
                }
            }
            else
            {
                Console.WriteLine("Account with this login does not exist.\n");
            }
        }

        public bool IsLoginExist(string login)
        {
            for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
            {
                if (AllBankAccounts.BankAccounts[i].Login == login)
                {
                    return true;
                }               
            }
            return false;
        }

        public bool IsLoggedIn(string login)
        {
            for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
            {
                if (AllBankAccounts.BankAccounts[i].IsLogin == true)
                {
                    return true;
                }               
            }
            Console.WriteLine("THere is no user with this login.");
            return false;            
        }

        public void LogOut()
        {
            for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
            {
                if (AllBankAccounts.BankAccounts[i].IsLogin == true)
                {
                    AllBankAccounts.BankAccounts[i].IsLogin = false;
                    Console.WriteLine("You logged out!");
                    LoggedInLogin = "";
                    IsAnybodyLogedIn = false;
                }
            }
        }

        public void AddMoney(string logedInLogin) 
        {
            Console.WriteLine("How much you want to add?");
            try
            {
                var howMuchAdd = Convert.ToDouble(Console.ReadLine());
                if (howMuchAdd < 0)
                {
                    Console.WriteLine("You enter invalid value.\n");
                    return;
                }

            for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
            {
                if (AllBankAccounts.BankAccounts[i].Login == logedInLogin)
                {
                        AllBankAccounts.BankAccounts[i].Money += howMuchAdd;
                        Console.WriteLine();
                        Console.WriteLine($"Now you have {AllBankAccounts.BankAccounts[i].Money} {AllBankAccounts.BankAccounts[i].Currency} on your account.\n");
                }
            }
            
            }

            catch
            {
                Console.WriteLine("You enter invalid value.\n");
                return;
            }
        }

        public void TakeMoney(string logedInLogin)
        {
            Console.WriteLine("How much you want to take?");
            try
            {
                var howMuchTake = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < AllBankAccounts.BankAccounts.Count; i++)
                {
                    if (AllBankAccounts.BankAccounts[i].Login == logedInLogin)
                    {
                        if(howMuchTake> AllBankAccounts.BankAccounts[i].Money)
                        {
                            Console.WriteLine("You don't have enough money on your account.\n");
                            return;
                        }
                        else 
                        {
                            AllBankAccounts.BankAccounts[i].Money -= howMuchTake;
                            Console.WriteLine();
                            Console.WriteLine($"Now you have {AllBankAccounts.BankAccounts[i].Money} {AllBankAccounts.BankAccounts[i].Currency} on your account.\n");
                        }
                        
                    }
                }
            }

            catch
            {
                Console.WriteLine("You enter invalid value.\n");

                return;
            }
        }
    }
}
