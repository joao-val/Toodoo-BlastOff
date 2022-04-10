programa
{
	inclua biblioteca Matematica --> mat
	inclua biblioteca Tipos --> tp
	
	funcao inicio()
	{
		real salario
		inteiro quantidade
		cadeia salary
		logico teste

		escreva("Digite quantos softwares o funcionário vendeu para saber seu salário esse mês:\n")
		faca
		{
		escreva("Favor digitar um numero inteiro e positivo!\n")
		leia(salary)
		teste = tp.cadeia_e_inteiro(salary, 10)
		limpa()
		}enquanto(teste != verdadeiro ou (tp.cadeia_para_inteiro(salary, 10) < 0))
		
		quantidade =  tp.cadeia_para_inteiro(salary, 10)
		salario = (quantidade * 50) + 500

		escreva("O salário desse funcionário é: R$", mat.arredondar(salario, 2))
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 352; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */