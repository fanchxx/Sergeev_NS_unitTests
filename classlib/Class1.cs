namespace classlib
{
    public class classochek
    {
        private List<string> list = new List<string>();
        public double Temp(double a, string b)
        {
            if (b == "c")
            {
                double result = (a * 9 / 5) + 32;
                result = Math.Round(result, 2);
                list.Add($"Из цельсия в фаренгейты: {a} -> {result}");
                return result;
            }
            else
            {
                double result = (a - 32) * 5 / 9;
                result = Math.Round(result, 2);
                list.Add($"Из фаренгейтов в цельсия: {a} -> {result}");
                return result;
            }
        }
        public double Lenght(double a, string b)
        {
            if (b == "s")
            {
                double result = a / 2.1336;
                result = Math.Round(result, 2);
                list.Add($"Из метров в сажени: {a} -> {result}");
                return result;
            }
            else
            {
                double result = a * 2.1336 ;
                result = Math.Round(result, 2);
                list.Add($"Из саженей в метры: {a} -> {result}");
                return result;
            }
        }
        public double Weight(double a, string b)
        {
            if (b == "kg")
            {
                double result = a * 2.2046;
                result = Math.Round(result, 2);
                list.Add($"Из кг в фунты: {a} -> {result}");
                return result;
            }
            else
            {
                double result = a / 2.2046;
                result = Math.Round(result, 2);
                list.Add($"Из фунтов в кг: {a} -> {result}");
                return result;
            }
        }
        public List<string> GetHistory()
        {
            return list;
        }
        public void ClearHistory()
        {
            list.Clear();
        }
    }
}
