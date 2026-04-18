class Program
{
    static void Main()
    {
        double num1, num2, result = 0;
        char op;

        Console.WriteLine("===== Калькулятор =====");

        // Проверка первого числа
        Console.Write("Введите первое число: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
            Console.Write(" Ошибка! Введите число: ");

        // Ввод оператора
        Console.Write("Введите оператор (+, -, *, /): ");
        op = Console.ReadLine()[0];

        // Проверка второго числа
        Console.Write("Введите второе число: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
            Console.Write(" Ошибка! Введите число: ");

        // Вычисление с проверкой деления на ноль
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine(" Ошибка: Деление на ноль!");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine(" Ошибка: Неверный оператор!");
                return;
        }

        Console.WriteLine($" {num1} {op} {num2} = {result}");
        Console.ReadKey();
    }
}
