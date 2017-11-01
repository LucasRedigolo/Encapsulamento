
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
        public double Saldo { get; private set; }

        /// <summary>
        /// Retira uma quantidade da conta 
        /// </summary>
        /// <param name="valor"></param>
        public void Sacar(double valor)
        {
            this.Saldo -= valor;
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
