
public class FuncionarioMeioPeriodo : Funcionarios
{
    public FuncionarioMeioPeriodo(string nome,int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula)
    {
        this.SalarioPorHora = salarioPorHora;
        this.HorasTrabalhadas = horasTrabalhadas;
    }

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
