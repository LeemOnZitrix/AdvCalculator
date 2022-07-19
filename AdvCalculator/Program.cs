using AdvCalculator;

Menu menu = new Menu();
Calculator calculator = new Calculator();
MathCalculator mathCalculator = new MathCalculator();  


menu.ShowMainMenu();
int menuSelection = Convert.ToInt32(Console.ReadLine());
switch (menuSelection)
{
    case 1:
        {
            menu.ShowBasicMenu();
            int basicOperationSelection = Convert.ToInt32(Console.ReadLine());
            ColorExtension.WriteLineInfo("Podaj Liczby na których chcesz wykonać operację");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (basicOperationSelection)
            {
                case 1:
                    {
                        ColorExtension.WriteLineInfo("Wynik to");
                        ColorExtension.WriteLineResult(calculator.Add(number1, number2));
                        break;
                    }

                case 2:
                    {
                        ColorExtension.WriteLineInfo("Wynik to");
                        ColorExtension.WriteLineResult(calculator.Subtract(number1, number2));
                        break;
                    }

                case 3:
                    {
                        ColorExtension.WriteLineInfo("Wynik to");
                        ColorExtension.WriteLineResult(calculator.Multiply(number1, number2));
                        break;
                    }
                case 4:
                    {
                        ColorExtension.WriteLineInfo("Wynik to to");
                        ColorExtension.WriteLineResult(calculator.Divide(number1, number2));
                        break;
                    }
            }
            break;
        }
    case 2:
        {
            menu.ShowAdvancedMenu();
            int advancedOperationSelection = Convert.ToInt32(Console.ReadLine());
            switch (advancedOperationSelection)
            {
                case 1:
                    {
                        ColorExtension.WriteLineInfo("Podaj liczbę (różną od zera) z której obliczę silnie");
                        int factorial = Convert.ToInt32(Console.ReadLine());
                        ColorExtension.WriteLineResult(factorial + "! = " + mathCalculator.GetFactorial(factorial));
                        break;

                    }
                case 2:
                    {
                        ColorExtension.WriteLineInfo("Podaj liczbę a ja sprawdzę czy jest pierwsza");
                        int prime = Convert.ToInt32(Console.ReadLine());
                        bool isPrime = mathCalculator.GetPrimeCheck(prime);
                        if (isPrime)
                        {
                            ColorExtension.WriteLineResult("Liczba nie jest pierwsza");
                        }
                        else
                        {
                            ColorExtension.WriteLineResult("Liczba jest pierwsza");
                        }
                        break;
                    }
                case 3:
                    {
                        ColorExtension.WriteLineInfo("Podaj liczbę, oraz do której potęgi chcesz ją spotęgować");
                        int basis = Convert.ToInt32(Console.ReadLine());
                        int exponent = Convert.ToInt32(Console.ReadLine());
                        ColorExtension.WriteLineResult(mathCalculator.GetPower(basis, exponent));
                        break;
                    }
                case 4:
                    {
                        ColorExtension.WriteLineInfo("Podaj ilość liczb a następnie liczby z których oblicze średnią");
                        int numbersCount = Convert.ToInt32(Console.ReadLine());
                        double[] averageArray = new double[numbersCount];
                        for (int i = 0; i < averageArray.Length; i++)
                        {
                            averageArray[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        ColorExtension.WriteLineResult(mathCalculator.GetArrayAverage(averageArray));
                        break;
                    }
                case 5:
                    {
                        ColorExtension.WriteLineInfo("Podaj ilość liczb a następnie liczby z których wskażę najmniejszą i największą");
                        int numbersCount = Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[numbersCount];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        ColorExtension.WriteLineInfo("Wartośc minimalna to");
                        ColorExtension.WriteLineResult(mathCalculator.GetMinNumber(array));
                        ColorExtension.WriteLineInfo("Wartość maksymalna to");
                        ColorExtension.WriteLineResult(mathCalculator.GetMaxNumber(array));
                        break;
                    }
                case 6:
                    {
                        ColorExtension.WriteLineInfo("odczyt plików txt, podaj ścieżke pliku");
                        string text = File.ReadAllText(Console.ReadLine());
                        Console.WriteLine("Zawartość pliku tekstowego = {0}", text);
                        break;
                    }
                case 7:
                    {
                        ColorExtension.WriteLineInfo("zapis zawartości do nowego pliku txt");
                        ColorExtension.WriteLineInfo("Podaj ścieżke zapisu pliku razem z nazwą");
                        string path = Console.ReadLine();
                        ColorExtension.WriteLineInfo("Podaj ilość linijek pliku txt");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        ColorExtension.WriteLineInfo("Podaj zawartość pliku txt");
                        List<string> content = new List<string>();
                        for (int i = 0; i < amount; ++i)
                        {                          
                            content.Add(Console.ReadLine());
                        }
                        File.WriteAllLines(path, content);
                        break;
                    }
            }
            break;
        }
}
