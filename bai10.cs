using System;

struct Student
{
    public string Name;
    public double Score;

    public Student(string name, double score)
    {
        Name = name;
        Score = score;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];
        double totalScore = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");

            Console.Write("Tên: ");
            string name = Console.ReadLine();

            Console.Write("Điểm: ");
            double score = double.Parse(Console.ReadLine());

            students[i] = new Student(name, score);
            totalScore += score;
        }

        Console.WriteLine("\nThông tin của các sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Tên: {student.Name}, Điểm: {student.Score}");
        }

        double averageScore = totalScore / n;
        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore:F2}");
    }
}
