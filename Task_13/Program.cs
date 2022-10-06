int userInput;

while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out userInput))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

if (userInput < 100)
{
    Console.WriteLine($"{userInput} -> третьей цифры нет");
}

if (userInput > 100)
{
    string S = Convert.ToString(userInput);
    char a = S[2];

    Console.WriteLine($"третья цифра -> {a}");
}