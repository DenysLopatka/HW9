namespace Task2
{
    public class Converter
    {
        public double USDRate = 28.0156;
        public double EURRate = 33.3218;
        public double UAHRate = 1;
        public double RUBRate = 0.3626;
        public double CNYRate = 4.2774;

        public double ConvertTo(string convertFrom, string convertTo, double howMuchToConvert)
        {
            double firstRate = 0;

            if (convertFrom == "USD")            
                firstRate = USDRate;
            
            else if (convertFrom == "EUR")            
                firstRate = EURRate;
            
            else if (convertFrom == "UAH")            
                firstRate = UAHRate;
            
            else if (convertFrom == "RUB")            
                firstRate = RUBRate;
            
            else if (convertFrom == "CNY")            
                firstRate = CNYRate;            

            double secondRate = 0;

            if (convertTo == "USD")           
                secondRate = USDRate;            

            else if (convertTo == "EUR")            
                secondRate = EURRate;            

            else if (convertTo == "UAH")            
                secondRate = UAHRate;            

            else if (convertTo == "RUB")            
                secondRate = RUBRate;            

            else if (convertTo == "CNY")            
                secondRate = CNYRate;            

            double result = firstRate / secondRate * howMuchToConvert;
            return result;
        }
        public void ShowRates()
        {
            System.Console.WriteLine($"1 USD = {USDRate} UAH");
            System.Console.WriteLine($"1 EUR = {EURRate} UAH");
            System.Console.WriteLine($"1 RUB = {RUBRate} UAH");
            System.Console.WriteLine($"1 CNY = {CNYRate} UAH");
        }
    }    
}
