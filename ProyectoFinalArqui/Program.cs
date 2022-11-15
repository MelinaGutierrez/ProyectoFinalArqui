using System;

namespace ProyectoFinalArqui
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Something()
        {
            return "Algo";
        }

        public static bool Login(string user, string pass) =>
            user == "marco" && pass == "12345" ? true : false;
    }
}
