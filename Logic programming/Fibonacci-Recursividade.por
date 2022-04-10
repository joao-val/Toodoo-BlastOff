programa
{
	
	funcao inicio()
	{
		inteiro num

		escreva("Digite um numero:\n")
		leia(num)
		limpa()
		
		para(inteiro i = 1; i <= num; i++)
		{
			escreva(fibonacci(i), "|")
		}
		escreva("\nFibonacci: ", fibonacci(num))
	}

	funcao inteiro fibonacci(inteiro x)
	{
		se((x == 0) ou (x == 1))
		{
			retorne x
		}
		retorne fibonacci(x-1) + fibonacci(x-2)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 356; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */