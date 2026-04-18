class Program
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.Write("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите оператор (+, -, *, /): ");
        op = Console.ReadLine()[0];

        Console.Write("Введите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;
            case '/':
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
                break;
        }
    }
}
