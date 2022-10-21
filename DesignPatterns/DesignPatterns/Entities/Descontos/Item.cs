namespace DesignPatterns.Entities
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

    }
}