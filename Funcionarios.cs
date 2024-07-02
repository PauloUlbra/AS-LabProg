namespace AS
{
    public abstract class Funcionarios
    {
        public Funcionarios(string nome, int matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }
        public Funcionarios()
        {
            Nome = "Não informado";
            Matricula = 0;
        }
        private string Nome;
        private int Matricula;

        public abstract double CalcularSalario();
        public abstract void ExibirInformacoes();
        
    }
}