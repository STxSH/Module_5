using System;

class MainClass
{

    public static void Main(string[] args)
    {
        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        ChangeAge(ref anketa.age);
        Console.WriteLine(anketa.age);

        string[] favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(anketa.name, anketa.age);
        }

        Console.WriteLine("Ваши любимые цвета: ");
        foreach (string color in favcolors)
        {
            Console.WriteLine(color);
        }

        /*
        int nums = 10;

        int[] arrayBeforeSort = GetArrayFromConsole(ref nums);
        Console.WriteLine("\nМассив до сортировки:");
        foreach (int num in arrayBeforeSort)
        {
            Console.WriteLine(num);
        }
        int[] arrayAfterSort = SortArray(arrayBeforeSort);
        Console.WriteLine("\nМассив после сортировки:");
        foreach (int num in arrayAfterSort)
        {
            Console.WriteLine(num);
        }
        */

        /*task 5.2.18, 5.3.8
        var array = GetArrayFromConsole(ref nums);
        ShowArray(array, true);
        */

        Console.ReadKey();
    }
    static string ShowColor(string username, int userage)
    {
        Console.WriteLine($"{username}, {userage} лет \nнапишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }
    static void ShowColors(string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    static int[] GetArrayFromConsole(ref int num)
    {
        var result = new int[num];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива номер {i + 1}");
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedask)
    {
        sorteddesc = SortArrayDesc(array);
        sortedask = SortArrayAsc(array);
    }

    /* 
     * static void ShowArray(int[] array, bool isSorted = false)
    {
        int[] temp = array;

        if (!isSorted)
        {
            temp = SortArray(temp);
        }

        foreach (int num in temp)
        {
            Console.WriteLine(num);
        }
    }
    */

    static int ChangeAge(ref int age)
    {
        age = age * 100;
        return age;
    }
    static int[] SortArrayDesc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }

    static int[] SortArrayAsc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }


}