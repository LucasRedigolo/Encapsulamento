using System;
using dados;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Depositar(250);

            System.Console.WriteLine(conta.MeuSaldo());
        }
    }
}
