programa
{
	inclua biblioteca Tipos --> tp
	inclua biblioteca Texto --> tx
	inteiro numConta
	cadeia tipo
	cadeia dono
	//construtor
	real saldo
	logico status
	
	funcao inicio()
	{
	
	inteiro telaAtual = 0
		enquanto (telaAtual !=  1)
		{	
			limpa()
			escreva ("Opção 1: Abrir conta\n")
			escreva ("Opção 2: Fechar conta\n")
			escreva ("Opção 3: Depositar na conta\n")
			escreva ("Opção 4: Sacar da conta\n")
			escreva ("Opção 5: Sair\n")
			
			escolha (telaAtual)
			{
				caso 1:
				cadeia wish
				faca
				{
				escreva("Você deseja abrir uma conta? (Digite Sim ou Não)\n")
				leia(wish)
				se (tx.caixa_alta(wish) != "Sim")
				{
					escreva("Digite o tipo de conta que deseja criar:\n")
					escreva("Existem 2 opções 'CC' Conta Corrente ou 'CP' Conta Poupança!\n")
					leia(tipo)
					abrirConta(tipo)
				}
				}enquanto (tx.caixa_alta(wish) != "Sim" ou tx.caixa_alta(wish) != "Não")			
				pare
				
				caso 2: 	fecharConta() 	pare
				caso 3:
				cadeia valor
				escreva("Você deseja depositar quantos reais?(digite '.' para decimais)\n")
				faca
				{
				leia(valor)
				depositar(tp.cadeia_para_real(valor))
				
				}enquanto (tp.cadeia_e_real(valor))			
				pare
				caso 4:
				cadeia valor
				escreva("Você deseja sacar quantos reais?(digite '.' para decimais)\n")
				faca
				{
				leia(valor)
				sacar(tp.cadeia_para_real(valor))
				
				}enquanto (tp.cadeia_e_real(valor))		
				pare
				caso contrario: 
		 		escreva ("Opção Inválida !")
			}
		}
		escreva("Você escolheu sair, tenha um bom dia!")
	}

	funcao abrirConta(cadeia t)
	{
		setTipo(t)
		setStatus(verdadeiro)
		faca
		{
		limpa()
		escreva("Existem 2 opções 'CC' Conta Corrente ou 'CP' Conta Poupança!\n")
		se (t == "CC")
		{
			saldo = 50
		}
		senao se (t == "CP")
		{
			saldo = 150
		}
		}enquanto (t != "CP" ou t!= "CC")
	}
	
	funcao fecharConta()
	{
		se (saldo > 0)
		{
			escreva("Conta com dinheiro, é necessário que esteja vazia para fechar.\n")
		}
		senao se(saldo < 0)
		{
			escreva("Conta está em débito")
		}
		senao
		{
			setStatus(falso)
			escreva("Conta encerrada!\n")
		}
	}
	
	funcao depositar(real v)
	{
		
		se (getStatus() == verdadeiro)
		{
			setSaldo(getSaldo() + v)
		}
		senao
		{
			escreva("Impossível depositar, conta fechada ou não existe.\n")
		}
	}
	
	funcao sacar(real v)
	{
		se (getStatus())
		{
			se (getSaldo() > v)
			{
				setSaldo(getSaldo() - v)
			}
			senao
			{
				escreva("Saldo insuficiente")
			}
		}
		senao
		{
			escreva("Impossível sacar, conta fechada ou não existe.\n")
		}
	}
	
	funcao pagarMensal()
	{
		real v
		se (getTipo() == "CC")
		{
			v = 12
		}
		senao se (getTipo() == "CP")
		{
			v = 20
		}

		se (getStatus() == verdadeiro)
		{
			se (saldo > v)
			{
				setSaldo(getSaldo() - v)
			}
			senao
			{
				escreva("Saldo insuficiente.\n")
			}
		}
		senao
		{
			escreva("Impossível cobrar mensalidade, conta fechada ou não existe.\n")
		}
	}

	funcao setNumConta(inteiro n)
	{
		numConta = n
	}

	funcao inteiro getNumConta()
	{
		retorne numConta
	}

	funcao setTipo(cadeia t)
	{
		tipo = t
	}

	funcao cadeia getTipo()
	{
		retorne tipo
	}

	funcao setDono(cadeia d)
	{
		dono = d
	}

	funcao cadeia getDono()
	{
		retorne dono
	}

	funcao setSaldo(real s)
	{
		saldo = s
	}

	funcao real getSaldo()
	{
		retorne saldo
	}

	funcao setStatus(logico s)
	{
		status = s
	}

	funcao logico getStatus()
	{
		retorne status
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 2279; 
 * @DOBRAMENTO-CODIGO = [89];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */