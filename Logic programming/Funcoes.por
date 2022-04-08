programa
{
	inclua biblioteca Util --> util
	
	funcao inicio()
	{
		inteiro n, res, result
		
		escreva("Digite um número para calcular seu cubo: ")
		leia(n)
		res = cubo(n)
		escreva("O cubo calculado é:", res, "\n")

		para (inteiro i =0; i < 10; i++)
		{
			result=cubo(i)
			escreva("O cubo de " , i, " é ", result)
			escreva("\n")
		}
	}

	funcao inteiro cubo (inteiro x)
	{
		inteiro resultado = 0
		resultado = x * x * x
		retorne resultado	
	}	

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 162; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */