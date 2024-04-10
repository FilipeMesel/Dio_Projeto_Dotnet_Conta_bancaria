// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using Dio.bank;

internal class Program
{
    static List<Conta> Contas = new List<Conta>();
    private static void ListarContas()
    {
        if(Contas.Count > 0)
        {
            for(int i =0; i < Contas.Count; i++)
            {
                Console.WriteLine($"#{i+1} - {Contas[i].ToString()}");
            }
        }
    }

    private static void Sacar()
    {
        Console.WriteLine("Digite o numero da conta");
        int numeroConta = int.Parse(Console.ReadLine());
        if(numeroConta < Contas.Count)
        {
            Console.WriteLine("Digite o Valor:");
            double vlr = double.Parse(Console.ReadLine());
            Contas[numeroConta - 1].Sacar(vlr);
        }
        else {
            Console.WriteLine("Essa conta não existe!");
        }
    }

    private static void Depositar()
    {
        Console.WriteLine("Digite o numero da conta");
        int numeroConta = int.Parse(Console.ReadLine());
        if(numeroConta < Contas.Count)
        {
            Console.WriteLine("Digite o Valor:");
            double vlr = double.Parse(Console.ReadLine());
            Contas[numeroConta - 1].Depositar(vlr);
        }
        else {
            Console.WriteLine("Essa conta não existe!");
        }
    }

    private static void Transferir()
    {
        Console.WriteLine("Digite o numero da conta origem");
        int numeroContaOrigem = int.Parse(Console.ReadLine());
        if(numeroContaOrigem < Contas.Count)
        {
            Console.WriteLine("Digite o numero da conta destino");
            int numeroContaDestino= int.Parse(Console.ReadLine());
            if(numeroContaDestino < Contas.Count)
            {

                Console.WriteLine("Digite o Valor:");
                double vlr = double.Parse(Console.ReadLine());
                Contas[numeroContaOrigem - 1].Transferir(vlr, Contas[numeroContaDestino-1]);
            }
            else 
            {
                Console.WriteLine("Essa conta não existe!");
            }
        }
        else 
        {
            Console.WriteLine("Essa conta não existe!");
        }
    }

    private static void CadastroConta()
    {
        Console.WriteLine("Digite seu nome:");
        string Nome = Console.ReadLine();
        Console.WriteLine("1. Pessoa Fisica");
        Console.WriteLine("2. Pessoa Juridica");
        string Opcao = Console.ReadLine();
        int x = int.Parse(Opcao);
        
        TipoConta Tipo = TipoConta.PessoaFisica;
        if(x == 2)
        {
            Tipo = TipoConta.PessoaJuridica;
        }
        Conta c = new Conta(Tipo, 0, 100, Nome);
        Contas.Add(c);
    }
    private static void Main(string[] args)
    {
        bool executar = true;
        while (executar)
        {
            Console.WriteLine("1. Criar nova conta");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Transferir");
            Console.WriteLine("5. Limpar Tela");
            Console.WriteLine("6. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastroConta();
                    ListarContas();
                    break;
                case "2":
                    ListarContas();
                    Depositar();
                    break;
                case "3":
                    ListarContas();
                    Sacar();
                    break;
                case "4":
                    ListarContas();
                    Transferir();
                    ListarContas();
                    break;
                case "5":
                    Console.Clear();
                    break;
                case "6":
                    executar = false;
                    break;
            }
        }
    }
}