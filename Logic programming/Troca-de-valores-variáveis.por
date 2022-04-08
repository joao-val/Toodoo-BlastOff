programa
{
	
	funcao inicio()
	{
		inteiro x, y, aux
		
		escreva("Vamos trocar os valores de x e y entre si:\n")
		escreva("Digite o valor para X: ")
		leia (x)
		escreva("Digite o valor para Y: ")
		leia (y)
		aux = y
		y = x
		x = aux
		
		escreva("\nAgora X vale: ", x, " e Y vale ", y)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 203; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {x, 6, 10, 1}-{y, 6, 13, 1}-{aux, 6, 16, 3};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */