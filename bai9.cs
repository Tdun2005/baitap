//a
using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Nhập một chuỗi ký tự: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
    }
}
//b
using System;

class WordCount
{
    static void Main()
    {
        Console.Write("Nhập một chuỗi ký tự: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int wordCount = words.Length;

        Console.WriteLine("Số lượng từ trong chuỗi: " + wordCount);
    }
}
