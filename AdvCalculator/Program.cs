using AdvCalculator;

Menu menu = new Menu();
Calculator calculator = new Calculator();

int operation2 = 0; int operation3 = 0;
int number1 = 0; int number2 = 0;

menu.MainMenu();
Console.ForegroundColor = ConsoleColor.Red;
int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    menu.BasicMenu();
    Console.ForegroundColor = ConsoleColor.Red;
    operation2 = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Podaj Liczby na których chcesz wykonać operację");
    Console.ForegroundColor = ConsoleColor.Red;
    number1 = Convert.ToInt32(Console.ReadLine());
    number2 = Convert.ToInt32(Console.ReadLine());
}

if (operation == 2)
{
    menu.AdvancedMenu();
    operation3 = Convert.ToInt32(Console.ReadLine());
}

if (operation2 == 1)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Wynik to");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(calculator.Add(number1, number2));
}
else if (operation2 == 2)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Wynik to");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(calculator.Subtract(number1, number2));
}
else if (operation2 == 3)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Wynik to");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(calculator.Multiply(number1, number2));
}
else if (operation2 == 4)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Wynik to to");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(calculator.Divide(number1, number2));
}

if (operation3 == 1)
    {
        number2 = 1;
        Console.WriteLine("Podaj liczbę (różną od zera) z której obliczę silnie");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 + "! = " + calculator.Factorial(number1, number2));
                 
    }
if (operation3 == 2)
{
    Console.WriteLine("Podaj liczbę a ja sprawdzę czy jest pierwsza");
    number1 = Convert.ToInt32(Console.ReadLine());
    int isprime = calculator.PrimeCheck(number1);
    if (isprime == 1)
    {
        Console.WriteLine("Liczba nie jest pierwsza");
    }
    else
    {
        Console.WriteLine("Liczba jest pierwsza");
    }
}
if (operation3 == 3)
{
    Console.WriteLine("Podaj liczbę a ja ją spotęguje");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(calculator.Power(number1));
}

if (operation3 == 4)
{
    Console.WriteLine("Podaj ilość liczb a następnie liczby z których oblicze średnią");
    int i = Convert.ToInt32(Console.ReadLine());
    int[] average = new int[i];
}
    
