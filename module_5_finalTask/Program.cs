namespace module_5_finalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Анкета пользователя-----\n");
            var userProfile = CreateUserProfile();
            ShowUserProfile(userProfile);

            Console.ReadKey();
        }
        static (string, string, int, bool, string[], int, string[]) CreateUserProfile()
        {
            (string name, string lastName, int age, bool havePet, string[] petNames, int favColorsCount, string[] favColors) user;
            Console.WriteLine("Введите данные пользователя:\n");
            user.name = CheckInput("Имя: ");
            user.lastName = CheckInput("Фамилия: ");
            user.age = CheckNum("Возраст: ");
            user.petNames = GetPetNames();
            user.havePet = user.petNames.Length > 0 ? true : false;
            user.favColorsCount = CheckNum("Количество любимых цветов: ");
            Console.WriteLine("Любимые цвета:");
            user.favColors = GetFavColors(user.favColorsCount);

            return user;
        }
        static string CheckInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));
            return input;

        }
        static int CheckNum(string prompt)
        {
            int num;
            do
            {
                string input = CheckInput(prompt);

                if (int.TryParse(input, out num) && num > 0)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            } while (true);
        }
        static string[] GetPetNames()
        {
            Console.WriteLine("Введите клички питомцев через запятую, или нажмите Enter, если нет питомцев:");
            string petNamesInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(petNamesInput))
            {
                return new string[0];
            }
            string[] petNames = petNamesInput.Split(',');
            for (int i = 0; i < petNames.Length; i++)
            {
                petNames[i] = petNames[i].Trim();
            }
            return petNames;
        }
        static string[] GetFavColors(int count)
        {
            string[] favcolors = new string[count];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = CheckInput($"Цвет {i + 1}: ");
            }
            return favcolors;
        }
        static void ShowUserProfile((string name, string lastName, int age, bool havePet, string[] petNames, int favColorsCount, string[] favColors) user)
        {
            Console.WriteLine("\n-Данные пользователя-");
            Console.WriteLine($"Имя: {user.name}");
            Console.WriteLine($"Фамилия: {user.lastName}");
            Console.WriteLine($"Возраст: {user.age}");
            Console.WriteLine($"Есть питомцы: {user.havePet}");
            if (user.havePet)
            {
                Console.WriteLine($"Имена питомцев: {string.Join(", ", user.petNames)}");
            }
            Console.WriteLine($"Количество любимых цветов: {user.favColorsCount}");
            Console.WriteLine($"Любимые цвета: {string.Join(", ", user.favColors)}");
        }
    }
}