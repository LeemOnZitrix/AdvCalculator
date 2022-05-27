using AdvCalculator;

Menu menu = new Menu();
Calculator calculator = new Calculator();

int operation2 = 0; int operation3 = 0;
int number1 = 0; int number2 = 0;

menu.MainMenu();
int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    menu.BasicMenu();
    operation2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj Liczby na których chcesz wykonać operację");
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
    Console.WriteLine("Wynik to");
    Console.WriteLine(calculator.Add(number1, number2));
}
else if (operation2 == 2)
{   
    Console.WriteLine("Wynik to");
    Console.WriteLine(calculator.Subtract(number1, number2));
}
else if (operation2 == 3)
{
    Console.WriteLine("Wynik to");
    Console.WriteLine(calculator.Multiply(number1, number2));
}
else if (operation2 == 4)
{
    Console.WriteLine("Wynik to to");
    Console.WriteLine(calculator.Divide(number1, number2));
}

if (operation3 == 1)
    {
        number2 = 1;
        Console.WriteLine("Podaj liczbę (różną od zera) z której obliczę silnie");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 + "! = " + calculator.Factorial(number1, number2));
                 
    }
