using System.Text;
using System.Text.RegularExpressions;


namespace ThirdHomework
{
    public class Tasks
    {
        [Serializable]
        class ParseError : Exception
        {
            public ParseError() { }

            public ParseError(string name)
                : base(String.Format("Ошибка: необходимо ввести число в пределах от 0 до 256", name))
            {

            }
        }


        [Serializable]
        class OutOfRange : Exception
        {
            public OutOfRange() { }

            public OutOfRange(string name)
                : base(String.Format("Ошибка: число должно быть от 6 до 14 включительно", name))
            {

            }
        }


        enum Week
        {
            понедельник = 1, вторник = 2, среда = 3, четверг = 4,
            пятница = 5, суббота = 6, воскресенье = 7,
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            void StartTask(int n)
            {
                Console.WriteLine("\n\nЗадача {0}", n);
            }



            //1.Дана последовательность из 10 чисел.Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.
            Console.WriteLine("Необходимо указать последовательность из 10 чисел, чтобы проверить упорядоченная ли она по возрастанию");
            double[] Subsequence = new double[10];
            bool parse_Error = false, is_Ordered = true;
            for (int i = 0; i < Subsequence.Length; i++)
            {
                Console.WriteLine("Введите {0} число", i + 1);
                if (!double.TryParse(Console.ReadLine(), out Subsequence[i]))
                {
                    Console.WriteLine("Ошибка: Нужно ввести число");
                    parse_Error = true;
                    break;
                }
            }
            for (int i = 0; i < Subsequence.Length - 1; i++)
            {
                if (Subsequence[i] > Subsequence[i + 1])
                {
                    Console.Write("{0} число больше чем {1}, поэтому ", i + 1, i + 2);
                    Console.WriteLine("эта последовательность не упорядоченна по возрастанию");
                    is_Ordered = false;
                    break;
                }
            }
            if (is_Ordered && !parse_Error)
            {
                Console.WriteLine("Последовательность упорядоченна");
            }


            //2.Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally
            StartTask(2);
            Console.WriteLine("Укадите порядковый номер достоинства от 6 до 14 включительно, чтобы определить карту");
            byte ordinalNumber;
            string[] ordinalCards = {"шестерка", "семерка", "восьмерка", "девятка", "десятка",
            "валет","дама","король","туз",};
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out ordinalNumber))
                {
                    throw new ParseError("");
                }
                else if (ordinalNumber <= 14 && ordinalNumber >= 6)
                {
                    Console.WriteLine("Ваша карта : {0}", ordinalCards[ordinalNumber - 6]);
                }
                else
                {
                    throw new OutOfRange("");
                }
            }
            catch (ParseError ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfRange ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение алгоритма");
            }


            //3.Напишите программу, которая принимает на входе строку и производит выходные
            //данные в соответствии со следующей таблицей:
            StartTask(3);
            Console.WriteLine("Укажите кто вы, чтобы программа указала напиок");
            string entity = Console.ReadLine();
            entity = Regex.Replace(entity, @"\s+", "");
            switch (entity.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "schoolcounselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }


            //4.Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
            //...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            //Использовать enum
            //byte weekDay;
            //if (byte.TryParse(Console.ReadLine(), out weekDay))
            //{
            //    DateTime weekDate = DateTime.Now.AddDays((7 + weekDay - 3) % 7);
            //    Console.WriteLine(weekDate.DayOfWeek);
            //} решение без enum
            StartTask(4);
            byte weekDay;
            if (byte.TryParse(Console.ReadLine(), out weekDay))
            {
                if (weekDay < 8 && weekDay > 0)
                {
                    Console.WriteLine((Week)weekDay);
                }
                else
                {
                    Console.WriteLine("Номер недели должен быть от 1 до 7");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: необходимо ввести число в пределах от 0 до 256");
            }


            //5.Создать массив строк. При помощи foreach обойти весь массив.При встрече элемента
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.
            StartTask(5);
            string[] dolls = { "Hello Kitty", "Hello Kit", "Hello Kitty", "Barbie doll", "Barbll", "dasdsad" };
            List<string> bag = new List<string>();
            foreach (string doll in dolls)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                {
                    bag.Add(doll);
                }
            }
            Console.WriteLine("Количество Кукол в сумке {0}", bag.Count);
        }
    }
}