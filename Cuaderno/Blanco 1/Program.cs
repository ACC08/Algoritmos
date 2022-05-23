/*
 * Created by SharpDevelop.
 * User: ahcde
 * Date: 12/4/2022
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Blanco_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Introduzca una serie de numeros");
			string numeros = Console.ReadLine();
			foreach (char numero in numeros){
				Console.WriteLine(numero);
				
			}
			Console.ReadKey();
		}
	}
}