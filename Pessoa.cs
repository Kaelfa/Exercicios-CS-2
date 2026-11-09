

namespace exercicios
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        public void exibir()
        {
            Console.WriteLine($" Nome: {Nome}\n Idade: {Idade}\n Cidade: {Cidade}");
        }
    }
}