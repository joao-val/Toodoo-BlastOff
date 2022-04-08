programa
{
	inclua biblioteca Matematica -->mat
	
	funcao inicio()
	{
		real minhaNota
		real notas[] = {8.5, 5.0, 7.9, 9.2}

		
		minhaNota = mat.arredondar((notas[0] + notas[1] + notas[2] + notas[3])/4, 2)
		
		escreva("A primeira nota foi: ", notas[0])
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
 * @POSICAO-CURSOR = 455; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */