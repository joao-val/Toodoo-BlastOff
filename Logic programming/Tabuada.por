programa
{
	inclua biblioteca Util --> u
	inclua biblioteca Tipos --> tp
	
	funcao inicio()
	{
		inteiro num
		cadeia numero
		logico teste

		faca
		{
		limpa()
		escreva("Não vale números decimais nem caracteres!\n")
		escreva("Digite o número para a tabuada:\n")

		leia(numero)
		teste = tp.cadeia_e_inteiro(numero, 10)
		}enquanto(teste != verdadeiro)
		num = tp.cadeia_para_inteiro(numero, 10)
		
		escreva("\nTabuada de ", num, " é:\n")
		para(inteiro i = 1; i <= 10; i++)
		{
			escreva(num, "*", i ," = ")
			escreva(num * i,"\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 547; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */