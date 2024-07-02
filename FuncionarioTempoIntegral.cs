
public class FuncionarioTempoIntegral : Funcionarios, IBonus
{
    public FuncionarioTempoIntegral(string nome, int matricula, double salario) : base(nome, matricula)
    {
        this.Salario = salario;
    }

    private double Salario;

    public override double CalcularSalario()
    {
        return Salario;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"O funcionário que trabalha em tempo integral {Nome}, de matrícula {Matricula} recebe {Salario:C}");
    }
    public double CalcularBonus()
    {
        return Salario * 0.1;             
    }
}
