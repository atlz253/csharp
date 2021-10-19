using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_2
{
    class Program
    {
        static void ReadFile(string fname, LinkedList<Sportsmen> sportsmen)
        {
            if (File.Exists(fname))
            {
                string[] lines = File.ReadAllLines(fname);

                foreach (string line in lines)
                    sportsmen.AddLast(new Sportsmen(line.Split(null, 5)));
            }
            else
            {
                using (File.CreateText(fname)) { }
            }
        }

        static void WriteFile(string fname, LinkedList<Sportsmen> list)
        {
            if (File.Exists(fname))
            {
                int i = 0;
                string[] temp = new string[list.Count()];
                string temp_string;

                foreach (Sportsmen man in list)
                {
                    temp_string = man.LastName + ' ' + man.Gender + ' ' + man.Sport + ' ' + man.BirthdayYear + ' ' + man.Height;
                    temp[i] = temp_string;
                    i++;
                }
                File.WriteAllLines(fname, temp);
            }
            else
            {
                using (File.CreateText(fname)) { }
            }

        }

        static void Main(string[] args)
        {
            string file_name;
            LinkedList<Sportsmen> list = new LinkedList<Sportsmen>();

            Console.WriteLine("Введите имя файла:");
            file_name = Console.ReadLine();
            if (file_name.Length == 0)
                return;
            Console.Clear();

            ReadFile(file_name, list);
            Menu.Init(list);
            WriteFile(file_name, list);
        }
    }
}
