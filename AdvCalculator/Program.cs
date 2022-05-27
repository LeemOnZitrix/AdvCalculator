using AdvCalculator;

Menu Menu = new Menu();


Menu.MainMenu();
int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    Console.WriteLine("Wybierz na klawiaturze pierwszą liczbę");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wybierz na klawiaturze drugą liczbę");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wynik to");
    Console.WriteLine(Calc.Add(number1, number2));
}
else if (operation == 2)
{
    Console.WriteLine("Wybierz na klawiaturze pierwszą liczbę");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wybierz na klawiaturze drugą liczbę");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wynik to");
    Console.WriteLine(Calc.Subtract(number1, number2));
}
else if (operation == 3)
{
    Console.WriteLine("Wybierz na klawiaturze pierwszą liczbę");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wybierz na klawiaturze drugą liczbę");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wynik to");
    Console.WriteLine(Calc.Multiply(number1, number2));
}
else if (operation == 4)
{
    Console.WriteLine("Wybierz na klawiaturze pierwszą liczbę");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wybierz na klawiaturze drugą liczbę");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wynik to to");
    Console.WriteLine(Calc.Divide(number1, number2));
}
else if (operation == 5)
{
    Console.WriteLine("Witaj w operacjach specjalnych");
    Console.WriteLine("1. Silnia");
    Console.WriteLine("2. Sprawdzenie czy liczba jest doskonała");
    Console.WriteLine("3. Potęgowanie");
    Console.WriteLine("4. Średnia z liczb");
    Console.WriteLine("5. Największa i najmniejsza liczba");
    int op2 = Convert.ToInt32(Console.ReadLine());
    if (op2 == 1)
    {
        int num; int y = 1;
        Console.WriteLine("Podaj liczbę (różną od zera) z której obliczę silnie");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine(" 1! = 1");
                }
        else
        {
            while (num != 1)
            {
                y = y * num;
                num = num - 1;
            }
            Console.WriteLine(y);
        }
       
        
    
    }
    if (op2 == 2)
            {
        Console.WriteLine ("Podaj liczbę a ja sprawdzę czy jest doskonała");
    }
}