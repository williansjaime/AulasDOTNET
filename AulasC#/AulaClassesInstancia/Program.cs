//Retornos e parametros
//Nivel de acessibilidade
//Sobrecargad e metodo
//Override
namespace Aula_23
{
    class Program{

        static void Main(string[] args){
            Console.WriteLine("Hello Lindão");
            //Instanciando
            Carro carro1 = new Carro("Eu sou o carro1");
            Carro carro2 = new Carro("Eu sou o carro2");
            Carro carro3 = new Carro("Eu sou o carro3");
            Console.WriteLine(carro1);
            Console.WriteLine(carro2);
            Console.WriteLine(carro3);
            //Instanciando
            // Carro carro1 = new Carro();
            // Carro carro2 = new Carro("Eu sou o carro2");
            // Carro carro3 = new Carro();
            // Console.WriteLine(carro1.DigaSeuNome("Carro 1"));
            // Console.WriteLine(carro2.DigaSeuNome());
            // Console.WriteLine(carro2.DigaADataDoSeuNascimento());
            // Console.WriteLine(carro3.DigaSeuNome("Carro 3"));
        }
    }
}

class Carro
{
    private string nome;
    public string SobreNome;

    public Carro(string Nome)
    {
        this.nome = Nome;
    }

    public Carro()
    {

    }

    public override string ToString()
    {
        return string.Format("Eu sou o carro {0} e nasci em {1}", this.nome, this.DigaADataDoSeuNascimento());
    } 

    public DateTime DigaADataDoSeuNascimento()
    {
        return DateTime.Now;
    }

    public string DigaSeuNome(){
        return nome;
    }

    public string DigaSeuNome(string Nome){
        return Nome;
    }

    private string DigaSeuSobrenome()
    {
        return string.Empty;
    }
}







// namespace Aula_22
// {
//     class Program{

//         static void Main(string[] args){
//             Console.WriteLine("Hello Lindão");
//             //Bolo
//             //Instanciando
//             Carro carro1 = new Carro();
//             carro1.Nome = "Willians";
//             Console.WriteLine(carro1.DigaSeuNome());
//         }
//     }
// }

// class Carro
// {
//     public string Nome {get; set;}
//     public string DigaSeuNome(){
//         return Nome;
//     }
// }