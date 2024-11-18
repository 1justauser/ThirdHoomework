using System.ComponentModel;
using System.Text;


namespace ThirdHoomework
{
    enum Langauge
    {  
        cPlus, cSharp, c, python     
    }
    public class Program
    {
        static void Main()
        {
            string LanguageExtender(Langauge langauge)
            {
                switch (langauge)
                {
                    case Langauge.cPlus:
                        return "C++";
                    case Langauge.cSharp:
                        return "C#";
                    case Langauge.c:
                        return "C";
                    case Langauge.python:
                        return "Python";
                    default:
                        return "Кумир";
                }
            }
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            var test1 = Langauge.cSharp;
            //работает
            Console.WriteLine("Я люблю {0}", LanguageExtender(test1));
        }
    }
}
