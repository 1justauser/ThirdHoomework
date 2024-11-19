using System.Text;


namespace ThirdHomework
{
    enum Check
    {
        Friday, Sunday = 50, Tuesday, Wednesday = 67, Thursday
    }
    public class Tasks
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Check work = Check.Friday;
            work = (Check)1;


            Console.WriteLine("Добрый День!");
            Console.WriteLine((int)Check.Thursday);
        }
    }
}