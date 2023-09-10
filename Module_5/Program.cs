using System.Xml.Linq;

namespace Module_5
{
    internal class Program
    {
        static void Main()
        {
            //самостоятельные упражненния для практики по теме "Методы"
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------Главное меню----------");
                Console.WriteLine("Выберите один из вариантов:");
                Console.WriteLine("1. Калькулятор");
                Console.WriteLine("2. Работа со строками");
                Console.WriteLine("3. Поиск максимального числа");
                MainMenuSelect();
            }
        }
        static void MainMenuSelect()
        {
            string selectMain = Console.ReadLine();
            switch (selectMain)
            {
                case "1":
                    Calculator();
                    break;
                case "2":
                    WorkWithString();
                    break;
                case "3":
                    MaxNum();
                    break;
                default:
                    Console.WriteLine("Введен неверный пункт меню, попробуйте еще раз.");
                    Console.ReadLine();
                    break;

            }
        }

        static void Calculator()
        {
            Console.WriteLine("\n----------Калькулятор----------");
            Console.Write("Введите первое число: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.Write("Введите операцию (+, -, *. /): ");
            string operation = Console.ReadLine();
            Console.Write("Введите второе число: ");
            int secondNum = Int32.Parse(Console.ReadLine());
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum == 0) Console.WriteLine("Нельзя делить на ноль!");
                    else result = firstNum / secondNum; ;
                    break;
                default:
                    Console.WriteLine("Введен неверный оператор");
                    break;
            }
            Console.WriteLine("Результат: " + result);
            Console.WriteLine("Нажмите Enter, чтобы вернуться в главное меню.");
            Console.ReadLine();
        }
        static void WorkWithString()
        {
            Console.WriteLine("----------Работа со строками----------");
            Console.WriteLine("Длина строки");
            Console.WriteLine("Введите текст, чтобы узнать количество символов:");
            string text = Console.ReadLine();
            Console.WriteLine($"Количество символов: " + text.Length);

            Console.WriteLine("Нажмите Enter, чтобы вернуться в главное меню.");
            Console.ReadLine();
        }
        static void MaxNum()
        {
            Console.WriteLine("----------Поиск максимального числа из массива----------");
            Console.WriteLine("Сколько чисел будет в массиве?");
            int numCount = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[numCount];
            Console.WriteLine($"Введите {numCount} чисел, после каждого числа нажмите Enter");
            for (int i = 0; i < numCount; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxNum = int.MinValue;
            foreach (int num in nums)
            {
                if (num > maxNum) maxNum = num;
            }
            Console.WriteLine($"Максимальное число в массиве: {maxNum}");

            Console.WriteLine("Нажмите Enter, чтобы вернуться в главное меню.");
            Console.ReadLine();
        }
    }

}