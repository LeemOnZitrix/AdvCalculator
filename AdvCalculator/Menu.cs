namespace AdvCalculator
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Witaj w kalkulatorze, wybierz operację");
            Console.WriteLine("1. Operacje Podstawowe");         
            Console.WriteLine("2. Operacje specjalne");          
        }
        public void BasicMenu()
        {
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
        }
        public void AdvancedMenu()
        {
            Console.WriteLine("Witaj w operacjach specjalnych");
            Console.WriteLine("1. Silnia");
            
        }
    }
}
