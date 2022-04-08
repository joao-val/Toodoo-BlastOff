programa
{
	
	funcao inicio()
	{
		inteiro vet[3], num, posicao=0

		para(inteiro i = 0; i <= 2; i++)
		{
			escreva ("Digite um número para inserir no array:")
			leia (vet[i])
		}
		
		escreva("Digite um número para pesquisar no array: ")
		leia(num)

		enquanto ((posicao < 2) e (vet[posicao] != num))
		{
			posicao++
		}

		
		se (vet[posicao] == num)
		{
			escreva("Número encontrado na posição: [", posicao + "]")
		}
		senao
		{
			escreva("Número não encontrado no array")
		}

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 431; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {vet, 6, 11, 3}-{num, 6, 19, 3}-{posicao, 6, 24, 7};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */