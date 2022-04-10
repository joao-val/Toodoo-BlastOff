programa
{
	
	funcao inicio()
	{
		inteiro valor

		escreva("Digite um número:\n")
		leia(valor)

		limpa()
		
		escreva ("Fatorial de ", valor, " é: ", fatorial(valor), "\n")
		
		
	}

	funcao inteiro fatorial(inteiro numero)
	{
		se (numero <=1)
		{
			retorne 1
		}
		retorne numero * fatorial(numero -1)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 112; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */