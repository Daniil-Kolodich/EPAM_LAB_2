using System;
using System.IO;
/*
    Вариант 7
    Проверка матрицы на симметричность относительно главное диагонали 
 */
namespace _Matrix {
    class Program {
        static void Main(string[] args) {
            string[] stringInput = GetDataFromFile();
            int size = int.Parse(stringInput[0]);
            int[,] array = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    array[i, j] = int.Parse(stringInput[i * size + j + 1]);

            bool error = false;
            for (int i = 0; i < size && !error; i++)
                for (int j = 0; j < size && !error; j++)
                    error = array[i, j] != array[j, i];

            WriteDataToFile(error);
            Console.WriteLine(error);
        }
        public static void WriteDataToFile(bool error) {
            string path = Environment.CurrentDirectory + @"\output.txt";
            string result = error ? "N" : "Y";
            StreamWriter writer = new StreamWriter(path);
            writer.Write(result);
            writer.Close();
        }

        public static string[] GetDataFromFile() {
            string path = Environment.CurrentDirectory + @"\input.txt";
            StreamReader reader = new StreamReader(path);
            string result = reader.ReadToEnd();
            reader.Close();
            return result.Split(new char[] { '\n', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
