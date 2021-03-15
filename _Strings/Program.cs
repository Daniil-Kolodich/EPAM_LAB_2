using System;
using System.IO;
namespace _Strings {
    class Program {
        static void Main(string[] args) {
            string[] stringInput = GetDataFromFile();
            int minLength = int.Parse(stringInput[^1]);

            int result = 0;
            stringInput = stringInput[..^1];
            foreach (string str in stringInput) {
                string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                    if (word.Length >= minLength)
                        result++;
            }

            WriteDataToFile(result);
        }
        public static void WriteDataToFile(int num) {
            string path = Environment.CurrentDirectory + @"\output.txt";
            StreamWriter writer = new StreamWriter(path);
            writer.Write(num == 0 ? -1 : num);
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
