namespace Transacao.Transacoes;

public class ClassTransacao
{
    public decimal Valor {get; set;}
    public DateTime Data {get; set;}
    public string Obs {get; set;}

    public ClassTransacao(decimal valor, DateTime data, string obs){
        this.Valor = valor;
        this.Data = data;
        this.Obs = obs;
    }
}