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
        Regex regex = new Regex(@"[8]\d{10}$");
        Regex regex1 = new Regex(@"[+7]\d{10}$");
        if (regex.IsMatch(number))
        {        
            Console.WriteLine();
            Console.WriteLine("Номер введён некорректно");
            Console.WriteLine(number.Replace('8','7'));
            Console.WriteLine();
            return number;
        }
        else if (regex1.IsMatch(number))
        {
            number = number.Replace('+', ' ');
            var i = number.ToList();
            if (i.First() == '7')
            {
                i[0] = '8';
            }
            number = i.ToString();
            Console.WriteLine();
            Console.WriteLine("Номер введён некорректно");
            Console.WriteLine(number);
            Console.WriteLine();
            return number;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Номер введён корректно");
            Console.WriteLine();
        }
        return number;
    }
}
