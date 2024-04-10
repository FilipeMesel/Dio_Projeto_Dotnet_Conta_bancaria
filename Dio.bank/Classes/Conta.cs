using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta TipoConta, double Saldo, double Credito, string Nome)
        {
            this.Credito = Credito;
            this.Saldo = Saldo;
            this.Nome = Nome;
            this.TipoConta = TipoConta;
        }

        public bool Sacar(double vlr)
        {
            if(this.Saldo - vlr < (this.Credito*-1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            else 
            {
                this.Saldo -= vlr;
                Console.WriteLine($"Saldo Atual = {this.Saldo}");
                return true;
            }
        }

        public void Depositar(double vlr)
        {
            this.Saldo += vlr;
            Console.WriteLine($"Saldo Atual = {this.Saldo}");
        }

        public void Transferir(double vlr, Conta ContaDestino)
        {
            if(this.Sacar(vlr))
            {
                ContaDestino.Depositar(vlr);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Tipo conta {this.TipoConta} \n Nome: {this.Nome} \n Saldo: {this.Saldo} | Credito: {this.Credito}";
            return retorno;
        }
    }
}