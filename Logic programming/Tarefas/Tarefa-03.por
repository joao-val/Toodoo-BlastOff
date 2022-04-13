programa
{
	inclua biblioteca Tipos --> tp
	inclua biblioteca Matematica --> mat
	
	funcao inicio()
	{
		real salario, financiamento
		cadeia salary, financing
		logico teste1, teste2
		
		escreva("Verificar possibilidade de financiamento!\n\n")
		
		faca
		{
			escreva("Favor digitar no formato correto (casas decimais separadas por '.').\n")
			escreva("Digite o seu salário atual:\n")
			leia(salary)

			escreva("Digite o valor que deseja no financiamento:\n")
			leia(financing)

			teste1 = (tp.cadeia_e_real(salary) ou tp.cadeia_e_inteiro(salary, 10))
			teste2 = (tp.cadeia_e_real(financing) ou tp.cadeia_e_inteiro(financing, 10))
			limpa()
		}enquanto (( teste1 e teste2) == falso ou (tp.cadeia_para_real(salary) < 0 ou tp.cadeia_para_real(financing) < 0))

		salario = tp.cadeia_para_real(salary)
		financiamento = tp.cadeia_para_real(financing)

		se (financiamento <= (salario *5))
		{
			escreva ("Financiamento concedido com sucesso!")
		}
		senao
		{
			escreva ("Financiamento negado!\n")
			escreva ("Seu limite de financiamento é: R$", mat.arredondar(salario*5, 2), "\n")
		}

		escreva ("Obrigado por nos consultar!\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 207; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */