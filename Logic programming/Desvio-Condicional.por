programa
{
	
	funcao inicio()
	{
		real N1, N2, media

		escreva ("Digite a primeira nota:\n")
		leia(N1)
		escreva ("Digite a segunda nota:\n")
		leia(N2)
		media = (N1 + N2)/2
		se (media >= 7)
		{
			escreva ("Aluno aprovado!\n")
		}
		senao se(media >=5)
		{
			escreva ("Recuperação!\n")
		}
		senao 
		{
			escreva ("Aluno reprovado!\n")
		}
		escreva ("Sua média é: ", media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 53; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */