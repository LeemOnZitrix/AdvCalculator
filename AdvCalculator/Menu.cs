namespace AdvCalculator
{
    public class Menu
    {
        public void ShowMainMenu()
        {            
            ColorExtension.WriteLineInfo("Witaj w kalkulatorze, wybierz operację");           
            ColorExtension.WriteLineMenu("1. Operacje Podstawowe");
            ColorExtension.WriteLineMenu("2. Operacje specjalne");          
        }

        public void ShowBasicMenu()
        {
            ColorExtension.WriteLineMenu("1. Dodawanie");
            ColorExtension.WriteLineMenu("2. Odejmowanie");
            ColorExtension.WriteLineMenu("3. Mnożenie");
            ColorExtension.WriteLineMenu("4. Dzielenie");
        }

        public void ShowAdvancedMenu()
        {
            ColorExtension.WriteLineInfo("Witaj w operacjach specjalnych");
            ColorExtension.WriteLineMenu("1. Silnia");
            ColorExtension.WriteLineMenu("2. Sprawdzenie liczby pierwszej");
            ColorExtension.WriteLineMenu("3. Potęgowanie");
            ColorExtension.WriteLineMenu("4. Średnia z liczb");
            ColorExtension.WriteLineMenu("5. Wartośc Minimalna i Maksymalna");
            ColorExtension.WriteLineMenu("6. Odczyt pliku TXT");
            ColorExtension.WriteLineMenu("7. Zapis do pliku txt");
        }  
    }      
}          
           