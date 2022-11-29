using Extensions;
Console.WriteLine("Menu");
Console.WriteLine();
Console.WriteLine("1. Количество букв в слове");
Console.WriteLine("2. Чёткое, не чёткое");
Console.WriteLine("3. Номер телефона");
string menu = Console.ReadLine();
bool parse = int.TryParse(menu, out var selected);
if (parse)
{
    switch (selected)
    {
        case 1:
            CountLetter();
            break;

        case 2:
            EvenOrOdd();
            break;

        case 3:
            Number();
            break;
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Ошибка");
    Console.WriteLine();
}
void CountLetter()
{
    Console.WriteLine("Введите слово");
    string strings = Console.ReadLine();
    Console.WriteLine("Введите букву");
    string letter = Console.ReadLine();
    bool parse = char.TryParse(letter, out var letters);
    if (parse)
    {
        int result = strings.CharCount(letters);
        if (result >= 3)
        {
            Console.WriteLine();
            Console.WriteLine("Буква встречается часто");
            Console.WriteLine();
            return;
        }
        else if (result < 3 && result >= 1)
        {
            Console.WriteLine();
            Console.WriteLine("Буква встречается редко");
            Console.WriteLine();
            return;
        }
        else if (result == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Буква не встречается");
            Console.WriteLine();
            return;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
    }
}
void EvenOrOdd()
{
    Console.WriteLine();
    Console.WriteLine("Введите число");
    Console.WriteLine();
    string evenOrOdd = Console.ReadLine();
    bool parse = int.TryParse(evenOrOdd, out var selected);
    if (parse)
    {
        int result = selected.EvenOrOdd();

        if (result % 2 == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Число нечёткое");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Число чёткое");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
    }
}
void Number()
{
    Console.WriteLine("Введите номер телефона");
    string number = Console.ReadLine();
    number.Number();
}