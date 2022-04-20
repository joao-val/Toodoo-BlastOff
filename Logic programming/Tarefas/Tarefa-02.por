programa
{
	inclua biblioteca Matematica --> mat
	inclua biblioteca Tipos --> tp
	
	funcao inicio()
	{
		cadeia km1, km2, litro 
		real media
		logico teste1, teste2, teste3, teste4
		escreva("Média de Km/L do carro\n")
		
		faca
		{
		escreva("Favor digitar os numeros corretamente...(casas decimais separadas por '.')\n")	
		escreva("Digite a quilometragem no destino inicial:\n")
		leia(km1)
		
		escreva("Digite a quilometragem no destino final:\n")
		leia(km2)
		
		escreva("Digite a quantidade de gasolina gasta em L:\n")
		leia(litro)

		teste1 = (tp.cadeia_e_real(km1) ou tp.cadeia_e_inteiro(km1, 10))
		teste2 = (tp.cadeia_e_real(km2) ou tp.cadeia_e_inteiro(km2, 10))
		teste3 = (tp.cadeia_e_real(litro) ou tp.cadeia_e_inteiro(litro, 10))
		limpa()
		}enquanto ((teste1 e teste2 e teste3) == falso)

		teste4 = (tp.cadeia_para_real(km1) > 0 e tp.cadeia_para_real(km2) > 0 e tp.cadeia_para_real(litro) > 0 ) e (tp.cadeia_para_real(km1) < tp.cadeia_para_real(km2))
		se (teste4 == falso)
		{
			inicio()
		}
		
		
		media = (tp.cadeia_para_real(km2) - tp.cadeia_para_real(km1))/tp.cadeia_para_real(litro)
		escreva("Você fez ", mat.arredondar(media, 2), "Km em média, por litro de gasolina!")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 609; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */