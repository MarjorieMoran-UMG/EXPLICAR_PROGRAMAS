using System;

namespace RandomToken
{
    class Program
    {
        public static string GeneraRespuesta(int min, int max) // Definimos los parametros min es minimo, max es maximo
        {                                                      // Lo que suceda en el random se guarda en GeneraRespuesta
            Random Res = new Random(); // Res nombre del Random e inicializamos
            int Mayus = Convert.ToInt32(Res.Next(65, 90)); // El entero ingresado por el usuario lleva ciertas condiciones para tomar su rango de datos 
            string Respuesta = "";                       // random en este caso 65, 90 según el código ASCII son las letras mayusculas
            if (((Mayus > min) & (Mayus < max))) // Cumple con los parametros para tomar el rango
            {
                Respuesta = Convert.ToString((char)Mayus); // Pasa a ser un string los datos char tomados del random
                                                            // En este caso genera un token de mayusculas
            }

            int Minus = Convert.ToInt32(Res.Next(97,122)); // Cumple lo mismo que el anterior pero con parametros diferente
            if (((Minus > min) & (Minus < max)))            // este es para minisculas
            {
                Respuesta = Convert.ToString((char)Minus);

            }

            int Num = Convert.ToInt32(Res.Next(48, 57)); // Cumple lo mismo con parametros para que el token sea  
            if (((Num > min) & (Num < max)))               // numerico
            {
                Respuesta = Convert.ToString((char)Num);

            }
            return Respuesta; // Devuelve el valor de la respuesta que se muestra en pantalla
        }
        static void Main(string[] args)
        {
            byte Cantidad, R;

            string LeerCant;
            Console.WriteLine("---------------------TU TOKEN--------------------");
            Console.Write("¿De cuantos números desea que se genere su código?");
            LeerCant = Console.ReadLine(); // Lee la cantidad ingresada como un tipo de dato string
            Cantidad = byte.Parse(LeerCant); // Guarda espacios enteros segun la cantidad ingresada 
                                            // Es decir pasa la cantidad leida a espacios

            string Respuesta = ""; // Definimos la respuesta segun lo que se indique
            for (R = 1; R <= Cantidad; R++) // R es igual a 1, CIERTO, R es menor que Cantidad, CIERTO
            {
                Respuesta = Respuesta + GeneraRespuesta(65,90); // La respuesta es la Respuesta que se genera en 
            }                                                  // Genera respuesta SEGUN LOS PARAMETROS, EN ESTE CASO
            Console.WriteLine($"Su token es={Respuesta}");     // SI LOS CAMBIO A 65,90 es un TOKEN DE MAYUSCULAS,
                                                    // 97, 122 TOKEN DE MINUSCULAS Y 48,57 TOKEN DE NUMEROS
        }
    }
}