using System;
using System.Linq;

public class Desafio{
	public static void Main(string[] args){
		double distancia, litros;
		string s;

		s = System.Console.ReadLine();

		double[] valores = s.Split(' ').Select(x=> double.Parse(x)).ToArray();
		distancia = valores[0] * valores[1];
		litros = distancia / 12.0;
		

		System.Console.WriteLine(litros.ToString("N3"));
	}
}