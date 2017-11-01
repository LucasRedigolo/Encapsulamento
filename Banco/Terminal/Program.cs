using System;
using dados;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                //Mostra um menu de opções para o usuário
                Console.WriteLine("Digite a opção");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Realizar saque");
                Console.WriteLine("3 - Realizar Depósito");
                Console.WriteLine("4 - Extrato");
                Console.WriteLine("9 - Sair");
                opcao = Int16.Parse(Console.ReadLine());
                
                //Recebe opção do usuário
                switch (opcao) 
                {
                    case 1:
                        Cliente c1 = new Cliente();
                        c1.CadastroPessoa();
                        break;

                    case 2:
                        Conta c = new Conta();
                        c.Sacar();
                        break;
                        
                    case 3:
                        REALIZAR DEPÓSITO
                        break;

                    case 4:
                        ExtratoCliente();
                        break;
                }
            }
            while (opcao != 9);
        }

    }
}
