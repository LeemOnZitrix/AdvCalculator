namespace AdvCalculator
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Witaj w kalkulatorze, wybierz operację");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Operacje Podstawowe");         
            Console.WriteLine("2. Operacje specjalne");          
        }
        public void BasicMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
        }
        public void AdvancedMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Witaj w operacjach specjalnych");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Silnia");
            Console.WriteLine("2. Sprawdzenie liczby pierwszej");
            Console.WriteLine("3. Potęgowanie");
            Console.WriteLine("4. Średnia z liczb");
        }
    }
}
