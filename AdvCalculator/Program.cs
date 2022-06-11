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
    ColorExtension.WriteLineInfo("Podaj Liczby na których chcesz wykonać operację");
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
    ColorExtension.WriteLineInfo("Wynik to");
    ColorExtension.WriteLineResult(calculator.Add(number1, number2));
}
else if (operation2 == 2)
{
    ColorExtension.WriteLineInfo("Wynik to");
    ColorExtension.WriteLineResult(calculator.Subtract(number1, number2));
}
else if (operation2 == 3)
{
    ColorExtension.WriteLineInfo("Wynik to");
    ColorExtension.WriteLineResult(calculator.Multiply(number1, number2));
}
else if (operation2 == 4)
{
    ColorExtension.WriteLineInfo("Wynik to to");
    ColorExtension.WriteLineResult(calculator.Divide(number1, number2));
}

if (operation3 == 1)
    {
        number2 = 1;
        ColorExtension.WriteLineInfo("Podaj liczbę (różną od zera) z której obliczę silnie");
        number1 = Convert.ToInt32(Console.ReadLine());
        ColorExtension.WriteLineResult(number1 + "! = " + calculator.Factorial(number1, number2));
                 
    }
if (operation3 == 2)
{
    ColorExtension.WriteLineInfo("Podaj liczbę a ja sprawdzę czy jest pierwsza");
    number1 = Convert.ToInt32(Console.ReadLine());
    bool isprime = calculator.PrimeCheck(number1);
    if (isprime == true)
    {
        ColorExtension.WriteLineResult("Liczba nie jest pierwsza");
    }
    else
    {
        ColorExtension.WriteLineResult("Liczba jest pierwsza");
    }
}
if (operation3 == 3)
{
    ColorExtension.WriteLineInfo("Podaj liczbę a ja ją spotęguje");
    number1 = Convert.ToInt32(Console.ReadLine());
    ColorExtension.WriteLineResult(calculator.Power(number1));
}

if (operation3 == 4)
{
    ColorExtension.WriteLineInfo("Podaj ilość liczb a następnie liczby z których oblicze średnią");
    int numberscount = Convert.ToInt32(Console.ReadLine());
    double[] averagearray = new double[numberscount];
    for (int i = 0; i < averagearray.Length; i++)
    {
        averagearray[i] = Convert.ToDouble(Console.ReadLine());
    }
    ColorExtension.WriteLineResult(calculator.Arrayaverage(numberscount, averagearray));
    
}
if (operation3 == 5)
{
    ColorExtension.WriteLineInfo("Podaj ilość liczb a następnie liczby z których wskażę najmniejszą i największą");
    int numberscount = Convert.ToInt32(Console.ReadLine());
    int[] arrayminmax = new int[numberscount];
    for (int i = 0; i < arrayminmax.Length; i++)
    {
        arrayminmax[i] = Convert.ToInt32(Console.ReadLine());
    }
    ColorExtension.WriteLineInfo("Wartośc minimalna to");
    ColorExtension.WriteLineResult(calculator.findMin(arrayminmax));
    ColorExtension.WriteLineInfo("Wartość maksymalna to");
    ColorExtension.WriteLineResult(calculator.findMax(arrayminmax)); 





}
    
