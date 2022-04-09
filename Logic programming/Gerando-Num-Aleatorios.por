programa
{
	inclua biblioteca Util --> u
	inclua biblioteca Tipos --> tp
	inclua biblioteca Texto --> tx
	
	funcao inicio()
	{
		cadeia texto
		inteiro numero, numAleatorio, resultado

		escreva("Digite um numero:\n")
		leia(numero)

		escreva("Número escolhido pelo computador:\n")
		numAleatorio = u.sorteia(0, 10)
		escreva(numAleatorio)
		escreva("\n")
		
		resultado = numero * numAleatorio
		escreva("O produto dos números é: ", resultado)
		escreva("\n")
		u.aguarde(3000)
		
		escreva("Gerando muitos número de forma aleatória: \n")
		para(inteiro i = 1; i<=100; i++)
		{
			escreva(u.sorteia(-100000, 100000), "\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 474; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */