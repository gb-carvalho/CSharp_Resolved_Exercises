using System.Globalization;
using System.IO;
using File.Entities;

namespace File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This should be a user input, but i don`t wanna write this
            string root = @"C:\Users\GB\Desktop\Projetos\C# (Udemy)\File";
            string path = $@"{root}\file.txt";
            string path_out = $@"{root}\out\file2.txt";
            try {
                Directory.CreateDirectory(Path.GetDirectoryName(path_out) ?? "");
                FileStream frc = new FileStream(path_out, FileMode.Create);
                frc.Close();

                using (FileStream fsInput = new FileStream(path, FileMode.Open))
                using (FileStream fsOutput = new FileStream(path_out, FileMode.Append))
                using (StreamReader srInput = new StreamReader(fsInput))
                using (StreamWriter swOutput = new StreamWriter(fsOutput))

                {
                    while (!srInput.EndOfStream)
                    {
                        string line = srInput.ReadLine() ?? "";
                        string[] csv_field = line.Split(',');
                        string name = csv_field[0];
                        double price = double.Parse(csv_field[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(csv_field[2]);

                        Product product = new Product(name, price, quantity);   

                        string total_value = product.Total().ToString("F2", CultureInfo.InvariantCulture);
                        swOutput.WriteLine($"{name},${total_value}");

                        Console.WriteLine(line);
                    }
                }


            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}