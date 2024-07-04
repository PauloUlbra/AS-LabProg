public class Empresa 
{
    List<Funcionarios> funcionarios = new List<Funcionarios>();

    public void AdicionarFuncionario(Funcionarios funcionario)
    {
        funcionarios.Add(funcionario);
        Console.WriteLine("Funcionario adicionado com sucesso!");
    }
    public void RemoverFuncionario(int matricula)
    {
        Console.WriteLine("Funcionario removido com sucesso!");
        funcionarios.RemoveAll(f => f.Matricula == matricula);
    }
    public void ExibirFuncionarios()
    {
        foreach (Funcionarios funcionario in funcionarios)
        {
            Console.WriteLine($"-------------\nFuncionário Nº{funcionario.Matricula}:\n{funcionario.Nome}\nSalário {funcionario.CalcularSalario():C}");
        }
    }
}