using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
			Console.WriteLine("INGRESAR PALABRA");
			palabra = Console.ReadLine();
			
			esPalindromo(palabra);
			
			Console.ReadKey();
        }
		
		public static void esPalindromo(string palabra)
		{
			palabra = palabra.Replace(" ", "");
			string palabraInvertida = invertirPalabra(palabra);
			
			
			if(palabra == palabraInvertida)
			{
				Console.WriteLine("ES PALINDROMO");
			}
			else
			{
				Console.WriteLine("NO ES PALINDROMO");
			}
		}
		
		public static string invertirPalabra(string palabra)
		{
			string palabraInvertida = "";
			
			foreach(char c in palabra)
			{
				palabraInvertida = c + palabraInvertida;
			}
			
			
			return palabraInvertida;
		}
    }
}
