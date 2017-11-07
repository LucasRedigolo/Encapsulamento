namespace dados

{
    /// <summary>
    /// Herança da library CONTA
    /// </summary>
    public class ContaPessoaJuridica : Conta // eu posso utilizar essa classe com os mesmos atributos da library CONTA (no program.cs)
    {
       public override double Sacar(double valor) //OVERRIDE serve para vc alterar os metodos de uma classe PAI (ou da qual ganha a herança)
       {
           base.Saldo += valor + 0.10;
           return base.Saldo;
       }
    }
}