using Util;
using System;

namespace dados
{
    /// <summary>
    /// Procedimentos na conta do usuário
    /// </summary>
    public class Conta
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string CPF { get; set; }
        public double Saldo { get; protected set; }

        /// <summary>
        /// Retira uma quantidade da conta 
        /// </summary>
        /// <param name="valor">Indica o valor a ser sacado</param>
        public virtual double Sacar(double valor) //VIRTUAL serve para usar o metodo com algumas alterações em suas classes FILHO (com heranca da classe principal)
        {
            bool cpfvalido = true;
            do
            {
                double saque;
                System.Console.WriteLine("Qual o seu CPF?");
                CPF = Console.ReadLine();
                ValidacaoCPF v = new ValidacaoCPF();
                cpfvalido = v.checagemcpf(CPF);

                if (cpfvalido == true)
                {
                    System.Console.WriteLine("Qual o banco?");
                    Banco = Console.ReadLine();
                    System.Console.WriteLine("Qual a sua Agência?");
                    Agencia = Console.ReadLine();
                    System.Console.WriteLine("Qual sua conta corrente?");
                    ContaCorrente = Console.ReadLine();
                    System.Console.WriteLine("Qual o valor do saque?");
                    saque = Convert.ToDouble(Console.ReadLine());

                    return (Saldo - saque);
                }

            } while (cpfvalido == false);
                
        }
        /// <summary>
        /// Realiza um depósito na conta do cliente 
        /// </summary>
        /// <param name="valor"></param>
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        /// <summary>
        /// Retorna o saldo do cliente 
        /// </summary>
        /// <returns></returns>
        public double MeuSaldo()
        {
            return this.Saldo;
        }
    }
}