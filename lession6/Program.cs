using System;

class Program
{
    static void Main()
    {
        string kirish = Console.ReadLine();
        string natija = TopTakrorlanadiganBelgi(kirish);
        Console.WriteLine(natija);
    }

    static string TopTakrorlanadiganBelgi(string kirish)
    {
        char previousChar = '\0';
        int count = 0;
        string result = "";

        foreach (char character in kirish)
        {
            if (character == previousChar)
            {
                count++;
            }
            else
            {
                if (count > 0)
                {
                    result += $"'{previousChar}' {count} marta kiritildi, ";
                }
                previousChar = character;
                count = 1;
            }
        }

        if (count > 0)
        {
            result += $"'{previousChar}' {count} marta kiritildi";
        }

        return result;
    }
}
