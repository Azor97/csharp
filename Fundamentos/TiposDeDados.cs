using System;

public class Class1
{
	public class Tipos()
	{
		public void ConhecendoOsTipos()
	{
		//int
		int i = 10;

		//float
		float f = 10.9f; // Precisao baixa, tamanho 4 bytes. Exemplos: Trabalhando com numeros cientificos.

        //double
        double d = 20.9d; // Precisao baixa, tamanho 8 bytes. Exemplos: Trabalhando com numeros cientificos.

		//decimal
		decimal c = 21.8; // Precisao exata, tamanho 16 bytes. Exemplos: Trabalhando com dinheiro, valores de produtos.

		//bool
		bool b1 = true;
		bool b2 = false;

		//chat
		char c2 = 'A';

		//string
		string s2 = "Azor Ahai";

		//Atribuicao implicita:
		var cidade = "Belo Horizonte"; //String
		var idade = 30; //int

		idade = 55;

		//Constantes nao podem ser alteradas.
		const string pais = "Brasil";

		//Conversao de tipos
		f = idade;
		f = (float)c; //Conversao explicita

	}
	}
}
