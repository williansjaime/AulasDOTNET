using System;
using System.Text;
using Transacao.Transacoes;
namespace ContaBanco.ContasBanco;
public class Banco
{
    public string Numero {get;}
    public string Dono { get; set;}
    public decimal Saldo {
        get{
            decimal saldo = 0;
            foreach (var item in todasTransacoes)
            {
                saldo += item.Valor;
            }
            return saldo;
        }
    }

    public static int numeroConta = 1234567890;

    private List<ClassTransacao> todasTransacoes = new List<ClassTransacao>();
    
    public Banco(string nome, decimal valor)
    {
        this.Dono = nome;
        numeroConta ++;
        this.Numero = numeroConta.ToString();
        this.Depositar(valor,DateTime.Now, "Saldo Inicial");
    }

    public void Depositar(decimal valor, DateTime data, string obs)
    {
        if(valor <=0){
            throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos depositos de valor 0 ou negativos");
        }
        ClassTransacao trans = new ClassTransacao(valor, data,obs);
        this.todasTransacoes.Add(trans);
        
    }
    public void Sacar(decimal valor, DateTime data, string obs)
    {
        if(valor <=0){
            throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos saque de valor 0 ou negativos");
        }
        if(Saldo - valor <=0){
            throw new InvalidOperationException("Essa operação não é permitida");
        }
        ClassTransacao trans = new ClassTransacao(-valor,data,obs);
        this.todasTransacoes.Add(trans);
    }

    public string PegarMovimentacao()
    {
        var movimentacoes = new StringBuilder();
        movimentacoes.AppendLine("Data\t\tvalor\t\tObs");
        foreach (var item in todasTransacoes){
            movimentacoes.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{item.Obs}");
        }

        return movimentacoes.ToString();

    }

}
