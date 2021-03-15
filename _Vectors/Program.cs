using System;
using System.IO;
/*
    Вариант 7
    Подсчёт количества нечётных элементов массива чисел 
 */
namespace _Vectors {
    class Program {
        static void Main(string[] args) {
            //WriteDataInFile();
            string[] data = GetDataFromFile();
            int result = 0;
            try {
                foreach (string str in data)
                    result += int.Parse(str) % 2 == 1 ? 1 : 0;
            }
            catch(FormatException){
                Console.WriteLine("Wrong input\n");
            }
            WriteDataToFile(result);
        }

        public static void WriteDataToFile(int result) {
            string path = Environment.CurrentDirectory + @"\output.txt";
            StreamWriter writer = new StreamWriter(path);
            writer.Write(result);
            writer.Close();
        }

        public static string[] GetDataFromFile() {
            string path = Environment.CurrentDirectory + @"\input.txt";
            StreamReader reader = new StreamReader(path);
            string result = reader.ReadToEnd();
            reader.Close();
            return result.Split(new char[] { '\n', ' ', '\r' },StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
