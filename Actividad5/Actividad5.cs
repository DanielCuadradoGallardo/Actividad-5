using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            return String.Concat(vs);
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            Array.Sort(vs);
            return String.Concat(vs);
        }

        public static int contarCaracter(string[] vs, char v)
        {
            return String.Concat(vs).Count(x => x == v);

   
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            return vs1.Select((x,y) => x + vs2[y]).ToArray();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            return vs1.Select((x, y) => x * vs2[y]).ToArray();
        }

        public static bool isPalindromo(string entrada)
        {
            char[] array = entrada.ToArray();
            Array.Reverse(array);
            string reversed = new string(array).ToLower().Replace(" ", "");

            return reversed.Equals(entrada.ToLower().Replace(" ", ""));

        }

        public static int contarPalabras(string entrada)
        {
            if (entrada.Equals("")) { return 0; }
            return entrada.Split(' ').Length;
        }

        public static int contarCaracteres(string entrada)
        {
            if (entrada.Equals("")) { return 0; }
            return entrada.Replace(" ", "").Count();
        }
    }
}
