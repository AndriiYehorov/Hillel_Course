
namespace SortingLastNames
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayText("Заполни массив фамилиями!");
            string[] lastNames = ReceiveDataFromUser();
            Array.Sort(lastNames);
            DisplayText("Отсортированный массив : ");
            PrintArray(lastNames);
        }

        private static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        private static string[] ReceiveDataFromUser()
        {
            string[] lastNames = new string[5];
            for (int i = 0; i < lastNames.Length; i++)
            {
                lastNames[i] = Console.ReadLine();
            }
            DisplayText("Неотсортированный массив : ");
            PrintArray(lastNames);
            return lastNames;
        }


        private static void PrintArray(string[] str)
        {
            foreach (string el in str) 
            {
                Console.Write(el+"\t"); 
            }
            Console.WriteLine();
        }
    }
}