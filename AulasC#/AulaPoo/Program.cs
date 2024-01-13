using ContaBanco.ContasBanco;
// using Transacao;
namespace MeuSuperBando2
{
    class Program 
    {
        static void Main(string[] args)
        {
            Banco contaB = new Banco("Willians", 1000);
            Console.WriteLine($"A conta {contaB.Numero} de: {contaB.Dono} foi criada com saldo: {contaB.Saldo}");

            contaB.Depositar(10000, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A consta está com {contaB.Saldo}");

            contaB.Sacar(10, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A consta está com {contaB.Saldo}");

            try
            {
                contaB.Sacar(10, DateTime.Now, "Recebi um pagamento");
                Console.WriteLine($"A consta está com {contaB.Saldo}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (Exception ex)
            {
                Console.WriteLine($"Operação não realizada");
            }

            contaB.Sacar(150, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A consta está com {contaB.Saldo}");

            contaB.Sacar(2000, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A consta está com {contaB.Saldo}");
            
            Console.WriteLine(contaB.PegarMovimentacao());
        }
    }

}