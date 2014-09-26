/*
 * Created by SharpDevelop.
 * User: ALUMNOS
 * Date: 25/09/2014
 * Time: 07:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Programa2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("dame el primer numero");
			int numero1=int.Parse(Console.ReadLine());
			Console.WriteLine("dame el segundo numero");
			int numero2=int.Parse(Console.ReadLine());
			
			int resultado = numero1-numero2;
			Console.WriteLine("el resultado es "+ resultado);
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}