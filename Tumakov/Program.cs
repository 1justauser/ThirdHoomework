using System.ComponentModel;
using System.Text;


namespace ThirdHoomework
{
    [Serializable]
    class OutOfRange : Exception
    {
        public OutOfRange() { }

        public OutOfRange(string name)
            : base(String.Format("Ошибка: число должно быть от 1 до 36{0}", name))
        {

        }
    }
    public class Tumakov
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            //Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365(номер дня
            //в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            //февраля(високосный год не учитывать).
            Console.WriteLine("Упражнение 4.1 введите число дня года от 1 до 365");
            Console.WriteLine("Для данного числа будут указаны его месяц и дата");
            DateTime dateDayMonth = new DateTime(2021, 1, 1);
            int daysPassed;
            if (int.TryParse(Console.ReadLine(), out daysPassed))
            {
                if (daysPassed > 365 || daysPassed < 1)
                {
                    Console.WriteLine("Ошибка: число должно быть от 1 до 365");
                }
                else
                {
                    dateDayMonth = dateDayMonth.AddDays(daysPassed - 1);
                    switch (dateDayMonth.Month)
                    {
                        case 1: Console.WriteLine("{0} января", dateDayMonth.Day); break;
                        case 2: Console.WriteLine("{0} февраля", dateDayMonth.Day); break;
                        case 3: Console.WriteLine("{0} марта", dateDayMonth.Day); break;
                        case 4: Console.WriteLine("{0} апреля", dateDayMonth.Day); break;
                        case 5: Console.WriteLine("{0} мая", dateDayMonth.Day); break;
                        case 6: Console.WriteLine("{0} июня", dateDayMonth.Day); break;
                        case 7: Console.WriteLine("{0} июля", dateDayMonth.Day); break;
                        case 8: Console.WriteLine("{0} августа", dateDayMonth.Day); break;
                        case 9: Console.WriteLine("{0} сентября", dateDayMonth.Day); break;
                        case 10: Console.WriteLine("{0} октября", dateDayMonth.Day); break;
                        case 11: Console.WriteLine("{0} ноября", dateDayMonth.Day); break;
                        case 12: Console.WriteLine("{0} декабря", dateDayMonth.Day); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Нужно ввести число");
            }


            //Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            //исключение, и выдавать на экран сообщение.
            Console.WriteLine("Упражнение 4.2 введите число дня года от 1 до 365");
            Console.WriteLine("Для данного числа будут указаны его месяц и дата");
            DateTime dateDayMonthException = new DateTime(2021, 1, 1);
            int daysPassedException;
            if (int.TryParse(Console.ReadLine(), out daysPassedException))
            {
                try
                {
                    if (daysPassedException <= 0 || daysPassedException >= 365)
                    {
                        throw new OutOfRange("5");
                    }
                    dateDayMonthException = dateDayMonthException.AddDays(daysPassedException - 1);
                    switch (dateDayMonthException.Month)
                    {
                        case 1: Console.WriteLine("{0} января", dateDayMonthException.Day); break;
                        case 2: Console.WriteLine("{0} февраля", dateDayMonthException.Day); break;
                        case 3: Console.WriteLine("{0} марта", dateDayMonthException.Day); break;
                        case 4: Console.WriteLine("{0} апреля", dateDayMonthException.Day); break;
                        case 5: Console.WriteLine("{0} мая", dateDayMonthException.Day); break;
                        case 6: Console.WriteLine("{0} июня", dateDayMonthException.Day); break;
                        case 7: Console.WriteLine("{0} июля", dateDayMonthException.Day); break;
                        case 8: Console.WriteLine("{0} августа", dateDayMonthException.Day); break;
                        case 9: Console.WriteLine("{0} сентября", dateDayMonthException.Day); break;
                        case 10: Console.WriteLine("{0} октября", dateDayMonthException.Day); break;
                        case 11: Console.WriteLine("{0} ноября", dateDayMonthException.Day); break;
                        case 12: Console.WriteLine("{0} декабря", dateDayMonthException.Day); break;
                    }
                }
                catch (OutOfRange ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Нужно ввести число");
            }


            //Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            //учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            //год. Однако, если он делится без остатка на 400, это високосный год.)
            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Укажите год");
            int year;
            if (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Ошибка: Нужно ввести число");
            }
            else
            {
                if (year % 4 == 0 && (year % 100 != 0))
                {
                    Console.WriteLine("Введите число дня года от 1 до 366");
                }
                else
                {
                    Console.WriteLine("Введите число дня года от 1 до 365");
                }
                Console.WriteLine("Для данного числа будут указаны его месяц и дата");
                DateTime dateDayMonthLeapYear = new DateTime(year, 1, 1);
                int daysPassedLeapYear;
                if (int.TryParse(Console.ReadLine(), out daysPassedLeapYear))
                {
                    try
                    {
                        if ((year % 4 == 0 && (year % 100 != 0)) && (daysPassedLeapYear <= 0 || daysPassedLeapYear > 366))
                        {
                            throw new OutOfRange("6");
                        }
                        else if (!(year % 4 == 0 && (year % 100 != 0)) && (daysPassedLeapYear <= 0 || daysPassedLeapYear > 365))
                        {
                            throw new OutOfRange("5");
                        }
                        dateDayMonthLeapYear = dateDayMonthLeapYear.AddDays(daysPassedLeapYear - 1);
                        switch (dateDayMonthLeapYear.Month)
                        {
                            case 1: Console.WriteLine("{0} января", dateDayMonthLeapYear.Day); break;
                            case 2: Console.WriteLine("{0} февраля", dateDayMonthLeapYear.Day); break;
                            case 3: Console.WriteLine("{0} марта", dateDayMonthLeapYear.Day); break;
                            case 4: Console.WriteLine("{0} апреля", dateDayMonthLeapYear.Day); break;
                            case 5: Console.WriteLine("{0} мая", dateDayMonthLeapYear.Day); break;
                            case 6: Console.WriteLine("{0} июня", dateDayMonthLeapYear.Day); break;
                            case 7: Console.WriteLine("{0} июля", dateDayMonthLeapYear.Day); break;
                            case 8: Console.WriteLine("{0} августа", dateDayMonthLeapYear.Day); break;
                            case 9: Console.WriteLine("{0} сентября", dateDayMonthLeapYear.Day); break;
                            case 10: Console.WriteLine("{0} октября", dateDayMonthLeapYear.Day); break;
                            case 11: Console.WriteLine("{0} ноября", dateDayMonthLeapYear.Day); break;
                            case 12: Console.WriteLine("{0} декабря", dateDayMonthLeapYear.Day); break;
                        }
                    }
                    catch (OutOfRange ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Нужно ввести число");
                }
            }
        }
    }
}
