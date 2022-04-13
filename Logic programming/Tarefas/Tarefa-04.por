programa
{
	inclua biblioteca Matematica --> mat
	inclua biblioteca Tipos --> tp
	
	funcao inicio()
	{
		cadeia saldo, cheque
		real analise, check
		logico teste1, teste2
		
		escreva("Operação para sacar um cheque.\n\n")
		
		faca
		{
			escreva("Favor digitar no formato correto os valores(casas decimais separadas por '.')!\n")
			escreva("Digite o seu saldo atual:\n")
			leia(saldo)

			escreva("Valor do cheque:\n")
			leia(cheque)

			teste1 = (tp.cadeia_e_real(saldo) ou tp.cadeia_e_inteiro(saldo, 10))
			teste2 = (tp.cadeia_e_real(cheque) ou tp.cadeia_e_inteiro(cheque, 10))
			limpa()
		}enquanto ((teste1 e teste2) == falso ou (tp.cadeia_para_real(saldo) <=0 ou tp.cadeia_para_real(cheque) <=0))

		analise = tp.cadeia_para_real(saldo) - tp.cadeia_para_real(cheque)
		check = tp.cadeia_para_real(cheque)

		se (analise < 0)
		{
			escreva("Cheque negado, saldo insuficiente para transação!\n")
		}
		senao
		{
			escreva("Cheque no valor de R$", mat.arredondar(check, 2), " aprovado!\n") 
			escreva("Seu saldo atual após a transação é: R$", mat.arredondar(analise, 2), "\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 670; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */