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

        public static double tipoPlan(string prepagoLibre)
        {
            double precio = 0;
            switch (prepagoLibre)
            {
                case "PREPAGO LIBRE":
                    precio = 1.70; 
                    break;
                case "PREPAGO FAMILIA":
                    precio = 1.70; 
                    break;
                case "PLAN WAO":
                    precio = 200; 
                    break;
                case "Plan S a medida":
                    precio = 50; 
                    break;
                case "Plan M a medida":
                    precio = 100; 
                    break;
                case "Plan L a medida":
                    precio = 150; 
                    break; 
            }
            return precio;
        }
    }
}
