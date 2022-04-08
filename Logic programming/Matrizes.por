programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{	
		inteiro matriz[4][3]

		para (inteiro linha = 0; linha < 4; linha++)
		{
			para (inteiro coluna = 0; coluna < 3; coluna++)
			{
				//escreva("Entre com um número:\n")
				matriz[linha][coluna] = u.sorteia(100, 999)
				se(coluna < 3)
				{
					escreva(matriz[linha][coluna], "|")
				}
				senao
				{
					escreva("\n", matriz[linha][coluna])
				}
			}
			escreva("\n")
		}

		
		escreva(matriz[2][2])
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 427; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {matriz, 7, 10, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */