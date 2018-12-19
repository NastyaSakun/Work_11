using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\0Работа с простыми запросыми:");
            Console.Write("\0Введите длину строки для выборки:\0");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] mounths = {"июнь","июль","август","сентябрь","октябрь","ноябрь", "декабрь", "январь", "февраль", "март", "апрель", "май" };

            var lengthOfMounths = from t in mounths
                                  where t.Length ==count
                                  orderby t
                                  select t;

            var summerAndWinter = mounths.Take(3).Concat(mounths.Skip(6).Except(mounths.Skip(9)));
          
                //from t in mounths
                //where t.Contains("декабрь") || t.Contains("январь") || t.Contains("февраль") || t.Contains("июнь") || t.Contains("июль") || t.Contains("август")

            var alphMounths = mounths.OrderBy(t => t);

            var wordForMounths = mounths.Where(t => t.Length >=4 && t.Contains("ю"));

            Console.WriteLine("\0Вывод элементов нужной длины:");
            foreach (string m1 in lengthOfMounths)
                Console.Write($"{m1}\0");
            Console.WriteLine();

            Console.WriteLine("\0Выводы летних и зимных месяцев:");
            foreach (string m2 in summerAndWinter)
                Console.Write($"{m2}\0");
            Console.WriteLine();

            Console.WriteLine("\0Вывод месяцев в алфавитном порядке:");
            foreach (string m3 in alphMounths)
                Console.Write($"{m3}\0");
            Console.WriteLine();

            Console.WriteLine("\0Вывод месяцев, содержащих нужную букву:");
            foreach (string m4 in wordForMounths)
                Console.Write($"{m4}\0");
            Console.WriteLine();


            Console.WriteLine("\0Работа с массивами:");
                                 
            List<Array> list = new List<Array>();
            list.Add(new Array(1, 7));
            list.Add(new Array(2, 2));
            list.Add(new Array(7, 8, 9));

            for (int i =0; i<list.Count;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{list[i].mas2[j]} \0");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            //var one = list.Where(t => Prov(t) >= 0).Select(t => Prov(t));
            var two = list.Where(t =>Summ(t)!=0).Select(t=>Summ(t));
            var three = list.Where(t => Count(t) != 0).Select(t => Count(t));
                   
            foreach (var mas1 in two)
            {
                Console.Write($"{mas1}\0");
            }
            Console.WriteLine($"\0Массив с максимальной суммой:\0{two.Max()}");

            foreach (var mas2 in three)
            {
                Console.Write($"{mas2}\0");
            }
            Console.WriteLine($"\0Массив с максимальной длиной:\0{three.Max()}");
            Console.WriteLine();


            Console.WriteLine("\0Работа с Join:");

            List<City> teams = new List<City>()
            {
                 new City { Name = "Москва" , Country="Россия"},
                 new City { Name = "Полоцк", Country="Беларусь"}
            };

            List<Player> players = new List<Player>()
            {
                 
                 new Player {Name="Анастасия", City="Полоцк"},
                 new Player {Name="Юлия", City="Москва"}
            };

            var result = players.Join(teams, 
             p => p.City, 
             t => t.Name, 
             (p, t) => new { Name = p.Name, Team = p.City});

            foreach (var item in result)
                Console.WriteLine("\0{0} - {1}", item.Name, item.Team);
        }

        public static int Summ(Array t)
        {
            int sum = 0;

            for (int i = 0; i < t.mas2.Length; i++)
            {
                sum += t.mas2[i];
            }

            return sum;
        }

        public static int Count(Array t)
        {
            int c;

            c=t.mas2.Count();
            return c;
        }

        public static int Prov(Array t)
        {
            int s=0;
            for (int i = 0; i < t.mas2.Length; i++)
            {
                s = t.mas2[i]%2;
            }

            return s;
        }
    }
}
