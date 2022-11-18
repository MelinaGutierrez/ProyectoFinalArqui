using System;

namespace ProyectoFinalArqui
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static double tipoPlan(string tipoPlan)
        {
            double precio = 0;
            switch (tipoPlan)
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

        public static double cobroAddons(string plan, string tipoAddon)
        {
            double precio = 0; 
            if (plan == "Plan S a medida" || plan == "Plan M a medida" || plan == "Plan L a medida")
            {
                switch (tipoAddon)
                {
                    case "DATOS XS":
                        precio = 10; 
                        break;
                    case "DATOS S":
                        precio = 33; 
                        break;
                    case "DATOS M":
                        precio = 82; 
                        break;
                    case "DATOS L":
                        precio = 112; 
                        break;
                    case "DATOS XL":
                        precio = 212; 
                        break;
                    case "DATOS XXL":
                        precio = 353; 
                        break;
                }
            }
            return precio;
        }
        public static double cantidadAddons(string plan, string tipoAddon)
        {
            double cantidad = 0; 
            if (plan == "Plan S a medida" || plan == "Plan M a medida" || plan == "Plan L a medida")
            {
                switch (tipoAddon)
                {
                    case "DATOS XS":
                        cantidad = 400; 
                        break;
                    case "DATOS S":
                        cantidad = 1200; 
                        break;
                    case "DATOS M":
                        cantidad = 4200; 
                        break;
                    case "DATOS L":
                        cantidad = 7200; 
                        break;
                    case "DATOS XL":
                        cantidad = 13700; 
                        break;
                    case "DATOS XXL":
                        cantidad = 23200; 
                        break;
                }
            }
            return cantidad;
        }

        public static double addonCredito(string datoAddon, string planAddon)
        {
            double precio = 0; 
            if (datoAddon == "Addon on")
            {
                switch (planAddon)
                {
                    case "M":
                        precio = 20; 
                        break;
                    case "L":
                        precio = 50; 
                        break;
                    case "XL":
                        precio = 80; 
                        break;
                    case "Youtube":
                        precio = 50;
                        break;
                    case "Vimeo":
                        precio = 50;
                        break;
                }
            }
            return precio;
        }

        public static double totalCosto(string plan, string addon, string adicional)
        {
            double valor1 = tipoPlan(plan);
            double valor2 = cobroAddons(plan,addon);
            double valor3 = addonCredito("Addon on", adicional);
            return valor1 + valor2 + valor3;
        }

        public static bool accesoAddon(string plan)
        {
            bool value = false;
            if (plan == "Plan S a medida" || plan == "Plan M a medida" || plan == "Plan L a medida"
                || plan == "PLAN WAO")
            {
                value = true;
            }
            return value;
        }
    }
}
