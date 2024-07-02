namespace AS
{
    public class FuncionarioMeioPeriodo : Funcionarios
    {
        public FuncionarioMeioPeriodo(string nome,int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.SalarioPorHora = salarioPorHora;
            this.HorasTrabalhadas = horasTrabalhadas;
        }
        public string Nome;
        public int Matricula;
        public double SalarioPorHora;
        public double HorasTrabalhadas;

        public override double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabalhadas;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O funcionário de meio período {Nome}, trabalhou {HorasTrabalhadas} horas, recebendo {SalarioPorHora:C} por hora e receberá: {CalcularSalario():C}");
        }
        public double CalcularBonus()
        {
            return CalcularSalario() * 0.05;             
        }
    }
}