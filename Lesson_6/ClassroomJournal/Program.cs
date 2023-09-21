
namespace ClassroomJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] physics = InitializeData(10);
            int[] history = InitializeData(10);
            int[] mathematic = InitializeData(10);

            do
            {
                Console.Clear();
                Console.WriteLine((byte)Menu.Fill + ". Fill out the assessments");
                Console.WriteLine((byte)Menu.Average + ". Get average assessments");
                Console.WriteLine((byte)Menu.Show + ". Show current rating");
                Console.WriteLine((byte)Menu.Exit + ". Exit");
                Console.WriteLine("Make your choice:");
                byte elMenu = ReadChoice();
                Console.Clear();
                if (elMenu == (byte)Menu.Exit)
                {
                    break;
                }

                Console.WriteLine((byte)SubMenu.Physics + ". Physics");
                Console.WriteLine((byte)SubMenu.History + ". History");
                Console.WriteLine((byte)SubMenu.Mathematic + ". Mathematic");
                Console.WriteLine((byte)SubMenu.Back + ". Back");
                Console.WriteLine("Make your choice:");

                byte elSubMenu = ReadChoice();
                if ((SubMenu)elSubMenu == SubMenu.Back)
                {
                    continue;
                }

                if ((Menu)elMenu == Menu.Average)
                {
                    AverageGrade(SelectSubject(physics, history, mathematic, elSubMenu));
                }
                else if ((Menu)elMenu == Menu.Fill)
                {
                    GradeInput(SelectSubject(physics, history, mathematic, elSubMenu));
                }
                else
                {
                    DisplayArray(SelectSubject(physics, history, mathematic, elSubMenu));
                }

                Console.ReadKey();
                Console.Clear();
            } while (true);

        }

        private static int[] SelectSubject(int[] physics, int[] history, int[] mathematic, byte elSubMenu)
        {
            if ((SubMenu)elSubMenu == SubMenu.Physics)
            {
                return physics;
            }
            else if ((SubMenu)elSubMenu == SubMenu.History)
            {
                return history;
            }
            else
            {
                return mathematic;
            }
        }

        static byte ReadChoice()
        {
            string enter;
            bool isInputRight;
            byte choice;
            Console.WriteLine("");
            do
            {
                enter = Console.ReadLine();
                isInputRight = byte.TryParse(enter, out choice);
            } while (!isInputRight || choice < (byte)Menu.Exit || choice > (byte)Menu.Show);
            return choice;
        }

        private static void AverageGrade(int[] arr)
        {
            DisplayArray(arr);
            int count = 0;
            float avrg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    avrg += arr[i]; 
                    count++;
                }
                else
                { 
                    break;
                }
            }
            Console.WriteLine("The average score is: {0}", avrg /= count);
        }

        private static void GradeInput(int[] arr)
        {
            DisplayArray(arr);
            string input = Console.ReadLine();
            bool res = int.TryParse(input,out int result);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = result; 
                    break;
                }
            }
            DisplayArray(arr);
            if (ContinueInputingData())
            {
                GradeInput(arr);
            } else
            {
                Console.ReadLine();
            }
        }

        private static bool ContinueInputingData()
        {
            Console.WriteLine("Continue entering data?\n1.Yes\t2.Not");
            string input = Console.ReadLine();
            bool res = int.TryParse(input,out int result);
            switch (result)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                default: ContinueInputingData();
                    break;
            }
            return false;
        }

        private static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Current performance: ");
            foreach (int el in arr)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine();
        }

        private static int[] InitializeData(int lenght)
        {
            Random rnd = new Random();
            int[] arr = new int[lenght];
            for (int i = 0; i <= 3; i++)
            {
                arr[i] = rnd.Next(1,12);
            }
            return arr;
        }
    }
}
