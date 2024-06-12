using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Nhập tên tệp từ bàn phím
        Console.Write("Nhập tên tệp: ");
        string fileName = Console.ReadLine();

        // Nhập nội dung từ bàn phím
        Console.WriteLine("Nhập nội dung muốn ghi vào tệp (nhập dòng trống để kết thúc):");
        string content = "";
        string line;
        while ((line = Console.ReadLine()) != "")
        {
            content += line + Environment.NewLine;
        }

        // Ghi nội dung vào tệp
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine($"Nội dung đã được ghi vào tệp {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi vào tệp: {ex.Message}");
            return;
        }

        // Đọc nội dung từ tệp và hiển thị lên màn hình
        try
        {
            string readContent = File.ReadAllText(fileName);
            Console.WriteLine($"Nội dung trong tệp {fileName} là:");
            Console.WriteLine(readContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc tệp: {ex.Message}");
        }
    }
}
