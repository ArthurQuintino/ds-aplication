namespace AppTerceiro.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public char Sexo { get; set; }

        public Pessoa selectPessoa()
        { 
            Pessoa Objpessoa = new Pessoa();
            return Objpessoa;
        }
    }

}
