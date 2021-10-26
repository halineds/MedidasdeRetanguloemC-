using System;
using System.Globalization;

namespace Course {
	class Program {
		static void Main(string[] args) {

			string produto 1 = "Computador";
			string produto 2 = "Mesa de escritório";

			byte idade = 30;
			int codigo = 5290;
			char genero = 'M';

			double preco1 = 2100.0;
			double preco2 = 650.50;
			double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto 1} cujo preço é ${preco1:F2});
            Console.WriteLine($"{produto 2}, cujo preco é  ${preco2:F2})");
            
			Console.WriteLine("Registro: $"{idade} anos de idade, código $"{codigo} e genero: $"{genero}");

			Console.WriteLine("Medida com oito casas decimais:$"{medida:F8}");
			


			



		}
	}
}
