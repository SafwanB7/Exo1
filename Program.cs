using System;
class Program{
	static void Main(string[] args){
		int nombre;
		int somme= 0;
		nombre=int.Parse(Console.ReadLine());
		if (nombre % 2 == 0){
			Console.WriteLine("le nombre est paire");
		}
		else{
			Console.WriteLine("le nombre est impaire");
		}
		for(int i = 1 ; i <= nombre ; i++){
			somme = somme + i ;
		}
		Console.WriteLine("la somme de tout les nombre jusqua " + nombre + "est de "+ somme);
	}
}
