int userInput;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out userInput))
        if (99 < userInput && userInput < 1000)
            break;
    Console.WriteLine($"Ошибка ввода!");
}

int num = userInput % 100;
int num1 = num / 10;
Console.Write($"{userInput} -> {num}");
