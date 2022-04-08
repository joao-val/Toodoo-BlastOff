programa
{
	
	funcao inicio()
	{

		inteiro inicial = 0, final = 9, meio = 0, busca, num, aux
		inteiro vet[10]
		logico dadoEncontrado = falso

		escreva("Preencher o array criado \n")
		para (inteiro i = 0; i <= 9; i++)
		{
			escreva ("Digite um número:")
			leia(num)
			vet[i] = num
		}

		para(inteiro i = 0; i <= 8; i++)
		{
			para(inteiro j = i+1; j <= 9; j++)
			{
				se (vet[i] > vet[j])
				{
					aux = vet[j]
					vet[j] = vet[i]
					vet[i] = aux
				}
			}
		}
		
		escreva("\nVetor ordenado. Preparado para busca binária:\n")

		para(inteiro i = 0; i < 10; i++)
		{
			escreva(vet[i], "\n")
		}
		escreva("\n")

		escreva("Digite um valor para procurar no vetor:\n")
		leia(busca)

		enquanto((inicial <= final) e (nao dadoEncontrado)) 
		{
			meio = (inicial + final)/2
			se (vet[meio] == busca)
			{
				dadoEncontrado = verdadeiro 
			}
			se (vet[meio] > busca)
			{
				final = meio -1
			}
			senao 
			{
				inicial = meio +1
			}
		}

		se (dadoEncontrado == verdadeiro)
		{
			escreva("Dado encontrado na posição: [", meio, "]")
		}
		senao
		{
			escreva("Informação não encontrada no vetor!")
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 894; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */