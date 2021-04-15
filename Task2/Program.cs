namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new Actions().StartMenu();
                while (AllBankAccounts.IsAnybodyLogedIn)
                {
                    new Actions().ChooseActionForCustomer();
                }
            }
        }
    }
}
