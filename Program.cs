using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string rnd_psw = "1234567890QWERTYUIOPASDFGHJKLMNBVCXZ";
            int pass_lenght;
            Random rnd = new Random();

            Console.WriteLine("\t\t\t\t###Типа дофига крутой генератор паролей!!###");

            while (true)
            {

                Console.Write("Введите длинну пароля:");
                pass_lenght = Convert.ToInt32(Console.ReadLine());

                string Pass = "";
                for (int i = 0; i < pass_lenght; i++)
                {
                    Pass = Pass + rnd_psw[rnd.Next(0, rnd_psw.Length)];
                }

                Console.WriteLine("Ваш пароль:{0}", Pass);
                Console.WriteLine("Повторить? y/n");
                if (Console.ReadKey(true).Key != ConsoleKey.Y)
                    break;
            }
        }



    }
}
