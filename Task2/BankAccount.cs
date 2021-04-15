namespace Task2
{
    public class BankAccount
    {
        
        public string Currency;
        public double Money;
        public string Login;
        public string Password;
        public bool IsLogin;

        public BankAccount(string currency, string login, string password, double money = 0, bool isLogin = false)
        {
            Currency = currency;
            Login = login;
            Password = password;
            Money = money;
            IsLogin = isLogin;
            
        }        
    }
}
