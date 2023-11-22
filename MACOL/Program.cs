namespace MACOL
{
    internal class Program
    {
        //        Minimal Absurd Continius Operators Language

        //        все операторы - символы
        //        все переменные - текст
        //        типы данных текст - резеврированные слова

        //любая длина переменных

        //типы данных:
        //s - string
        //c - char
        //i - int
        //f - float


        //функция
        //^имя,вывод:ввод:код^

        //вызов
        //результат.имя.аргумент.аргумент

        //^main, iout:sarg:out= -1 ^.main


        //// вывод в памяти
        //ia=1,ib=2,ic=a+b

        //сама программа имеет аргументы

        static void Main(string[] args)
        {

            Interpreter interpreter = new Interpreter();

            interpreter.ProcessCode("=200w0=100c0c1");
        }
    }
}