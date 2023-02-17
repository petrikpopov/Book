using System;
namespace IndexBook10._02._2023HM
{
    public class Book
    {
        public string NameD;
        public string[] mass = new string[5];
        public Book()
        {

            mass[0] = Console.ReadLine();
        }
        public Book(string a, string Name)
        {

            mass[0] = a;
        }
        public void Еnter()
        {

            Array.Resize(ref mass, mass.Length + 1);
            Console.WriteLine("Введите название книги: ");
            mass[mass.Length - 1] = Console.ReadLine();
        }
        public void Print()
        {
            for (int i = 0; i < mass.Length; i++)
            {

                Console.Write("{0}\t", mass[i]);

            }
            Console.WriteLine();
        }
        public void EnterD()
        {
            Console.WriteLine("Введите название вниги которое хотите удалить:\t");
            NameD = Convert.ToString(Console.ReadLine());
            for (int i =0; i<mass.Length; i++)
            {
                if (NameD!=mass[i])
                {
                    Console.WriteLine("такой книги нету");
                }
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < mass.Length)
                {
                    return mass[index];
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 0 && index < mass.Length)
                {
                    mass[index] = value;
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
        }

    }
}

