using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions;

public static class StringExtension
{
    public static int CharCount(this string strings, char letter)
    {
        int count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i] == letter)
                count++;
        }
        return count;
    }
    public static int EvenOrOdd(this int check)
    {
        check = check % 2;
        return check;
    }
    public static string Number(this string number)
    {
        Regex regex1 = new(@"^7\d{10}$");
        Regex regex2 = new(@"^8\d{10}$");
        Regex regex3 = new(@"^\+7\d{10}$");
        if (regex1.IsMatch(number))
        {
            Console.WriteLine();
            Console.WriteLine($"Номер корректен");
            Console.WriteLine();
        }
        else if (regex2.IsMatch(number))
        {
            number = "7" + number.Remove(0, 1);
            Console.WriteLine();
            Console.WriteLine("Номер некорректный, так как введён с 8. Номер после преобразования: ");
            Console.WriteLine(number);
            Console.WriteLine();
        }
        else if (regex3.IsMatch(number))
        {
            number = "7" + number.Remove(0, 2);
            Console.WriteLine();
            Console.WriteLine("Номер некорректный, так как введён с +7. Номер после преобразования: ");
            Console.WriteLine(number);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Номер не корректный");
        }
        return number;
    }
}
