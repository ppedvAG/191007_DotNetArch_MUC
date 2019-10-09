using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Techniken
{
    // 1) static
    public static class Erweiterungsmethoden
    {
        // 2) this - Schlüsselwort
        public static int Verdoppeln(this int input)
        {
            return input * 2;
        }

        public static string Umdrehen(this string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

    }
}
