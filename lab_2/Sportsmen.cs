using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    struct Sportsmen
    {
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Sport { get; set; }
        public int BirthdayYear { get; set; }
        public int Hight { get; set; }

        public Sportsmen(string[] data)
        {
            LastName = data[0];
            Gender = data[1];
            Sport = data[2];

            try
            {
                BirthdayYear = int.Parse(data[3]);
            }
            catch
            {
                Console.WriteLine("Не удалось считать день рождения!");
                Console.ReadKey();

                BirthdayYear = 0;
            }

            try
            {
                Hight = int.Parse(data[4]);
            }
            catch
            {
                Console.WriteLine("Произошла считать рост!");
                Console.ReadKey();

                Hight = 0;
            }
        }

        public void ReadInfo()
        {
            Console.WriteLine("Введите фамилию: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Введите пол: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Введите вид спорта: ");
            Sport = Console.ReadLine();
            Console.WriteLine("Введите год рождения: ");
            do
            {
                try
                {
                    BirthdayYear = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка чтения, введите целое число");
                }
            } while (true);
            Console.WriteLine("Введите рост: ");
            do
            {
                try
                {
                    Hight = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка чтения, введите целое число");
                }
            } while (true);

        }

        public static bool operator ==(Sportsmen first, Sportsmen second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Sportsmen first, Sportsmen second)
        {
            return !first.Equals(second);
        }
    }
}
