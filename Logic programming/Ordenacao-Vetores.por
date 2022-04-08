programa
{
	
	funcao inicio()
	{
		inteiro vetor[8]
		inteiro aux

		para(inteiro i = 0; i <= 7; i++)
		{
			escreva("Digite um número: ")
			leia(vetor[i])
		}

		para(inteiro i = 0; i <= 6; i++)
		{
			para(inteiro j = i+1; j <= 7; j++)
			{
				se (vetor[i] > vetor[j])
				{
					aux = vetor[j]
					vetor[j] = vetor[i]
					vetor[i] = aux
				}
			}
		}

		para(inteiro i = 0; i <= 7; i++)
		{
			escreva(vetor[i] + " ")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 277; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {vetor, 6, 10, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */