int userInput;

while (true)
{
    Console.Write("Введите цифру дня недели: ");
    if (int.TryParse(Console.ReadLine(), out userInput))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

if (userInput <= 5)
{
    Console.WriteLine($"{userInput} -> будний день");
}

if (6 <= userInput && userInput <= 7)
{
    Console.WriteLine($"{userInput} -> выходной день");
}

if (userInput > 7)
    Console.WriteLine($"Ошибка ввода!");