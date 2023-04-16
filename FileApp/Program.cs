using System;
using System.IO;

class Notepad
{
    static void Main(string[] args)
    {
        string filePath = "";
        string fileContent = "";
        string input = "";

        Console.WriteLine("Hoşgeldiniz!");

        while (input.ToLower() != "exit")
        {
            Console.WriteLine("Dosya yolu girin veya Yeni dosya oluşturmak için \"new\" yazın:");

            input = Console.ReadLine();

            if (input.ToLower() == "new")
            {
                Console.WriteLine("Dosya adı girin:");
                filePath = Console.ReadLine();
                Console.WriteLine("Dosya içeriğini girin:");
                fileContent = Console.ReadLine();
                File.WriteAllText(filePath, fileContent);
                Console.WriteLine("Dosya kaydedildi!");
            }
            else
            {
                try
                {
                    filePath = input;
                    fileContent = File.ReadAllText(filePath);
                    Console.WriteLine(fileContent);

                    Console.WriteLine("Dosyayı kaydetmek istiyor musunuz? (E/H)");
                    input = Console.ReadLine();

                    if (input.ToLower() == "e")
                    {
                        Console.WriteLine("Dosya içeriğini girin:");
                        fileContent = Console.ReadLine();
                        File.WriteAllText(filePath, fileContent);
                        Console.WriteLine("Dosya kaydedildi!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
