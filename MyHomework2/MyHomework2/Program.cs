namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            int mean;
            Console.Write("Введите минимальную температуру за сутки: ");
            int min_temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            int max_temp = Convert.ToInt32(Console.ReadLine());
            mean = (min_temp + max_temp)/2;
            Console.WriteLine($"Среднесуточная температура равна { mean}.");


            //2 задание
            Console.Write("Введите порядковый номер текущего месяца: ");
            int num_month = Convert.ToInt32(Console.ReadLine());
            switch (num_month)
            {

                case 1:
                    Console.WriteLine("Введённый порядковый номер месяца- январь ");
                    break;

                case 2:
                    Console.WriteLine("Введённый порядковый номер месяца- фераль ");
                    break;

                case 3:
                    Console.WriteLine("Введённый порядковый номер месяца- март ");
                    break;

                case 4:
                    Console.WriteLine("Введённый порядковый номер месяца- апрель ");
                    break;

                case 5:
                    Console.WriteLine("Введённый порядковый номер месяца- май ");
                    break;

                case 6:
                    Console.WriteLine("Введённый порядковый номер месяца- июнь ");
                    break;

                case 7:
                    Console.WriteLine("Введённый порядковый номер месяца- июль ");
                    break;

                case 8:
                    Console.WriteLine("Введённый порядковый номер месяца- август");
                    break;

                case 9:
                    Console.WriteLine("Введённый порядковый номер месяца- сентябрь ");
                    break;

                case 10:
                    Console.WriteLine("Введённый порядковый номер месяца- октябрь ");
                    break;

                case 11:
                    Console.WriteLine("Введённый порядковый номер месяца- ноября ");
                    break;

                case 12:
                    Console.WriteLine("Введённый порядковый номер месяца- декабрь ");
                    break;

                default:
                    Console.WriteLine("Неверно введено число ");
                    break;

            }


            //3 задание
            if (num_month%2 ==0)
            {
                Console.WriteLine("Порядковый номер месяца является чётным");
            }
            else
            {
                Console.WriteLine("Порядковый номер месяца является нечётным");
            }



            //4 задание
            string shop = " Магнит";
            DateTime n_data = DateTime.Now;
            string name_seller = "Иван Кукушкин";
            int tomato = 40;
            int garlic = 10;
            int bread = 23;
            int summ = tomato+garlic+bread;
            Console.WriteLine($"-----------------{shop}---------------");
            Console.WriteLine($"{DateTime.Now}------{name_seller}");
            Console.WriteLine($"1.Томаты-------------------------{tomato}руб.");
            Console.WriteLine($"2.Чеснок-------------------------{garlic}руб.");
            Console.WriteLine($"3.Хлеб---------------------------{bread}руб.");
            Console.WriteLine($"Итог-----------------------------{summ}руб.");



            //5 задание
            if ((num_month==12 || num_month<3) && mean>0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine("Холодная зима");
            }









        }
    }
}