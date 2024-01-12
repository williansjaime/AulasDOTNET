namespace Aula_20
{      
    class Program
    {
        static void Main(string[] args){
            
            Console.WriteLine("Hello, Willians Lindo");
            Carro carro = new Carro();
            carro.DigaSeuNome();

            Aviao aviao = new Aviao();
            aviao.DigaSeuNome();

            Teste.Carro carroteste = new Teste.Carro();
            carroteste.DigaSeuNome();            

            Console.Read();
        }
    }

    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um carro");
        }
    }

    class Aviao
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um Aviao");
        }
    }

}

namespace Teste
{
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um carro");
        }
    }

    class Aviao
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um Aviao");
        }
    }
}