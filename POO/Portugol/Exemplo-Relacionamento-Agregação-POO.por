programa
{
	inclua biblioteca Util --> u

	
	funcao inicio()
	{
		Lutador[6]
		Lutador[0] = novo Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 3, 1)
		Lutador[1] = novo Lutador("Putscript", "Brasil", 29, 1.68, 57.8, 14, 2, 3)
		Lutador[2] = novo Lutador("Snapshadow", "EUA", 35, 1.65, 80.9, 12, 2, 1)
		Lutador[3] = novo Lutador("Dead Code", "Austrália", 28, 1.93, 81.6, 13, 0, 2)
		Lutador[4] = novo Lutador("Ufocobol", "Brasil", 37, 1.70, 119.3, 5, 4, 3)
		Lutador[5] = novo Lutador("Nerdaard", "EUA", 30, 1.81, 105.7, 12, 2, 4)

		UEC01 = novo Luta()
		UEC01.marcarLuta(L[0], L[1])
		UEC01.lutar()
		

	}

	funcao Luta()
	{
		Lutador desafiado
		Lutador desafiante
		inteiro rounds
		logico aprovada

		funcao marcarLuta(Lutador l1, Lutador l2)
		{
			se ((l1.getCategoria() == l2.getCategoria()) e l1 != l2)
			{
				aprovada = verdadeiro
				desafiado = l1
				desafiantes = l2
			}
			senao
			{
				aprovada = falso
				desafiado = nulo
				desafiante  = nulo
			}
		}

		funcao lutar()
		{
			se (aprovada)
			{
				desafiado.apresentar()
				desafiante.apresentar()
				vencedor = u.sorteia(0, 2)

				escolha (vencedor)
				caso 0: 
				escreva("Empatou!")
				desafiado.empatarLuta()
				desafiante.empatarLuta()
				pare
				
				caso 1:
				escreva(desafiado.getNome())
				desafiado.ganharLuta()
				desafiante.perderLuta()
				pare
				
				caso 2:
				escreva(desafiante.getNome())
				desafiado.perderLuta()
				desafiante.ganharLuta()
				pare
			}
			senao 
			{
				escreva("Luta não pode acontecer")
			}
		}

		funcao setDesafiado(Lutador dd)
		{
			desafiado = dd
		}

		funcao Lutador getDesafiado()
		{
			retorne desafiado
		}

		funcao setDesafiante(Lutador dd1)
		{
			desafiante = dd1
		}

		funcao Lutador getDesafiante()
		{
			retorne desafiante
		}
	}

	funcao Lutador()
	{
	cadeia nome
	cadeia nacionalidade
	inteiro idade
	real altura
	real peso
	cadeia categoria
	inteiro vitorias
	inteiro derrotas
	inteiro empates

	funcao construtor(cadeia no,
				   cadeia na,
				   inteiro id,
				   real al,
				   real pe,
				   inteiro vi,
				   inteiro de,
				   inteiro em)
	{
		nome = no
		nacionalidade = na
		idade = id
		altura = al
		setPeso(pe)
		vitorias = vi
		derrotas = de
		empates = em
	}
	
	funcao ganharLuta()
	{
		setVitorias(getVitorias() + 1)
	}

	funcao perderLuta()
	{
		setDerrotas(getDerrotas() + 1)
	}

	funcao empatarLuta()
	{
		setEmpates(getEmpates() + 1)
	}

	funcao apresentar()
	{
		escreva("Lutador: ", getNome(), "\n")
		escreva("Origem: ", getNacionalidade(), "\n")
		escreva("Idade: ", getIdade(), "\n")
		escreva("Altura: ", getAltura(), "m de altura \n")
		escreva("Peso: ", getPeso(), "Kg \n")
		escreva("Ganhou: ", getVitorias(), "\n")
		escreva("Perdeu: ", getDerrotas(), "\n")
		escreva("Empatou: ", getEmpates(), "\n")
	}

	funcao status()
	{
		escreva(getNome(), "\n")
		escreva("Categoria, peso: ", getCategoria(), "\n")
		escreva("Vitórias: ", getVitorias(), "\n")
		escreva("Derrotas: ", getDerrotas(), "\n")
		escreva("Empates: ", getEmpates(), "\n")		
	}


	funcao setNome(cadeia n)
	{
		nome = n
	}

	funcao cadeia getNome()
	{
		retorne nome
	}
	
	funcao setNacionalidade(cadeia na)
	{
		nacionalidade = na
	}

	funcao cadeia getNacionalidade()
	{
		retorne nacionalidade
	}
	
	funcao setIdade(inteiro i)
	{
		idade = i
	}

	funcao inteiro getIdade()
	{
		retorne idade
	}
	
	funcao setAltura(real a)
	{
		altura = a
	}

	funcao real getAltura()
	{
		retorne altura
	}
	
	funcao setPeso(real p)
	{
		peso = p
		setCategoria()
	}

	funcao real getPeso()
	{
		retorne peso
	}
	
	funcao setCategoria()
	{
		se(peso < 50.2)
		{
			categoria = "Inválido"
		}
		senao se(peso <= 70.3)
		{
			categoria = "Leve"
		}
		senao se(peso <= 83.9)
		{
			categoria = "Médio"
		}
		senao se(peso <= 120.2)
		{
			categoria = "Pesado"
		}
		senao
		{
			categoria = "Inválido"
		}
	}

	funcao cadeia getCategoria()
	{
		retorne categoria
	}
	
	funcao setVitorias(inteiro v)
	{
		vitorias = v
	}

	funcao inteiro getVitorias()
	{
		retorne vitorias
	}
	
	funcao setDerrotas(inteiro d)
	{
		derrotas = d
	}

	funcao inteiro getDerrotas()
	{
		retorne derrotas
	}	

		funcao setEmpates(inteiro em)
	{
		empates = em
	}

	funcao inteiro getEmpates()
	{
		retorne empates
	}
}	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 613; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */