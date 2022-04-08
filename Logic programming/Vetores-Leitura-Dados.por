programa
{
	inclua biblioteca Matematica -->mat
	
	funcao inicio()
	{
		real soma = 0, minhaNota
		real notas[4]

		escreva("Digite as 4 notas do aluno para saber a média e se foi aprovado:\n")
		para(inteiro posicao = 0; posicao <= 3; posicao++)
		{
			leia(notas[posicao])
			soma = notas[posicao] + soma
		}
		
		minhaNota = mat.arredondar(soma/4, 2)
		se (minhaNota >= 7)
		{
			escreva("Aprovado")
		}
		senao
		{
			escreva("Reprovado")
		}
		
		escreva("\nA primeira nota foi: ", notas[0])
		escreva("\nA segunda nota foi: ", notas[1])
		escreva("\nA terceira nota foi: ", notas[2])
		escreva("\nA quarta nota foi: ", notas[3])
		escreva("\nA média das notas é: ", minhaNota)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 693; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */