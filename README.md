# Conta Bancária com .NET e POO

Projeto simples de uma conta bancária elaborado para treinar os conceitos aprendidos de POO e .NET ao longo do bootcamp Coding the future by Avanade and Dio.

## Estrutura do projeto

O projeto conta com basicamente três arquivos importantes:

**1. TipoConta.cs**
Apresenta um enum para a lógica de alto nível das contas pessoa física e jurídica

**2. Conta.cs**
Apresenta a classe conta com todos os seus atributos:
* TipoConta
* Saldo 
* Credito
* Nome

E seus métodos:
* Sacar
* Depositar
* Transferir
* ToString

**1. Program.cs**
Representa a aplicação em si; contendo a regra de negócio do projeto

## Observações importantes
Note que o projeto está regido sob a ótica do gitflow, cuja release autal é a 0.0.1

## Como rodar

1. Clone o repositório

2. Acesse o diretório do projeto

3. Digite:
```bash
dotnet run
```