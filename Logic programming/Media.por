programa
{
	
	funcao inicio()
	{
		cadeia res
		real n1, n2, n3, n4, media

		escreva ("Digite as quatro notas: \n")
		leia (n1, n2, n3, n4)
		media = (n1 + n2 + n3 + n4)/ 4

		se (media >= 7)
		{
			res = "Aprovado"
		}
		senao
		{
			res = "Reprovado"
		}
		escreva ("Resultado: ", res)
		
			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 253; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */