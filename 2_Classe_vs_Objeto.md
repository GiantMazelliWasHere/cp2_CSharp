# 2. Classe vs. Objeto

## Classe: 
É o arquivo dentro do C# onde colocamos as propriedades e métodos de um determinado tema relacionado ao nosso app. 


## Objeto:
É a instanciação de uma Classe, seguindo os parâmetros de construção, geralmente realizada na classe Main do app.

## Código:

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Resposta1{

	internal class Estudante
	{

		protected string nome;
		protected int idade;
		protected in cpf;

		public Estudante(string nome, int idade, int cpf)
		{
			this.nome = nome;
			this.idade = idade;
			this.cpf = cpf;
		}
	}
}


using Resposta1;
using System

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Estudante Eduardo = new Estudante('Eduardo', 26, 23465234500)
		}
	}
}
