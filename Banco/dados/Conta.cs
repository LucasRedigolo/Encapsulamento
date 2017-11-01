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
        public double Saldo { get; private set; }

        /// <summary>
        /// Retira uma quantidade da conta 
        /// </summary>
        /// <param name="valor"></param>
        public void Sacar(double valor)
        {
            bool cpfvalido = true;
            do
            {
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
